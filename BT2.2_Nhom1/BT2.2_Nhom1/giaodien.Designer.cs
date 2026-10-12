namespace BT2._2_Nhom1
{
    partial class giaodien
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
            lblTrangChinh = new Label();
            lblXinChao = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblLanDangNhap = new Label();
            btnDangXuat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // lblTrangChinh
            // 
            lblTrangChinh.AutoSize = true;
            lblTrangChinh.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTrangChinh.Location = new Point(53, 18);
            lblTrangChinh.Margin = new Padding(2, 0, 2, 0);
            lblTrangChinh.Name = "lblTrangChinh";
            lblTrangChinh.Size = new Size(170, 37);
            lblTrangChinh.TabIndex = 0;
            lblTrangChinh.Text = "Trang Chính";
            lblTrangChinh.Click += label1_Click;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblXinChao.ForeColor = Color.FromArgb(0, 192, 0);
            lblXinChao.Location = new Point(60, 107);
            lblXinChao.Margin = new Padding(2, 0, 2, 0);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(51, 20);
            lblXinChao.TabIndex = 1;
            lblXinChao.Text = "label2";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(60, 205);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(50, 20);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "label3";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(60, 159);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "label4";
            // 
            // lblLanDangNhap
            // 
            lblLanDangNhap.AutoSize = true;
            lblLanDangNhap.Location = new Point(60, 254);
            lblLanDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblLanDangNhap.Name = "lblLanDangNhap";
            lblLanDangNhap.Size = new Size(50, 20);
            lblLanDangNhap.TabIndex = 4;
            lblLanDangNhap.Text = "label5";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDangXuat.Location = new Point(413, 285);
            btnDangXuat.Margin = new Padding(2, 2, 2, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(180, 45);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 360);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 3);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(637, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 360);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 80);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 74);
            panel5.TabIndex = 9;
            // 
            // giaodien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 360);
            Controls.Add(lblTrangChinh);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnDangXuat);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "giaodien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "giaodien";
            Load += giaodien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangChinh;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblLanDangNhap;
        private Button btnDangXuat;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}