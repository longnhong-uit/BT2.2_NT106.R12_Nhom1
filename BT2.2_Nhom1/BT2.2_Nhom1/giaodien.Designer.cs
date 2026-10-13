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
            pnlLeft = new Panel();
            pnlDown = new Panel();
            pnlRight = new Panel();
            pnlUp = new Panel();
            pnlUpBody = new Panel();
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
            btnDangXuat.Margin = new Padding(2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(180, 45);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(0, 192, 0);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(3, 360);
            pnlLeft.TabIndex = 6;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.FromArgb(0, 192, 0);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.Location = new Point(3, 357);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(634, 3);
            pnlDown.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(0, 192, 0);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(637, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(3, 360);
            pnlRight.TabIndex = 7;
            // 
            // pnlUp
            // 
            pnlUp.BackColor = Color.FromArgb(0, 192, 0);
            pnlUp.Dock = DockStyle.Top;
            pnlUp.Location = new Point(3, 0);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(634, 80);
            pnlUp.TabIndex = 8;
            // 
            // pnlUpBody
            // 
            pnlUpBody.BackColor = Color.White;
            pnlUpBody.Location = new Point(3, 3);
            pnlUpBody.Name = "pnlUpBody";
            pnlUpBody.Size = new Size(634, 74);
            pnlUpBody.TabIndex = 9;
            // 
            // giaodien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 360);
            Controls.Add(lblTrangChinh);
            Controls.Add(pnlUpBody);
            Controls.Add(pnlDown);
            Controls.Add(pnlUp);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(btnDangXuat);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Panel pnlLeft;
        private Panel pnlDown;
        private Panel pnlRight;
        private Panel pnlUp;
        private Panel pnlUpBody;
    }
}