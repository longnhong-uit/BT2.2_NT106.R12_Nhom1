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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDangNhap.Location = new Point(53, 18);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(161, 43);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "Đăng Nhập";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(60, 107);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(117, 20);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "SĐT Đăng nhập";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(60, 156);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(230, 100);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 3;
            txtSDT.KeyPress += txtSDT_KeyPress;
            txtSDT.Leave += txtSDT_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(230, 149);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 9F);
            btnDangNhap.Location = new Point(187, 252);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(119, 45);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F);
            btnThoat.Location = new Point(323, 252);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 45);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // llbQuenMk
            // 
            llbQuenMk.AutoSize = true;
            llbQuenMk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbQuenMk.LinkColor = SystemColors.WindowText;
            llbQuenMk.Location = new Point(370, 214);
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
            lblQues.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblQues.Location = new Point(143, 335);
            lblQues.Name = "lblQues";
            lblQues.Size = new Size(146, 20);
            lblQues.TabIndex = 8;
            lblQues.Text = "Chưa có tài khoản?";
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llbDangKy.LinkColor = SystemColors.WindowText;
            llbDangKy.Location = new Point(295, 335);
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
            lblLoiMatKhau.Location = new Point(230, 179);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 20);
            lblLoiMatKhau.TabIndex = 11;
            // 
            // lblLoiDangNhap
            // 
            lblLoiDangNhap.AutoSize = true;
            lblLoiDangNhap.ForeColor = Color.Crimson;
            lblLoiDangNhap.Location = new Point(230, 129);
            lblLoiDangNhap.Name = "lblLoiDangNhap";
            lblLoiDangNhap.Size = new Size(0, 20);
            lblLoiDangNhap.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 393);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 3);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(547, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 390);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(544, 80);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(544, 74);
            panel5.TabIndex = 0;
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 393);
            Controls.Add(lblDangNhap);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "dang_nhap";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
