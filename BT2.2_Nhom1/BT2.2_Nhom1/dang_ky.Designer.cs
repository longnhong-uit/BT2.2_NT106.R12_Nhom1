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
            DangKy = new Label();
            SDT_dang_nhap = new Label();
            ho_ten = new Label();
            mat_khau = new Label();
            xac_nhan_mat_khau = new Label();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhan = new TextBox();
            btndangky = new Button();
            huy = new Button();
            txtthoat = new Button();
            SuspendLayout();
            // 
            // DangKy
            // 
            DangKy.AutoSize = true;
            DangKy.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangKy.Location = new Point(40, 9);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(223, 67);
            DangKy.TabIndex = 0;
            DangKy.Text = "Đăng ký";
            // 
            // SDT_dang_nhap
            // 
            SDT_dang_nhap.AutoSize = true;
            SDT_dang_nhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SDT_dang_nhap.Location = new Point(86, 105);
            SDT_dang_nhap.Name = "SDT_dang_nhap";
            SDT_dang_nhap.Size = new Size(115, 20);
            SDT_dang_nhap.TabIndex = 1;
            SDT_dang_nhap.Text = "SĐT đăng nhập";
            // 
            // ho_ten
            // 
            ho_ten.AutoSize = true;
            ho_ten.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ho_ten.Location = new Point(86, 184);
            ho_ten.Name = "ho_ten";
            ho_ten.Size = new Size(76, 20);
            ho_ten.TabIndex = 2;
            ho_ten.Text = "Họ và tên";
            // 
            // mat_khau
            // 
            mat_khau.AutoSize = true;
            mat_khau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            mat_khau.Location = new Point(86, 259);
            mat_khau.Name = "mat_khau";
            mat_khau.Size = new Size(75, 20);
            mat_khau.TabIndex = 3;
            mat_khau.Text = "Mật khẩu";
            // 
            // xac_nhan_mat_khau
            // 
            xac_nhan_mat_khau.AutoSize = true;
            xac_nhan_mat_khau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            xac_nhan_mat_khau.Location = new Point(86, 338);
            xac_nhan_mat_khau.Name = "xac_nhan_mat_khau";
            xac_nhan_mat_khau.Size = new Size(143, 20);
            xac_nhan_mat_khau.TabIndex = 4;
            xac_nhan_mat_khau.Text = "Xác nhận mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(266, 105);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(305, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(266, 184);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(305, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(266, 259);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(305, 27);
            txtMatKhau.TabIndex = 7;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(266, 338);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.PasswordChar = '*';
            txtXacNhan.Size = new Size(305, 27);
            txtXacNhan.TabIndex = 8;
            // 
            // btndangky
            // 
            btndangky.Location = new Point(86, 380);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(119, 58);
            btndangky.TabIndex = 9;
            btndangky.Text = "Đăng ký";
            btndangky.UseVisualStyleBackColor = true;
            btndangky.Click += btndangky_Click;
            // 
            // huy
            // 
            huy.Location = new Point(331, 380);
            huy.Name = "huy";
            huy.Size = new Size(119, 58);
            huy.TabIndex = 10;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // txtthoat
            // 
            txtthoat.Location = new Point(589, 380);
            txtthoat.Name = "txtthoat";
            txtthoat.Size = new Size(119, 58);
            txtthoat.TabIndex = 11;
            txtthoat.Text = "Thoát";
            txtthoat.UseVisualStyleBackColor = true;
            txtthoat.Click += txtthoat_Click;
            // 
            // dang_ky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtthoat);
            Controls.Add(huy);
            Controls.Add(btndangky);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(xac_nhan_mat_khau);
            Controls.Add(mat_khau);
            Controls.Add(ho_ten);
            Controls.Add(SDT_dang_nhap);
            Controls.Add(DangKy);
            Name = "dang_ky";
            Text = "dang_ky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DangKy;
        private Label SDT_dang_nhap;
        private Label ho_ten;
        private Label mat_khau;
        private Label xac_nhan_mat_khau;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtMatKhau;
        private TextBox txtXacNhan;
        private Button btndangky;
        private Button huy;
        private Button txtthoat;
    }
}