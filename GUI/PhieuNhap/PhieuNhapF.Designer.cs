﻿namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    partial class PhieuNhapF
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
            lbTongTien = new Label();
            btnThanhToan = new Button();
            groupBox2 = new GroupBox();
            btnHuyPhieu = new Button();
            cbTrangThai = new ComboBox();
            label2 = new Label();
            btnThemPhieuNhap = new Button();
            dgvDanhSachPhieuNhap = new DataGridView();
            groupBox3 = new GroupBox();
            btnXoaSanPham = new Button();
            btnThayDoiSoLuong = new Button();
            btnThem = new Button();
            dgvGioHang = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhap).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lbTongTien.Location = new Point(12, 911);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(150, 41);
            lbTongTien.TabIndex = 5;
            lbTongTien.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Right;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Image = Properties.Resources.icons8_money_60;
            btnThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.Location = new Point(889, 902);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(523, 73);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh toán ";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuyPhieu);
            groupBox2.Controls.Add(cbTrangThai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnThemPhieuNhap);
            groupBox2.Controls.Add(dgvDanhSachPhieuNhap);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1502, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // btnHuyPhieu
            // 
            btnHuyPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuyPhieu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyPhieu.Image = Properties.Resources.icons8_delete_302;
            btnHuyPhieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyPhieu.Location = new Point(1253, 48);
            btnHuyPhieu.Name = "btnHuyPhieu";
            btnHuyPhieu.Size = new Size(237, 43);
            btnHuyPhieu.TabIndex = 37;
            btnHuyPhieu.Text = "Hủy phiếu nhập";
            btnHuyPhieu.UseVisualStyleBackColor = true;
            btnHuyPhieu.Click += btnHuyPhieu_Click;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(232, 50);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(276, 31);
            cbTrangThai.TabIndex = 36;
            cbTrangThai.SelectedIndexChanged += cbTrangThai_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 58);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 35;
            label2.Text = "Trạng thái thanh toán";
            // 
            // btnThemPhieuNhap
            // 
            btnThemPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemPhieuNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemPhieuNhap.Image = Properties.Resources.icons8_create_document_30;
            btnThemPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemPhieuNhap.Location = new Point(978, 48);
            btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            btnThemPhieuNhap.Size = new Size(238, 43);
            btnThemPhieuNhap.TabIndex = 34;
            btnThemPhieuNhap.Text = "Thêm phiếu nhập";
            btnThemPhieuNhap.UseVisualStyleBackColor = true;
            btnThemPhieuNhap.Click += btnThemPhieuNhap_Click;
            // 
            // dgvDanhSachPhieuNhap
            // 
            dgvDanhSachPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieuNhap.Dock = DockStyle.Bottom;
            dgvDanhSachPhieuNhap.Location = new Point(3, 113);
            dgvDanhSachPhieuNhap.MultiSelect = false;
            dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap";
            dgvDanhSachPhieuNhap.ReadOnly = true;
            dgvDanhSachPhieuNhap.RowHeadersWidth = 51;
            dgvDanhSachPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuNhap.Size = new Size(1496, 342);
            dgvDanhSachPhieuNhap.TabIndex = 0;
            dgvDanhSachPhieuNhap.CellClick += dgvDanhSachPhieuNhap_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaSanPham);
            groupBox3.Controls.Add(btnThayDoiSoLuong);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(dgvGioHang);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 458);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1502, 420);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết phiếu nhập";
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.Anchor = AnchorStyles.Right;
            btnXoaSanPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaSanPham.Image = Properties.Resources.icons8_add_to_shopping_basket_30;
            btnXoaSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaSanPham.Location = new Point(940, 63);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(322, 47);
            btnXoaSanPham.TabIndex = 35;
            btnXoaSanPham.Text = "Xóa sản phẩm khỏi chi tiết phiếu";
            btnXoaSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnXoaSanPham.UseVisualStyleBackColor = true;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // btnThayDoiSoLuong
            // 
            btnThayDoiSoLuong.Anchor = AnchorStyles.Right;
            btnThayDoiSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThayDoiSoLuong.Image = Properties.Resources.icons8_edit_302;
            btnThayDoiSoLuong.ImageAlign = ContentAlignment.MiddleLeft;
            btnThayDoiSoLuong.Location = new Point(638, 63);
            btnThayDoiSoLuong.Name = "btnThayDoiSoLuong";
            btnThayDoiSoLuong.Size = new Size(283, 47);
            btnThayDoiSoLuong.TabIndex = 34;
            btnThayDoiSoLuong.Text = "Thay đổi số lượng sản phẩm";
            btnThayDoiSoLuong.TextAlign = ContentAlignment.MiddleRight;
            btnThayDoiSoLuong.UseVisualStyleBackColor = true;
            btnThayDoiSoLuong.Click += btnThayDoiSoLuong_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Right;
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Image = Properties.Resources.icons8_add_to_shopping_basket_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(293, 63);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(322, 47);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm sản phẩm vào chi tiết phiếu";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvGioHang
            // 
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Bottom;
            dgvGioHang.Location = new Point(3, 142);
            dgvGioHang.MultiSelect = false;
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.ReadOnly = true;
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(1496, 275);
            dgvGioHang.TabIndex = 1;
            dgvGioHang.CellClick += dgvGioHang_CellClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // PhieuNhapF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 1003);
            Controls.Add(groupBox3);
            Controls.Add(btnThanhToan);
            Controls.Add(groupBox2);
            Controls.Add(lbTongTien);
            Name = "PhieuNhapF";
            Text = "Phiếu nhập";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhap).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvDanhSachPhieuNhap;
        private GroupBox groupBox3;
        private DataGridView dgvGioHang;
        private Button btnThem;
        private Button btnThanhToan;
        private Label lbTongTien;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Button btnThemPhieuNhap;
        private ComboBox cbTrangThai;
        private Label label2;
        private Button btnHuyPhieu;
        private Button btnXoaSanPham;
        private Button btnThayDoiSoLuong;
    }
}