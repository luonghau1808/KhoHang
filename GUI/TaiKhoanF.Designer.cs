namespace DuAn1_Nhom4.GUI
{
    partial class TaiKhoanF
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            txtChucVu = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtMa = new TextBox();
            groupBox2 = new GroupBox();
            lbcapchar = new Label();
            btnLuuMK = new Button();
            txtMaXacNhan = new TextBox();
            label7 = new Label();
            txtXacNhan = new TextBox();
            label8 = new Label();
            txtMKMoi = new TextBox();
            label6 = new Label();
            txtMkCu = new TextBox();
            txtTenDangNhap = new TextBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(354, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(354, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(354, 182);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(358, 267);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(358, 354);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 6;
            label5.Text = "Chức vụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(354, 53);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 8;
            label9.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(354, 145);
            label10.Name = "label10";
            label10.Size = new Size(109, 25);
            label10.TabIndex = 7;
            label10.Text = "Mật khẩu cũ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1373, 432);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtChucVu
            // 
            txtChucVu.BorderStyle = BorderStyle.FixedSingle;
            txtChucVu.Font = new Font("Segoe UI", 10.8F);
            txtChucVu.Location = new Point(548, 354);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.ReadOnly = true;
            txtChucVu.Size = new Size(457, 31);
            txtChucVu.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.8F);
            txtEmail.Location = new Point(548, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(457, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.8F);
            txtSDT.Location = new Point(548, 182);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(457, 31);
            txtSDT.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10.8F);
            txtHoTen.Location = new Point(548, 104);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(457, 31);
            txtHoTen.TabIndex = 8;
            // 
            // txtMa
            // 
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.Font = new Font("Segoe UI", 10.8F);
            txtMa.Location = new Point(548, 35);
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(457, 31);
            txtMa.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lbcapchar);
            groupBox2.Controls.Add(btnLuuMK);
            groupBox2.Controls.Add(txtMaXacNhan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtXacNhan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMKMoi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMkCu);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Controls.Add(label9);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 432);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1373, 565);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // lbcapchar
            // 
            lbcapchar.AutoSize = true;
            lbcapchar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbcapchar.Location = new Point(917, 393);
            lbcapchar.Name = "lbcapchar";
            lbcapchar.Size = new Size(88, 31);
            lbcapchar.TabIndex = 20;
            lbcapchar.Text = "label11";
            // 
            // btnLuuMK
            // 
            btnLuuMK.Location = new Point(612, 478);
            btnLuuMK.Name = "btnLuuMK";
            btnLuuMK.Size = new Size(282, 35);
            btnLuuMK.TabIndex = 19;
            btnLuuMK.Text = "Lưu thay đổi";
            btnLuuMK.UseVisualStyleBackColor = true;
            btnLuuMK.Click += btnLuuMK_Click;
            // 
            // txtMaXacNhan
            // 
            txtMaXacNhan.BorderStyle = BorderStyle.FixedSingle;
            txtMaXacNhan.Font = new Font("Segoe UI", 10.8F);
            txtMaXacNhan.Location = new Point(548, 391);
            txtMaXacNhan.Name = "txtMaXacNhan";
            txtMaXacNhan.Size = new Size(185, 31);
            txtMaXacNhan.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(354, 398);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 17;
            label7.Text = "Nhập mã: ";
            // 
            // txtXacNhan
            // 
            txtXacNhan.BorderStyle = BorderStyle.FixedSingle;
            txtXacNhan.Font = new Font("Segoe UI", 10.8F);
            txtXacNhan.Location = new Point(548, 304);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(457, 31);
            txtXacNhan.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(354, 310);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 15;
            label8.Text = "Xác nhận mật khẩu";
            // 
            // txtMKMoi
            // 
            txtMKMoi.BorderStyle = BorderStyle.FixedSingle;
            txtMKMoi.Font = new Font("Segoe UI", 10.8F);
            txtMKMoi.Location = new Point(548, 226);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(457, 31);
            txtMKMoi.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(354, 233);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 13;
            label6.Text = "Mật khẩu mới";
            // 
            // txtMkCu
            // 
            txtMkCu.BorderStyle = BorderStyle.FixedSingle;
            txtMkCu.Font = new Font("Segoe UI", 10.8F);
            txtMkCu.Location = new Point(548, 139);
            txtMkCu.Name = "txtMkCu";
            txtMkCu.Size = new Size(457, 31);
            txtMkCu.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 10.8F);
            txtTenDangNhap.Location = new Point(548, 46);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.Size = new Size(457, 31);
            txtTenDangNhap.TabIndex = 11;
            txtTenDangNhap.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(798, 397);
            label11.Name = "label11";
            label11.Size = new Size(107, 25);
            label11.TabIndex = 21;
            label11.Text = "Mã capchar:";
            // 
            // TaiKhoanF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 997);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TaiKhoanF";
            Text = "TaiKhoanF";
            Load += TaiKhoanF_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtChucVu;
        private TextBox txtTenDangNhap;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtMa;
        private TextBox txtMkCu;
        private Button btnLuuMK;
        private TextBox txtMaXacNhan;
        private Label label7;
        private TextBox txtXacNhan;
        private Label label8;
        private TextBox txtMKMoi;
        private Label label6;
        private Label lbcapchar;
        private Label label11;
    }
}