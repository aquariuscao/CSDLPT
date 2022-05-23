
namespace QLDSV_TC
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.te_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.te_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.te_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_HienMatKhau
            // 
            this.checkBox_HienMatKhau.AutoSize = true;
            this.checkBox_HienMatKhau.Location = new System.Drawing.Point(216, 234);
            this.checkBox_HienMatKhau.Name = "checkBox_HienMatKhau";
            this.checkBox_HienMatKhau.Size = new System.Drawing.Size(118, 21);
            this.checkBox_HienMatKhau.TabIndex = 20;
            this.checkBox_HienMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_HienMatKhau.UseVisualStyleBackColor = true;
            this.checkBox_HienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_HienMatKhau_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login";
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(216, 119);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(209, 24);
            this.cb_Khoa.TabIndex = 18;
            this.cb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cb_Khoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Khoa";
            // 
            // te_MatKhau
            // 
            this.te_MatKhau.Location = new System.Drawing.Point(216, 195);
            this.te_MatKhau.Name = "te_MatKhau";
            this.te_MatKhau.Size = new System.Drawing.Size(209, 22);
            this.te_MatKhau.TabIndex = 16;
            this.te_MatKhau.EditValueChanged += new System.EventHandler(this.te_MatKhau_EditValueChanged_1);
            // 
            // te_TenDangNhap
            // 
            this.te_TenDangNhap.Location = new System.Drawing.Point(216, 158);
            this.te_TenDangNhap.Name = "te_TenDangNhap";
            this.te_TenDangNhap.Size = new System.Drawing.Size(209, 22);
            this.te_TenDangNhap.TabIndex = 15;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(288, 288);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(130, 48);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(152, 288);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(130, 48);
            this.btn_DangNhap.TabIndex = 13;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.checkBox_HienMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Khoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.te_MatKhau);
            this.Controls.Add(this.te_TenDangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Thông Tin Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_HienMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit te_MatKhau;
        private DevExpress.XtraEditors.TextEdit te_TenDangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}