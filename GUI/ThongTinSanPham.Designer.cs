namespace DuAn1_Nhom4.GUI
{
    partial class ThongTinSanPham
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
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cbKichThuoc = new ComboBox();
            label7 = new Label();
            cbMau = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cbTH = new ComboBox();
            txtSoLuong = new TextBox();
            label4 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgThongTinSP = new DataGridView();
            label8 = new Label();
            txtTim = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTinSP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cbKichThuoc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbMau);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbTH);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2000008F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1505, 642);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(1309, 497);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(263, 48);
            btnLamMoi.TabIndex = 28;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(886, 497);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(263, 48);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Image = Properties.Resources.icons8_change_24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(470, 497);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(263, 48);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa sản phẩm ";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(54, 497);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(263, 48);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cbKichThuoc
            // 
            cbKichThuoc.Font = new Font("Segoe UI", 10.2F);
            cbKichThuoc.FormattingEnabled = true;
            cbKichThuoc.Location = new Point(1084, 281);
            cbKichThuoc.Name = "cbKichThuoc";
            cbKichThuoc.Size = new Size(397, 31);
            cbKichThuoc.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(898, 284);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 12;
            label7.Text = "Kích thước ";
            // 
            // cbMau
            // 
            cbMau.Font = new Font("Segoe UI", 10.2F);
            cbMau.FormattingEnabled = true;
            cbMau.Location = new Point(1084, 192);
            cbMau.Name = "cbMau";
            cbMau.Size = new Size(397, 31);
            cbMau.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(898, 200);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 10;
            label6.Text = "Màu sắc ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(93, 377);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 9;
            label5.Text = "Số lượng ";
            // 
            // cbTH
            // 
            cbTH.Font = new Font("Segoe UI", 10.2F);
            cbTH.FormattingEnabled = true;
            cbTH.Location = new Point(1084, 102);
            cbTH.Name = "cbTH";
            cbTH.Size = new Size(397, 31);
            cbTH.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 10.2F);
            txtSoLuong.Location = new Point(244, 371);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(423, 30);
            txtSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(93, 285);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Font = new Font("Segoe UI", 10.2F);
            txtDonGia.Location = new Point(244, 277);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(423, 30);
            txtDonGia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(898, 102);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 4;
            label3.Text = "Tên thương hiệu ";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Font = new Font("Segoe UI", 10.2F);
            txtTen.Location = new Point(244, 191);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(423, 30);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(93, 194);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm ";
            // 
            // txtMa
            // 
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.Font = new Font("Segoe UI", 10.2F);
            txtMa.Location = new Point(244, 96);
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(423, 30);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(93, 97);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgThongTinSP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTim);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2000008F);
            groupBox2.Location = new Point(0, 642);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1505, 413);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm ";
            // 
            // dtgThongTinSP
            // 
            dtgThongTinSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongTinSP.Dock = DockStyle.Bottom;
            dtgThongTinSP.Location = new Point(3, 55);
            dtgThongTinSP.Name = "dtgThongTinSP";
            dtgThongTinSP.RowHeadersWidth = 51;
            dtgThongTinSP.Size = new Size(1499, 355);
            dtgThongTinSP.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(625, 39);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 11;
            label8.Text = "Tìm kiếm ";
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Segoe UI", 12F);
            txtTim.Location = new Point(757, 36);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(328, 34);
            txtTim.TabIndex = 10;
            // 
            // ThongTinSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 1055);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ThongTinSanPham";
            Text = "ThongTinSanPham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTinSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbTH;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtDonGia;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private ComboBox cbKichThuoc;
        private Label label7;
        private ComboBox cbMau;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private DataGridView dtgThongTinSP;
        private Label label8;
        private TextBox txtTim;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}
