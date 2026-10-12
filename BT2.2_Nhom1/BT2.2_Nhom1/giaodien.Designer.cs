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
            lblTrangchinh = new Label();
            lblXinChao = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblLanDangNhap = new Label();
            BtnDangxuat = new Button();
            SuspendLayout();
            // 
            // lblTrangchinh
            // 
            lblTrangchinh.AutoSize = true;
            lblTrangchinh.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTrangchinh.Location = new Point(26, 9);
            lblTrangchinh.Name = "lblTrangchinh";
            lblTrangchinh.Size = new Size(373, 81);
            lblTrangchinh.TabIndex = 0;
            lblTrangchinh.Text = "Trang Chính";
            lblTrangchinh.Click += label1_Click;
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
            // BtnDangxuat
            // 
            BtnDangxuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDangxuat.Location = new Point(494, 352);
            BtnDangxuat.Name = "BtnDangxuat";
            BtnDangxuat.Size = new Size(185, 47);
            BtnDangxuat.TabIndex = 5;
            BtnDangxuat.Text = "Đăng xuất";
            BtnDangxuat.UseVisualStyleBackColor = true;
            BtnDangxuat.Click += btnDangXuat_Click;
            // 
            // giaodien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDangxuat);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            Controls.Add(lblTrangchinh);
            Name = "giaodien";
            Text = "giaodien";
            Load += giaodien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangchinh;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblLanDangNhap;
        private Button BtnDangxuat;
    }
}