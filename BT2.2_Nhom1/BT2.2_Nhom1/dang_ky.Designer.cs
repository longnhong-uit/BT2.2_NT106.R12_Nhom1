namespace BT2._2_Nhom1
{
    partial class dang_ky
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
            lblDangKy = new Label();
            lblSDT = new Label();
            lblHo_ten = new Label();
            lblPassword = new Label();
            lblxac_nhan_Password = new Label();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhan = new TextBox();
            btnDangky = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            lblDaCoTaiKhoan = new Label();
            llbDangNhap = new LinkLabel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblBaoLoiSDT = new Label();
            lblBaoLoiHoTen = new Label();
            lblBaoLoiPassword = new Label();
            lblBaoLoiXacNhanPassword = new Label();
            lblBaoLoiEmail = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.BackColor = Color.White;
            lblDangKy.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDangKy.Location = new Point(53, 18);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(122, 37);
            lblDangKy.TabIndex = 0;
            lblDangKy.Text = "Đăng ký";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.Location = new Point(60, 107);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 20);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "SĐT đăng nhập";
            // 
            // lblHo_ten
            // 
            lblHo_ten.AutoSize = true;
            lblHo_ten.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHo_ten.Location = new Point(60, 156);
            lblHo_ten.Name = "lblHo_ten";
            lblHo_ten.Size = new Size(76, 20);
            lblHo_ten.TabIndex = 2;
            lblHo_ten.Text = "Họ và tên";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(60, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblxac_nhan_Password
            // 
            lblxac_nhan_Password.AutoSize = true;
            lblxac_nhan_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblxac_nhan_Password.Location = new Point(60, 254);
            lblxac_nhan_Password.Name = "lblxac_nhan_Password";
            lblxac_nhan_Password.Size = new Size(143, 20);
            lblxac_nhan_Password.TabIndex = 4;
            lblxac_nhan_Password.Text = "Xác nhận mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(250, 100);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(250, 149);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(250, 198);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(250, 27);
            txtMatKhau.TabIndex = 7;
            // 
            // txtXacNhan
            // 
            txtXacNhan.BorderStyle = BorderStyle.FixedSingle;
            txtXacNhan.Location = new Point(250, 247);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.PasswordChar = '*';
            txtXacNhan.Size = new Size(250, 27);
            txtXacNhan.TabIndex = 8;
            // 
            // btnDangky
            // 
            btnDangky.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDangky.Location = new Point(285, 356);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(119, 45);
            btnDangky.TabIndex = 9;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(56, 356);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(119, 45);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(410, 356);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 45);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblDaCoTaiKhoan
            // 
            lblDaCoTaiKhoan.AutoSize = true;
            lblDaCoTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblDaCoTaiKhoan.Location = new Point(117, 426);
            lblDaCoTaiKhoan.Name = "lblDaCoTaiKhoan";
            lblDaCoTaiKhoan.Size = new Size(145, 23);
            lblDaCoTaiKhoan.TabIndex = 12;
            lblDaCoTaiKhoan.Text = "Đã có tài khoản?";
            // 
            // llbDangNhap
            // 
            llbDangNhap.AutoSize = true;
            llbDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            llbDangNhap.LinkColor = Color.Black;
            llbDangNhap.Location = new Point(262, 426);
            llbDangNhap.Name = "llbDangNhap";
            llbDangNhap.Size = new Size(142, 23);
            llbDangNhap.TabIndex = 13;
            llbDangNhap.TabStop = true;
            llbDangNhap.Text = "Đăng nhập ngay";
            llbDangNhap.LinkClicked += llbDangNhap_LinkClicked;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(60, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(250, 296);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 15;
            // 
            // lblBaoLoiSDT
            // 
            lblBaoLoiSDT.AutoSize = true;
            lblBaoLoiSDT.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBaoLoiSDT.ForeColor = Color.Red;
            lblBaoLoiSDT.Location = new Point(253, 129);
            lblBaoLoiSDT.Name = "lblBaoLoiSDT";
            lblBaoLoiSDT.Size = new Size(0, 17);
            lblBaoLoiSDT.TabIndex = 16;
            // 
            // lblBaoLoiHoTen
            // 
            lblBaoLoiHoTen.AutoSize = true;
            lblBaoLoiHoTen.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblBaoLoiHoTen.ForeColor = Color.Red;
            lblBaoLoiHoTen.Location = new Point(248, 179);
            lblBaoLoiHoTen.Name = "lblBaoLoiHoTen";
            lblBaoLoiHoTen.Size = new Size(0, 16);
            lblBaoLoiHoTen.TabIndex = 17;
            // 
            // lblBaoLoiPassword
            // 
            lblBaoLoiPassword.AutoSize = true;
            lblBaoLoiPassword.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblBaoLoiPassword.ForeColor = Color.Red;
            lblBaoLoiPassword.Location = new Point(253, 227);
            lblBaoLoiPassword.Name = "lblBaoLoiPassword";
            lblBaoLoiPassword.Size = new Size(0, 16);
            lblBaoLoiPassword.TabIndex = 18;
            // 
            // lblBaoLoiXacNhanPassword
            // 
            lblBaoLoiXacNhanPassword.AutoSize = true;
            lblBaoLoiXacNhanPassword.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblBaoLoiXacNhanPassword.ForeColor = Color.Red;
            lblBaoLoiXacNhanPassword.Location = new Point(255, 275);
            lblBaoLoiXacNhanPassword.Name = "lblBaoLoiXacNhanPassword";
            lblBaoLoiXacNhanPassword.Size = new Size(0, 16);
            lblBaoLoiXacNhanPassword.TabIndex = 19;
            // 
            // lblBaoLoiEmail
            // 
            lblBaoLoiEmail.AutoSize = true;
            lblBaoLoiEmail.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblBaoLoiEmail.ForeColor = Color.Red;
            lblBaoLoiEmail.Location = new Point(255, 326);
            lblBaoLoiEmail.Name = "lblBaoLoiEmail";
            lblBaoLoiEmail.Size = new Size(0, 16);
            lblBaoLoiEmail.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 392);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(567, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 392);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 469);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 3);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(570, 80);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblDangKy);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(564, 74);
            panel5.TabIndex = 21;
            // 
            // dang_ky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 472);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBaoLoiEmail);
            Controls.Add(lblBaoLoiXacNhanPassword);
            Controls.Add(lblBaoLoiPassword);
            Controls.Add(lblBaoLoiHoTen);
            Controls.Add(lblBaoLoiSDT);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(llbDangNhap);
            Controls.Add(lblDaCoTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnDangky);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(lblxac_nhan_Password);
            Controls.Add(lblPassword);
            Controls.Add(lblHo_ten);
            Controls.Add(lblSDT);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dang_ky";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dang_ky";
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangKy;
        private Label lblSDT;
        private Label lblHo_ten;
        private Label lblPassword;
        private Label lblxac_nhan_Password;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtMatKhau;
        private TextBox txtXacNhan;
        private Button btnDangky;
        private Button btnHuy;
        private Button btnThoat;
        private Label lblDaCoTaiKhoan;
        private LinkLabel llbDangNhap;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBaoLoiSDT;
        private Label lblBaoLoiHoTen;
        private Label lblBaoLoiPassword;
        private Label lblBaoLoiXacNhanPassword;
        private Label lblBaoLoiEmail;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}