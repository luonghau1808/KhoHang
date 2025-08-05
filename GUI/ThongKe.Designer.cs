namespace DuAn1_Nhom4.GUI
{
    partial class ThongKe
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
            groupBox1 = new GroupBox();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            panel4 = new Panel();
            lblKhachHang = new Label();
            label10 = new Label();
            panel3 = new Panel();
            lblTonKho = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblTongPhieuNhap = new Label();
            label9 = new Label();
            panel1 = new Panel();
            lblTongPhieuXuat = new Label();
            label8 = new Label();
            dgvNhanVien = new DataGridView();
            label15 = new Label();
            lblTongDoanhThu = new Label();
            cmbBoLocNhanVien = new ComboBox();
            label3 = new Label();
            dgvDoanhThu = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ lọc thống kê doanh thu";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(176, 280);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 13;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(193, 200);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 9;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(193, 74);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(15, 200);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 4;
            label1.Text = "Đến ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 3;
            label2.Text = "Từ ngày:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(544, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1086, 282);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblKhachHang);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(840, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 118);
            panel4.TabIndex = 4;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKhachHang.Location = new Point(54, 43);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(82, 28);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "label14";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Location = new Point(54, 11);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 5;
            label10.Text = "Khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTonKho);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(585, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 118);
            panel3.TabIndex = 3;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTonKho.Location = new Point(54, 43);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(82, 28);
            lblTonKho.TabIndex = 6;
            lblTonKho.Text = "label13";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(58, 11);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 5;
            label7.Text = "Tồn kho";
            label7.Click += label7_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTongPhieuNhap);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(325, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 118);
            panel2.TabIndex = 2;
            // 
            // lblTongPhieuNhap
            // 
            lblTongPhieuNhap.AutoSize = true;
            lblTongPhieuNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongPhieuNhap.Location = new Point(54, 43);
            lblTongPhieuNhap.Name = "lblTongPhieuNhap";
            lblTongPhieuNhap.Size = new Size(82, 28);
            lblTongPhieuNhap.TabIndex = 6;
            lblTongPhieuNhap.Text = "label12";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(22, 11);
            label9.Name = "label9";
            label9.Size = new Size(146, 23);
            label9.TabIndex = 5;
            label9.Text = "Tổng phiếu nhập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTongPhieuXuat);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(64, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 118);
            panel1.TabIndex = 1;
            // 
            // lblTongPhieuXuat
            // 
            lblTongPhieuXuat.AutoSize = true;
            lblTongPhieuXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongPhieuXuat.Location = new Point(54, 43);
            lblTongPhieuXuat.Name = "lblTongPhieuXuat";
            lblTongPhieuXuat.Size = new Size(82, 28);
            lblTongPhieuXuat.TabIndex = 6;
            lblTongPhieuXuat.Text = "label11";
            lblTongPhieuXuat.Click += lblTongPhieuXuat_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(26, 11);
            label8.Name = "label8";
            label8.Size = new Size(141, 23);
            label8.TabIndex = 5;
            label8.Text = "Tổng phiếu xuất";
            label8.Click += label8_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(544, 355);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1086, 457);
            dgvNhanVien.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F);
            label15.Location = new Point(79, 734);
            label15.Name = "label15";
            label15.Size = new Size(203, 23);
            label15.TabIndex = 8;
            label15.Text = "Tổng doanh thu của kho:";
            label15.Click += label15_Click;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTongDoanhThu.Location = new Point(327, 724);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(100, 35);
            lblTongDoanhThu.TabIndex = 9;
            lblTongDoanhThu.Text = "label16";
            // 
            // cmbBoLocNhanVien
            // 
            cmbBoLocNhanVien.FormattingEnabled = true;
            cmbBoLocNhanVien.Location = new Point(188, 384);
            cmbBoLocNhanVien.Name = "cmbBoLocNhanVien";
            cmbBoLocNhanVien.Size = new Size(267, 28);
            cmbBoLocNhanVien.TabIndex = 10;
            cmbBoLocNhanVien.SelectedIndexChanged += cmbBoLocNhanVien_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(27, 385);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 11;
            label3.Text = "Bộ lọc nhân viên";
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(12, 461);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.Size = new Size(509, 202);
            dgvDoanhThu.TabIndex = 12;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 861);
            Controls.Add(dgvDoanhThu);
            Controls.Add(label3);
            Controls.Add(cmbBoLocNhanVien);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(label15);
            Controls.Add(dgvNhanVien);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ThongKe";
            Text = "ThongKe";
            Load += ThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Label label2;
        private Button btnThongKe;
        private GroupBox groupBox3;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label9;
        private Panel panel3;
        private Label label7;
        private Panel panel4;
        private Label label10;
        private DataGridView dgvNhanVien;
        private Label lblKhachHang;
        private Label lblTonKho;
        private Label lblTongPhieuNhap;
        private Label lblTongPhieuXuat;
        private Label label15;
        private Label lblTongDoanhThu;
        private ComboBox cmbBoLocNhanVien;
        private Label label3;
        private DataGridView dgvDoanhThu;
    }
}