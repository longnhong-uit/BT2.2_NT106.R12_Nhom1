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
            lbDangNhap = new Label();
            lbSDT = new Label();
            lbPassword = new Label();
            txtSDT = new TextBox();
            txtPassword = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            llbQuenMk = new LinkLabel();
            lbQues = new Label();
            llbDangKy = new LinkLabel();
            lbLoiDangNhap = new Label();
            lbLoiMatKhau = new Label();
            SuspendLayout();
            // 
            // lbDangNhap
            // 
            lbDangNhap.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDangNhap.Location = new Point(55, 21);
            lbDangNhap.Name = "lbDangNhap";
            lbDangNhap.Size = new Size(337, 65);
            lbDangNhap.TabIndex = 0;
            lbDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSDT.Location = new Point(187, 127);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(117, 20);
            lbSDT.TabIndex = 1;
            lbSDT.Text = "SĐT Đăng nhập";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(187, 194);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(75, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(323, 124);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(263, 40);
            txtSDT.TabIndex = 3;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(323, 194);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 37);
            txtPassword.TabIndex = 4;
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
            // lbQues
            // 
            lbQues.AutoSize = true;
            lbQues.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbQues.Location = new Point(246, 390);
            lbQues.Name = "lbQues";
            lbQues.Size = new Size(146, 20);
            lbQues.TabIndex = 8;
            lbQues.Text = "Chưa có tài khoản?";
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
            // lbLoiDangNhap
            // 
            lbLoiDangNhap.AutoSize = true;
            lbLoiDangNhap.ForeColor = Color.Crimson;
            lbLoiDangNhap.Location = new Point(323, 167);
            lbLoiDangNhap.Name = "lbLoiDangNhap";
            lbLoiDangNhap.Size = new Size(0, 20);
            lbLoiDangNhap.TabIndex = 10;
            lbLoiDangNhap.Leave += txtSDT_Leave;
            // 
            // lbLoiMatKhau
            // 
            lbLoiMatKhau.AutoSize = true;
            lbLoiMatKhau.ForeColor = Color.Crimson;
            lbLoiMatKhau.Location = new Point(323, 234);
            lbLoiMatKhau.Name = "lbLoiMatKhau";
            lbLoiMatKhau.Size = new Size(0, 20);
            lbLoiMatKhau.TabIndex = 11;
            lbLoiMatKhau.Leave += txtPassword_Leave;
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbLoiMatKhau);
            Controls.Add(lbLoiDangNhap);
            Controls.Add(llbDangKy);
            Controls.Add(lbQues);
            Controls.Add(llbQuenMk);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(txtSDT);
            Controls.Add(lbPassword);
            Controls.Add(lbSDT);
            Controls.Add(lbDangNhap);
            Name = "dang_nhap";
            Text = "Form1";
            Leave += txtPassword_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDangNhap;
        private Label lbSDT;
        private Label lbPassword;
        private TextBox txtSDT;
        private TextBox txtPassword;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel llbQuenMk;
        private Label lbQues;
        private LinkLabel llbDangKy;
        private Label lbLoiDangNhap;
        private Label lbLoiMatKhau;
    }
}
