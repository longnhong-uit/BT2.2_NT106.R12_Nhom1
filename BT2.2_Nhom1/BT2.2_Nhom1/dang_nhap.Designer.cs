namespace BT2._2_Nhom1
{
    partial class dang_nhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDangNhap = new Label();
            lblSDT = new Label();
            lblPassword = new Label();
            txtSDT = new TextBox();
            txtPassword = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            llbQuenMk = new LinkLabel();
            lblQues = new Label();
            llbDangKy = new LinkLabel();
            lblLoiMatKhau = new Label();
            lblLoiDangNhap = new Label();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangNhap.Location = new Point(55, 21);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(337, 65);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(187, 127);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(117, 20);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "SĐT Đăng nhập";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(187, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(323, 124);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(263, 40);
            txtSDT.TabIndex = 3;
            txtSDT.KeyPress += txtSDT_KeyPress;
            txtSDT.Leave += txtSDT_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(323, 194);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 37);
            txtPassword.TabIndex = 4;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(187, 301);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(159, 50);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(410, 301);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(159, 50);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // llbQuenMk
            // 
            llbQuenMk.AutoSize = true;
            llbQuenMk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbQuenMk.Location = new Point(538, 267);
            llbQuenMk.Name = "llbQuenMk";
            llbQuenMk.Size = new Size(123, 20);
            llbQuenMk.TabIndex = 7;
            llbQuenMk.TabStop = true;
            llbQuenMk.Text = "Quên mật khẩu?";
            llbQuenMk.LinkClicked += llb_quen_mk_LinkClicked;
            // 
            // lblQues
            // 
            lblQues.AutoSize = true;
            lblQues.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQues.Location = new Point(246, 390);
            lblQues.Name = "lblQues";
            lblQues.Size = new Size(146, 20);
            lblQues.TabIndex = 8;
            lblQues.Text = "Chưa có tài khoản?";
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llbDangKy.Location = new Point(398, 390);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(106, 20);
            llbDangKy.TabIndex = 9;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "Đăng ký ngay";
            llbDangKy.LinkClicked += llb_dangky_LinkClicked;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.ForeColor = Color.Crimson;
            lblLoiMatKhau.Location = new Point(323, 234);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 20);
            lblLoiMatKhau.TabIndex = 11;
            // 
            // lblLoiDangNhap
            // 
            lblLoiDangNhap.AutoSize = true;
            lblLoiDangNhap.ForeColor = Color.Crimson;
            lblLoiDangNhap.Location = new Point(323, 167);
            lblLoiDangNhap.Name = "lblLoiDangNhap";
            lblLoiDangNhap.Size = new Size(0, 20);
            lblLoiDangNhap.TabIndex = 10;
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(lblLoiDangNhap);
            Controls.Add(llbDangKy);
            Controls.Add(lblQues);
            Controls.Add(llbQuenMk);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(txtSDT);
            Controls.Add(lblPassword);
            Controls.Add(lblSDT);
            Controls.Add(lblDangNhap);
            Name = "dang_nhap";
            Text = "Form1";
            Leave += txtPassword_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private Label lblSDT;
        private Label lblPassword;
        private TextBox txtSDT;
        private TextBox txtPassword;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel llbQuenMk;
        private Label lblQues;
        private LinkLabel llbDangKy;
        private Label lblLoiMatKhau;
        private Label lblLoiDangNhap;
    }
}
