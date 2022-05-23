using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        String loginNameSV = "";
        String passSV = "";
        private SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bdsDSPM.DataSource = dt;
            cb_Khoa.DataSource = Program.bdsDSPM;
            cb_Khoa.DisplayMember = "PHONGBAN";
            cb_Khoa.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
            cb_Khoa.SelectedIndex = 1;
            cb_Khoa.SelectedIndex = 0;
            te_MatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cb_Khoa.SelectedItem = Program.mGroup;
                Program.servername = cb_Khoa.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {


            if (te_TenDangNhap.Text.Trim() == "" || te_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được trống", "ERROR", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = te_TenDangNhap.Text;
            Program.pass = te_MatKhau.Text;
            if (Program.KetNoi() == 1)
            {
                String strCmd = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }

            else
            {
                Program.mlogin = "Student";
                Program.pass = "123";
                loginNameSV = te_TenDangNhap.Text;
                passSV = te_MatKhau.Text;
                if (Program.KetNoi() == 0)
                {
                    //XtraMessageBox.Show("Vui lòng xem lại user name và password\n", "Lỗi đăng nhập", MessageBoxButtons.OK);
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại Username và Password.\n " , string.Empty, MessageBoxButtons.OK);
                    return;
                }
                String strCmd = "EXEC SP_LOGIN_SV '" + Program.mlogin + "', '" + loginNameSV + "','" + passSV + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }

            Program.mKhoa = cb_Khoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.pass;  

            if (Program.myReader == null) return;

            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmChinh.MANV.Text = "Mã NV = " + Program.username.ToUpper();
                Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
                Program.frmChinh.HienThiMenu();
                this.Close();
                Program.frmChinh.ShowDangNhap(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void checkBox_HienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_HienMatKhau.Checked)
            {
                te_MatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                te_MatKhau.Properties.UseSystemPasswordChar = true;
            }
        }

        private void te_MatKhau_EditValueChanged_1(object sender, EventArgs e)
        {
            te_MatKhau.Properties.UseSystemPasswordChar = true;
        }
    }
}
