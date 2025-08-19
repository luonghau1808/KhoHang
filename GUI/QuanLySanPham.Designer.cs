namespace DuAn1_Nhom4
{
    partial class QuanLySanPham
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
            tabControl1 = new TabControl();
            tabThongTin = new TabPage();
            groupBox2 = new GroupBox();
            dtgThongTinSP = new DataGridView();
            label8 = new Label();
            txtTim = new TextBox();
            groupBox1 = new GroupBox();
            btnLuuEditSP = new Button();
            btnHuyLuu = new Button();
            btnLuuAddSP = new Button();
            cbNcc = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            rbNgung = new RadioButton();
            rbConHang = new RadioButton();
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
            tabThuocTinh = new TabPage();
            panel2 = new Panel();
            dgvMs = new DataGridView();
            groupBox4 = new GroupBox();
            button1 = new Button();
            btnDeleteMs = new Button();
            btnEditMs = new Button();
            btnAddMs = new Button();
            txbMs = new TextBox();
            panel1 = new Panel();
            dgvKt = new DataGridView();
            groupBox3 = new GroupBox();
            button2 = new Button();
            btnDeleteKt = new Button();
            btnEditKt = new Button();
            btnAddKt = new Button();
            txbKt = new TextBox();
            tabControl1.SuspendLayout();
            tabThongTin.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTinSP).BeginInit();
            groupBox1.SuspendLayout();
            tabThuocTinh.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMs).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKt).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabThongTin);
            tabControl1.Controls.Add(tabThuocTinh);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1610, 1055);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabThongTin
            // 
            tabThongTin.Controls.Add(groupBox2);
            tabThongTin.Controls.Add(groupBox1);
            tabThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabThongTin.Location = new Point(4, 32);
            tabThongTin.Name = "tabThongTin";
            tabThongTin.Padding = new Padding(3);
            tabThongTin.Size = new Size(1602, 1019);
            tabThongTin.TabIndex = 0;
            tabThongTin.Text = "Thông tin sản phẩm";
            tabThongTin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgThongTinSP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTim);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 645);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1596, 371);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm ";
            // 
            // dtgThongTinSP
            // 
            dtgThongTinSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgThongTinSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongTinSP.Dock = DockStyle.Bottom;
            dtgThongTinSP.Location = new Point(3, 153);
            dtgThongTinSP.MultiSelect = false;
            dtgThongTinSP.Name = "dtgThongTinSP";
            dtgThongTinSP.ReadOnly = true;
            dtgThongTinSP.RowHeadersWidth = 51;
            dtgThongTinSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgThongTinSP.Size = new Size(1590, 215);
            dtgThongTinSP.TabIndex = 12;
            dtgThongTinSP.CellClick += dtgThongTinSP_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(625, 39);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 11;
            label8.Text = "Tìm kiếm ";
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Font = new Font("Segoe UI", 12F);
            txtTim.Location = new Point(757, 36);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(328, 34);
            txtTim.TabIndex = 10;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuuEditSP);
            groupBox1.Controls.Add(btnHuyLuu);
            groupBox1.Controls.Add(btnLuuAddSP);
            groupBox1.Controls.Add(cbNcc);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rbNgung);
            groupBox1.Controls.Add(rbConHang);
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
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1596, 642);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sản phẩm";
            // 
            // btnLuuEditSP
            // 
            btnLuuEditSP.BackColor = Color.Khaki;
            btnLuuEditSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuEditSP.Image = Properties.Resources.icons8_edit_302;
            btnLuuEditSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuEditSP.Location = new Point(591, 490);
            btnLuuEditSP.Name = "btnLuuEditSP";
            btnLuuEditSP.Size = new Size(200, 48);
            btnLuuEditSP.TabIndex = 36;
            btnLuuEditSP.Text = "Lưu";
            btnLuuEditSP.UseVisualStyleBackColor = false;
            btnLuuEditSP.Click += btnLuuEditSP_Click;
            // 
            // btnHuyLuu
            // 
            btnHuyLuu.BackColor = Color.LightCoral;
            btnHuyLuu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyLuu.ForeColor = SystemColors.ButtonHighlight;
            btnHuyLuu.Image = Properties.Resources.icons8_delete_303;
            btnHuyLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyLuu.Location = new Point(885, 490);
            btnHuyLuu.Name = "btnHuyLuu";
            btnHuyLuu.Size = new Size(200, 48);
            btnHuyLuu.TabIndex = 35;
            btnHuyLuu.Text = "Hủy";
            btnHuyLuu.UseVisualStyleBackColor = false;
            btnHuyLuu.Click += btnHuyLuu_Click;
            // 
            // btnLuuAddSP
            // 
            btnLuuAddSP.BackColor = Color.LimeGreen;
            btnLuuAddSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuAddSP.ForeColor = SystemColors.ButtonHighlight;
            btnLuuAddSP.Image = Properties.Resources.icons8_add_30;
            btnLuuAddSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuAddSP.Location = new Point(591, 490);
            btnLuuAddSP.Name = "btnLuuAddSP";
            btnLuuAddSP.Size = new Size(200, 48);
            btnLuuAddSP.TabIndex = 34;
            btnLuuAddSP.Text = "Lưu";
            btnLuuAddSP.UseVisualStyleBackColor = false;
            btnLuuAddSP.Click += btnLuuAddSP_Click;
            // 
            // cbNcc
            // 
            cbNcc.Font = new Font("Segoe UI", 10.2F);
            cbNcc.FormattingEnabled = true;
            cbNcc.Location = new Point(1084, 356);
            cbNcc.Name = "cbNcc";
            cbNcc.Size = new Size(397, 31);
            cbNcc.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(898, 356);
            label11.Name = "label11";
            label11.Size = new Size(117, 23);
            label11.TabIndex = 32;
            label11.Text = "Nhà cung cấp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(93, 444);
            label10.Name = "label10";
            label10.Size = new Size(87, 23);
            label10.TabIndex = 31;
            label10.Text = "Trạng thái";
            // 
            // rbNgung
            // 
            rbNgung.AutoSize = true;
            rbNgung.Location = new Point(493, 444);
            rbNgung.Name = "rbNgung";
            rbNgung.Size = new Size(177, 27);
            rbNgung.TabIndex = 30;
            rbNgung.TabStop = true;
            rbNgung.Text = "Ngừng kinh doanh";
            rbNgung.UseVisualStyleBackColor = true;
            // 
            // rbConHang
            // 
            rbConHang.AutoSize = true;
            rbConHang.Location = new Point(247, 444);
            rbConHang.Name = "rbConHang";
            rbConHang.Size = new Size(106, 27);
            rbConHang.TabIndex = 29;
            rbConHang.TabStop = true;
            rbConHang.Text = "Còn hàng";
            rbConHang.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.PaleTurquoise;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(703, 544);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(200, 48);
            btnLamMoi.TabIndex = 28;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Image = Properties.Resources.icons8_delete_303;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(482, 544);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(200, 48);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Khaki;
            btnSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Image = Properties.Resources.icons8_edit_302;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(264, 544);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(200, 48);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa sản phẩm ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(49, 544);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(200, 48);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cbKichThuoc
            // 
            cbKichThuoc.Font = new Font("Segoe UI", 10.2F);
            cbKichThuoc.FormattingEnabled = true;
            cbKichThuoc.Location = new Point(1084, 263);
            cbKichThuoc.Name = "cbKichThuoc";
            cbKichThuoc.Size = new Size(397, 31);
            cbKichThuoc.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(898, 266);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 12;
            label7.Text = "Kích thước ";
            // 
            // cbMau
            // 
            cbMau.Font = new Font("Segoe UI", 10.2F);
            cbMau.FormattingEnabled = true;
            cbMau.Location = new Point(1084, 173);
            cbMau.Name = "cbMau";
            cbMau.Size = new Size(397, 31);
            cbMau.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(898, 181);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 10;
            label6.Text = "Màu sắc ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(96, 364);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 9;
            label5.Text = "Số lượng ";
            // 
            // cbTH
            // 
            cbTH.Font = new Font("Segoe UI", 10.2F);
            cbTH.FormattingEnabled = true;
            cbTH.Location = new Point(1084, 84);
            cbTH.Name = "cbTH";
            cbTH.Size = new Size(397, 31);
            cbTH.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 10.2F);
            txtSoLuong.Location = new Point(247, 358);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ReadOnly = true;
            txtSoLuong.Size = new Size(423, 30);
            txtSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(96, 272);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Font = new Font("Segoe UI", 10.2F);
            txtDonGia.Location = new Point(247, 264);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(423, 30);
            txtDonGia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(898, 84);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 4;
            label3.Text = "Tên thương hiệu ";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Font = new Font("Segoe UI", 10.2F);
            txtTen.Location = new Point(247, 178);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(423, 30);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(96, 181);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm ";
            // 
            // txtMa
            // 
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.Font = new Font("Segoe UI", 10.2F);
            txtMa.Location = new Point(247, 83);
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(423, 30);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 84);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // tabThuocTinh
            // 
            tabThuocTinh.Controls.Add(panel2);
            tabThuocTinh.Controls.Add(panel1);
            tabThuocTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabThuocTinh.Location = new Point(4, 32);
            tabThuocTinh.Name = "tabThuocTinh";
            tabThuocTinh.Padding = new Padding(3);
            tabThuocTinh.Size = new Size(1602, 1019);
            tabThuocTinh.TabIndex = 1;
            tabThuocTinh.Text = "Màu & Kích thước";
            tabThuocTinh.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMs);
            panel2.Controls.Add(groupBox4);
            panel2.Location = new Point(-2, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(1594, 262);
            panel2.TabIndex = 2;
            // 
            // dgvMs
            // 
            dgvMs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMs.Location = new Point(698, 3);
            dgvMs.MultiSelect = false;
            dgvMs.Name = "dgvMs";
            dgvMs.ReadOnly = true;
            dgvMs.RowHeadersWidth = 51;
            dgvMs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMs.Size = new Size(890, 256);
            dgvMs.TabIndex = 1;
            dgvMs.CellClick += dgvMs_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(btnDeleteMs);
            groupBox4.Controls.Add(btnEditMs);
            groupBox4.Controls.Add(btnAddMs);
            groupBox4.Controls.Add(txbMs);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(6, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(686, 256);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Màu Sắc";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Image = Properties.Resources.icons8_clean_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(479, 54);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 4;
            button1.Text = "Làm mới";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDeleteMs
            // 
            btnDeleteMs.BackColor = Color.LightCoral;
            btnDeleteMs.Image = Properties.Resources.icons8_delete_302;
            btnDeleteMs.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteMs.Location = new Point(391, 162);
            btnDeleteMs.Name = "btnDeleteMs";
            btnDeleteMs.Size = new Size(142, 35);
            btnDeleteMs.TabIndex = 3;
            btnDeleteMs.Text = "Xóa";
            btnDeleteMs.UseVisualStyleBackColor = false;
            btnDeleteMs.Click += btnDeleteMs_Click;
            // 
            // btnEditMs
            // 
            btnEditMs.BackColor = Color.Khaki;
            btnEditMs.Image = Properties.Resources.icons8_edit_302;
            btnEditMs.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditMs.Location = new Point(234, 162);
            btnEditMs.Name = "btnEditMs";
            btnEditMs.Size = new Size(142, 35);
            btnEditMs.TabIndex = 2;
            btnEditMs.Text = "Sửa";
            btnEditMs.UseVisualStyleBackColor = false;
            btnEditMs.Click += btnEditMs_Click;
            // 
            // btnAddMs
            // 
            btnAddMs.BackColor = Color.LimeGreen;
            btnAddMs.ForeColor = SystemColors.ButtonHighlight;
            btnAddMs.Image = Properties.Resources.icons8_add_303;
            btnAddMs.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMs.Location = new Point(75, 162);
            btnAddMs.Name = "btnAddMs";
            btnAddMs.Size = new Size(142, 35);
            btnAddMs.TabIndex = 1;
            btnAddMs.Text = "Thêm";
            btnAddMs.UseVisualStyleBackColor = false;
            btnAddMs.Click += btnAddMs_Click;
            // 
            // txbMs
            // 
            txbMs.BorderStyle = BorderStyle.FixedSingle;
            txbMs.Location = new Point(110, 58);
            txbMs.Name = "txbMs";
            txbMs.Size = new Size(287, 30);
            txbMs.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvKt);
            panel1.Controls.Add(groupBox3);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 262);
            panel1.TabIndex = 0;
            // 
            // dgvKt
            // 
            dgvKt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKt.Location = new Point(698, 3);
            dgvKt.MultiSelect = false;
            dgvKt.Name = "dgvKt";
            dgvKt.ReadOnly = true;
            dgvKt.RowHeadersWidth = 51;
            dgvKt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKt.Size = new Size(890, 256);
            dgvKt.TabIndex = 1;
            dgvKt.CellClick += dgvKt_CellClick;
            dgvKt.CellContentClick += dgvKt_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(btnDeleteKt);
            groupBox3.Controls.Add(btnEditKt);
            groupBox3.Controls.Add(btnAddKt);
            groupBox3.Controls.Add(txbKt);
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(6, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(686, 256);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kích thước";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Image = Properties.Resources.icons8_clean_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(477, 58);
            button2.Name = "button2";
            button2.Size = new Size(128, 35);
            button2.TabIndex = 5;
            button2.Text = "Làm mới";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDeleteKt
            // 
            btnDeleteKt.BackColor = Color.LightCoral;
            btnDeleteKt.Image = Properties.Resources.icons8_delete_303;
            btnDeleteKt.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteKt.Location = new Point(383, 166);
            btnDeleteKt.Name = "btnDeleteKt";
            btnDeleteKt.Size = new Size(142, 35);
            btnDeleteKt.TabIndex = 3;
            btnDeleteKt.Text = "Xóa";
            btnDeleteKt.UseVisualStyleBackColor = false;
            btnDeleteKt.Click += btnDeleteKt_Click;
            // 
            // btnEditKt
            // 
            btnEditKt.BackColor = Color.Khaki;
            btnEditKt.Image = Properties.Resources.icons8_edit_301;
            btnEditKt.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditKt.Location = new Point(226, 166);
            btnEditKt.Name = "btnEditKt";
            btnEditKt.Size = new Size(142, 35);
            btnEditKt.TabIndex = 2;
            btnEditKt.Text = "Sửa ";
            btnEditKt.UseVisualStyleBackColor = false;
            btnEditKt.Click += btnEditKt_Click;
            // 
            // btnAddKt
            // 
            btnAddKt.BackColor = Color.LimeGreen;
            btnAddKt.ForeColor = SystemColors.ButtonHighlight;
            btnAddKt.Image = Properties.Resources.icons8_add_302;
            btnAddKt.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddKt.Location = new Point(69, 166);
            btnAddKt.Name = "btnAddKt";
            btnAddKt.Size = new Size(142, 35);
            btnAddKt.TabIndex = 1;
            btnAddKt.Text = "Thêm";
            btnAddKt.UseVisualStyleBackColor = false;
            btnAddKt.Click += btnAddKt_Click;
            // 
            // txbKt
            // 
            txbKt.BorderStyle = BorderStyle.FixedSingle;
            txbKt.Location = new Point(110, 58);
            txbKt.Name = "txbKt";
            txbKt.Size = new Size(287, 30);
            txbKt.TabIndex = 0;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 1055);
            Controls.Add(tabControl1);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            Load += QuanLySanPham_Load;
            tabControl1.ResumeLayout(false);
            tabThongTin.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTinSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabThuocTinh.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMs).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKt).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabThongTin;
        private TabPage tabThuocTinh;
        private GroupBox groupBox2;
        private DataGridView dtgThongTinSP;
        private Label label8;
        private TextBox txtTim;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cbKichThuoc;
        private Label label7;
        private ComboBox cbMau;
        private Label label6;
        private Label label5;
        private ComboBox cbTH;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtDonGia;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private ComboBox cbNcc;
        private Label label11;
        private Label label10;
        private RadioButton rbNgung;
        private RadioButton rbConHang;
        private Panel panel1;
        private GroupBox groupBox3;
        private Panel panel2;
        private DataGridView dgvMs;
        private GroupBox groupBox4;
        private Button btnDeleteMs;
        private Button btnEditMs;
        private Button btnAddMs;
        private TextBox txbMs;
        private DataGridView dgvKt;
        private Button btnDeleteKt;
        private Button btnEditKt;
        private Button btnAddKt;
        private TextBox txbKt;
        private Button button1;
        private Button button2;
        private Button btnLuuEditSP;
        private Button btnHuyLuu;
        private Button btnLuuAddSP;
    }
}