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
            lb_dang_nhap = new Label();
            lb_SDT = new Label();
            lb_password = new Label();
            txt_SDT = new TextBox();
            txt_password = new TextBox();
            btn_dang_nhap = new Button();
            btn_thoat = new Button();
            llb_quen_mk = new LinkLabel();
            lb_ques = new Label();
            llb_dangky = new LinkLabel();
            lb_loidangnhap = new Label();
            lb_loimatkhau = new Label();
            SuspendLayout();
            // 
            // lb_dang_nhap
            // 
            lb_dang_nhap.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lb_dang_nhap.Location = new Point(60, 33);
            lb_dang_nhap.Name = "lb_dang_nhap";
            lb_dang_nhap.Size = new Size(182, 45);
            lb_dang_nhap.TabIndex = 0;
            lb_dang_nhap.Text = "Đăng Nhập";
            // 
            // lb_SDT
            // 
            lb_SDT.AutoSize = true;
            lb_SDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_SDT.Location = new Point(60, 121);
            lb_SDT.Name = "lb_SDT";
            lb_SDT.Size = new Size(117, 20);
            lb_SDT.TabIndex = 1;
            lb_SDT.Text = "SĐT Đăng nhập";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_password.Location = new Point(60, 186);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(75, 20);
            lb_password.TabIndex = 2;
            lb_password.Text = "Mật khẩu";
            // 
            // txt_SDT
            // 
            txt_SDT.BorderStyle = BorderStyle.FixedSingle;
            txt_SDT.ForeColor = SystemColors.WindowText;
            txt_SDT.Location = new Point(241, 115);
            txt_SDT.Multiline = true;
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(263, 40);
            txt_SDT.TabIndex = 3;
            txt_SDT.KeyPress += txt_SDT_KeyPress;
            txt_SDT.Leave += txt_SDT_Leave;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(241, 180);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(263, 37);
            txt_password.TabIndex = 4;
            txt_password.Leave += txt_password_Leave;
            // 
            // btn_dang_nhap
            // 
            btn_dang_nhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_nhap.Location = new Point(145, 306);
            btn_dang_nhap.Name = "btn_dang_nhap";
            btn_dang_nhap.Size = new Size(159, 50);
            btn_dang_nhap.TabIndex = 5;
            btn_dang_nhap.Text = "ĐĂNG NHẬP";
            btn_dang_nhap.UseVisualStyleBackColor = true;
            btn_dang_nhap.Click += btn_dang_nhap_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(325, 306);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(159, 50);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "THOÁT";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // llb_quen_mk
            // 
            llb_quen_mk.AutoSize = true;
            llb_quen_mk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llb_quen_mk.LinkColor = Color.Black;
            llb_quen_mk.Location = new Point(432, 265);
            llb_quen_mk.Name = "llb_quen_mk";
            llb_quen_mk.Size = new Size(123, 20);
            llb_quen_mk.TabIndex = 7;
            llb_quen_mk.TabStop = true;
            llb_quen_mk.Text = "Quên mật khẩu?";
            llb_quen_mk.LinkClicked += llb_quen_mk_LinkClicked;
            // 
            // lb_ques
            // 
            lb_ques.AutoSize = true;
            lb_ques.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_ques.Location = new Point(200, 395);
            lb_ques.Name = "lb_ques";
            lb_ques.Size = new Size(146, 20);
            lb_ques.TabIndex = 8;
            lb_ques.Text = "Chưa có tài khoản?";
            // 
            // llb_dangky
            // 
            llb_dangky.AutoSize = true;
            llb_dangky.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llb_dangky.LinkColor = Color.Black;
            llb_dangky.Location = new Point(352, 395);
            llb_dangky.Name = "llb_dangky";
            llb_dangky.Size = new Size(106, 20);
            llb_dangky.TabIndex = 9;
            llb_dangky.TabStop = true;
            llb_dangky.Text = "Đăng ký ngay";
            llb_dangky.LinkClicked += llb_dangky_LinkClicked;
            // 
            // lb_loidangnhap
            // 
            lb_loidangnhap.AutoSize = true;
            lb_loidangnhap.Font = new Font("Segoe UI", 6F);
            lb_loidangnhap.ForeColor = Color.Crimson;
            lb_loidangnhap.Location = new Point(242, 161);
            lb_loidangnhap.Name = "lb_loidangnhap";
            lb_loidangnhap.Size = new Size(0, 12);
            lb_loidangnhap.TabIndex = 10;
            // 
            // lb_loimatkhau
            // 
            lb_loimatkhau.AutoSize = true;
            lb_loimatkhau.Font = new Font("Segoe UI", 6F);
            lb_loimatkhau.ForeColor = Color.Crimson;
            lb_loimatkhau.Location = new Point(242, 223);
            lb_loimatkhau.Name = "lb_loimatkhau";
            lb_loimatkhau.Size = new Size(0, 12);
            lb_loimatkhau.TabIndex = 11;
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(614, 450);
            Controls.Add(lb_loimatkhau);
            Controls.Add(lb_loidangnhap);
            Controls.Add(llb_dangky);
            Controls.Add(lb_ques);
            Controls.Add(llb_quen_mk);
            Controls.Add(btn_thoat);
            Controls.Add(btn_dang_nhap);
            Controls.Add(txt_password);
            Controls.Add(txt_SDT);
            Controls.Add(lb_password);
            Controls.Add(lb_SDT);
            Controls.Add(lb_dang_nhap);
            ForeColor = SystemColors.WindowText;
            Name = "dang_nhap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_dang_nhap;
        private Label lb_SDT;
        private Label lb_password;
        private TextBox txt_SDT;
        private TextBox txt_password;
        private Button btn_dang_nhap;
        private Button btn_thoat;
        private LinkLabel llb_quen_mk;
        private Label lb_ques;
        private LinkLabel llb_dangky;
        private Label lb_loidangnhap;
        private Label lb_loimatkhau;
    }
}
