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
            btnDangxuat = new Button();
            SuspendLayout();
            // 
            // lblTrangChinh
            // 
            lblTrangChinh.AutoSize = true;
            lblTrangChinh.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTrangChinh.Location = new Point(26, 9);
            lblTrangChinh.Name = "lblTrangChinh";
            lblTrangChinh.Size = new Size(373, 81);
            lblTrangChinh.TabIndex = 0;
            lblTrangChinh.Text = "Trang Chính";
            lblTrangChinh.Click += label1_Click;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Location = new Point(57, 105);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(59, 25);
            lblXinChao.TabIndex = 1;
            lblXinChao.Text = "label2";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(57, 152);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(59, 25);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "label3";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(57, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "label4";
            // 
            // lblLanDangNhap
            // 
            lblLanDangNhap.AutoSize = true;
            lblLanDangNhap.Location = new Point(57, 248);
            lblLanDangNhap.Name = "lblLanDangNhap";
            lblLanDangNhap.Size = new Size(59, 25);
            lblLanDangNhap.TabIndex = 4;
            lblLanDangNhap.Text = "label5";
            // 
            // btnDangxuat
            // 
            btnDangxuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDangxuat.Location = new Point(494, 352);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(185, 47);
            btnDangxuat.TabIndex = 5;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = true;
            btnDangxuat.Click += btnDangXuat_Click;
            // 
            // giaodien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangxuat);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            Controls.Add(lblTrangChinh);
            Name = "giaodien";
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
        private Button btnDangxuat;
    }
}