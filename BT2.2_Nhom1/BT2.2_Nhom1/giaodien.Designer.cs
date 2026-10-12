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
            label1 = new Label();
            lblXinChao = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblLanDangNhap = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(373, 81);
            label1.TabIndex = 0;
            label1.Text = "Trang Chính";
            label1.Click += label1_Click;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(494, 352);
            button1.Name = "button1";
            button1.Size = new Size(185, 47);
            button1.TabIndex = 5;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDangXuat_Click;
            // 
            // giaodien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            Controls.Add(label1);
            Name = "giaodien";
            Text = "giaodien";
            Load += giaodien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblLanDangNhap;
        private Button button1;
    }
}