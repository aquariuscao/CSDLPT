using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Windows.Forms;
// sử dụng kiểu kết nối với Database là sqlclient
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace QLDSV_HTC
{
    static class Program1 // fix lại nè
    {
        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection conn = new SqlConnection();
        // dùng để thực thi lệnh, hình như k có cũng dc
        public static SqlCommand Sqlcmd = new SqlCommand();
        // chuỗi kết nối connection string để kết nối với csdl , nó bước đầu tiên để thực hiện kết nối 
        public static String connstr;
        public static String connstr_publicsher = "Data Source=DESKTOP-OK3NI6I;Initial Catalog=QLDSV_TC;Integrated Security=True";
        public static SqlDataReader myReader;
        // những dòng này dùng trong phần tạo connection string ở bên dưới
        public static String servername = "";
        public static String username = "";
        // lưu các login và password từ các form khi chương trình chạy.
        public static String mlogin = "";
        public static String mpass = "";

        //khai báo hỗ trợ kết nối
        public static String database = "QLDSV_TC";
        public static String remoteLogin = "HTKN"; //kết nối site khác
        public static String remotePass = "123456"; //kết nối site khác
        public static String mloginDN = ""; //loginname hiện tại
        public static String mpassDN = "";//pass hiện tại
        public static String mNhomUser = ""; //khoa-pgv-pkt
        public static String mHoten = "";
        public static int mKhoa = 0;//khoa cntt hay vt

        //biến dùng để chứa danh sách các phân mãnh từ view 
        public static BindingSource Bds_Dspm = new BindingSource();

        // lưu các đối tượng form Main và form FrmDangNhap để thực hiển xử lý nghiệp vụ chuyển đổi từ frmMain sang frmDangNhap và ngược lại.
        public static formMain frmMain;
        public static formLogin frmLogin;

        // hàm thực hiện kết nối tới Database
        public static int KetNoi()
        {
            if (Program1.conn != null && Program1.conn.State == ConnectionState.Open)
                // đóng đối tượng kết nối
                Program1.conn.Close();
            try
            {
                Program1.connstr = "Data Source=" + Program1.servername + ";Initial Catalog=" +
                      Program1.database + ";User ID=" +
                      Program1.mlogin + ";Password=" + Program1.mpass;
                Program1.conn.ConnectionString = Program1.connstr;

                // mở đối tượng kết nối
                Program1.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại Username và Password.\n " + e.Message, string.Empty, MessageBoxButtons.OK);
                return 0;
            }
        }
        // ExecSqlDataReader tôc độ tải về nhanh hơn ExecSqlDataTable vì đối tượng nó chỉ quam tân chỉ select
        // chỉ duyệt 1 chiều từ trên xuống
        // vì vậy trong nghiệp vụ form báo cáo thì dùng datareader
        // https://youtu.be/z8pgdIbtV3E?t=3233
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            //strLenh dc hiểu như 1 câu lệnh Select
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program1.conn);
            //xác định kiểu lệnh cho sqlcmd là kiểu text.
            sqlcmd.CommandType = CommandType.Text;
            if (conn != null && Program1.conn.State == ConnectionState.Closed) Program1.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program1.conn.Close();
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        // tải về cho phép xem xóa sửa ==> tốc độ tải chậm hơn cái ở trên
        // duyệt 2 chiều dưới lên
        // form nhập liệu thì dùng datatable.

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program1.conn.State == ConnectionState.Closed) Program1.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string strlenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strlenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            //sqlcmd.CommandTimeout = 600; // 10 phút cmd lại test thử nè
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format cell lại cột \"Ngày \" qua kiểu Number hoặc mở file Excel.");
                else
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                return ex.State; // trạng thái lỗi gởi từ RaisError trong sql server qua
            }
        }
        //Bản thân.NET framework có 1 threadpool riêng. Mỗi process (có thể hiểu là application) được cấp 1 căn hộ(thread aparment) riêng trong cái pool đó.
        //Mỗi dòng lệnh sẽ được đưa lần lượt từng lệnh vào apartment dành riêng trên để thực hiện tuần tự.Còn [STAThread] là attribute để cho .NET loader biết dòng code đầu tiên (Entry Point) trong chương trình nằm ở chỗ nào.
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new formLogin();
            Application.Run(frmLogin);
        }
    }
}