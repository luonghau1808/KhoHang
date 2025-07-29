namespace DuAn1_Nhom4.GUI
{
    partial class PhieuXuatF
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox5 = new GroupBox();
            tabControl1 = new TabControl();
            tabHoaDon = new TabPage();
            panel3 = new Panel();
            btnHuy = new Button();
            btnTao = new Button();
            btnThanhToan = new Button();
            panel2 = new Panel();
            cbHTTT = new ComboBox();
            txtTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbTongtienhd = new Label();
            panel4 = new Panel();
            txtsdt = new TextBox();
            label2 = new Label();
            btnThemkh = new Button();
            txtTendh = new TextBox();
            label1 = new Label();
            tabDatHang = new TabPage();
            panel6 = new Panel();
            txtSdtdh = new TextBox();
            txtTenKH = new TextBox();
            label14 = new Label();
            label15 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            btnHoanTra = new Button();
            btnTrangThai = new Button();
            btnGiaoHang = new Button();
            btnTaoHoaDon = new Button();
            label16 = new Label();
            label12 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            dtgGioHang = new DataGridView();
            groupBox2 = new GroupBox();
            dtgDanhSachSP = new DataGridView();
            groupBox1 = new GroupBox();
            dtgDanhSachHD = new DataGridView();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox5.SuspendLayout();
            tabControl1.SuspendLayout();
            tabHoaDon.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tabDatHang.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgGioHang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachSP).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tabControl1);
            groupBox5.Dock = DockStyle.Right;
            groupBox5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(1285, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(515, 1051);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tạo hóa đơn";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHoaDon);
            tabControl1.Controls.Add(tabDatHang);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(509, 1022);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabHoaDon
            // 
            tabHoaDon.Controls.Add(panel3);
            tabHoaDon.Controls.Add(panel2);
            tabHoaDon.Controls.Add(panel4);
            tabHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabHoaDon.Location = new Point(4, 32);
            tabHoaDon.Name = "tabHoaDon";
            tabHoaDon.Padding = new Padding(3);
            tabHoaDon.Size = new Size(501, 986);
            tabHoaDon.TabIndex = 0;
            tabHoaDon.Text = "Hóa đơn";
            tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnTao);
            panel3.Controls.Add(btnThanhToan);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 641);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 342);
            panel3.TabIndex = 11;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(283, 129);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(167, 63);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            btnTao.Image = Properties.Resources.icons8_add_301;
            btnTao.ImageAlign = ContentAlignment.MiddleLeft;
            btnTao.Location = new Point(41, 129);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(173, 63);
            btnTao.TabIndex = 1;
            btnTao.Text = "Tạo hóa đơn";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Image = Properties.Resources.icons8_dollar_bag_30;
            btnThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.Location = new Point(41, 27);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(409, 61);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán ";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbHTTT);
            panel2.Controls.Add(txtTien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lbTongtienhd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 781);
            panel2.TabIndex = 10;
            // 
            // cbHTTT
            // 
            cbHTTT.FormattingEnabled = true;
            cbHTTT.Location = new Point(288, 158);
            cbHTTT.Name = "cbHTTT";
            cbHTTT.Size = new Size(172, 28);
            cbHTTT.TabIndex = 5;
            // 
            // txtTien
            // 
            txtTien.BorderStyle = BorderStyle.FixedSingle;
            txtTien.Location = new Point(288, 215);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(172, 27);
            txtTien.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(64, 274);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 4;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(64, 219);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 3;
            label6.Text = "Tiền khách đưa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(64, 166);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 2;
            label5.Text = "Hình thức thanh toán ";
            // 
            // lbTongtienhd
            // 
            lbTongtienhd.AutoSize = true;
            lbTongtienhd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongtienhd.Location = new Point(64, 63);
            lbTongtienhd.Name = "lbTongtienhd";
            lbTongtienhd.Size = new Size(168, 41);
            lbTongtienhd.TabIndex = 0;
            lbTongtienhd.Text = "Tổng tiền : ";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtsdt);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnThemkh);
            panel4.Controls.Add(txtTendh);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(495, 199);
            panel4.TabIndex = 9;
            // 
            // txtsdt
            // 
            txtsdt.BorderStyle = BorderStyle.FixedSingle;
            txtsdt.Location = new Point(224, 86);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(203, 27);
            txtsdt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(67, 85);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại";
            // 
            // btnThemkh
            // 
            btnThemkh.Location = new Point(288, 130);
            btnThemkh.Name = "btnThemkh";
            btnThemkh.Size = new Size(181, 43);
            btnThemkh.TabIndex = 3;
            btnThemkh.Text = "Chọn khách hàng";
            btnThemkh.UseVisualStyleBackColor = true;
            // 
            // txtTendh
            // 
            txtTendh.BorderStyle = BorderStyle.FixedSingle;
            txtTendh.Location = new Point(226, 30);
            txtTendh.Name = "txtTendh";
            txtTendh.Size = new Size(203, 27);
            txtTendh.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(69, 29);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // tabDatHang
            // 
            tabDatHang.Controls.Add(panel6);
            tabDatHang.Controls.Add(panel7);
            tabDatHang.Location = new Point(4, 32);
            tabDatHang.Name = "tabDatHang";
            tabDatHang.Padding = new Padding(3);
            tabDatHang.Size = new Size(501, 986);
            tabDatHang.TabIndex = 1;
            tabDatHang.Text = "Đặt hàng";
            tabDatHang.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSdtdh);
            panel6.Controls.Add(txtTenKH);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(495, 119);
            panel6.TabIndex = 9;
            // 
            // txtSdtdh
            // 
            txtSdtdh.BorderStyle = BorderStyle.FixedSingle;
            txtSdtdh.Font = new Font("Segoe UI", 10.2F);
            txtSdtdh.Location = new Point(213, 87);
            txtSdtdh.Name = "txtSdtdh";
            txtSdtdh.Size = new Size(172, 30);
            txtSdtdh.TabIndex = 3;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Font = new Font("Segoe UI", 10.2F);
            txtTenKH.Location = new Point(213, 23);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(172, 30);
            txtTenKH.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F);
            label14.Location = new Point(56, 86);
            label14.Name = "label14";
            label14.Size = new Size(120, 23);
            label14.TabIndex = 1;
            label14.Text = "Số điện thoại: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F);
            label15.Location = new Point(56, 22);
            label15.Name = "label15";
            label15.Size = new Size(134, 23);
            label15.TabIndex = 0;
            label15.Text = "Tên khách hàng:";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(richTextBox1);
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label11);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(495, 980);
            panel7.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHoanTra);
            panel5.Controls.Add(btnTrangThai);
            panel5.Controls.Add(btnGiaoHang);
            panel5.Controls.Add(btnTaoHoaDon);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 697);
            panel5.Name = "panel5";
            panel5.Size = new Size(495, 283);
            panel5.TabIndex = 11;
            // 
            // btnHoanTra
            // 
            btnHoanTra.Image = Properties.Resources.icons8_delete_301;
            btnHoanTra.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoanTra.Location = new Point(56, 191);
            btnHoanTra.Name = "btnHoanTra";
            btnHoanTra.Size = new Size(389, 61);
            btnHoanTra.TabIndex = 3;
            btnHoanTra.Text = "Hoàn trả";
            btnHoanTra.UseVisualStyleBackColor = true;
            // 
            // btnTrangThai
            // 
            btnTrangThai.Image = Properties.Resources.icons8_shopify_301;
            btnTrangThai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangThai.Location = new Point(278, 117);
            btnTrangThai.Name = "btnTrangThai";
            btnTrangThai.Size = new Size(167, 52);
            btnTrangThai.TabIndex = 2;
            btnTrangThai.Text = "Đã giao";
            btnTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnGiaoHang
            // 
            btnGiaoHang.Image = Properties.Resources.icons8_delivery_time_301;
            btnGiaoHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiaoHang.Location = new Point(56, 117);
            btnGiaoHang.Name = "btnGiaoHang";
            btnGiaoHang.Size = new Size(178, 52);
            btnGiaoHang.TabIndex = 1;
            btnGiaoHang.Text = "Giao hàng";
            btnGiaoHang.UseVisualStyleBackColor = true;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Image = Properties.Resources.icons8_dollar_bag_30;
            btnTaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.Location = new Point(54, 27);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(396, 61);
            btnTaoHoaDon.TabIndex = 0;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F);
            label16.Location = new Point(56, 146);
            label16.Name = "label16";
            label16.Size = new Size(124, 23);
            label16.TabIndex = 10;
            label16.Text = "Khách cần trả: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(56, 377);
            label12.Name = "label12";
            label12.Size = new Size(73, 23);
            label12.TabIndex = 9;
            label12.Text = "Ghi chú:";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10.2F);
            richTextBox1.Location = new Point(56, 423);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(394, 77);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(278, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 31);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(278, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 30);
            textBox2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(54, 325);
            label8.Name = "label8";
            label8.Size = new Size(86, 23);
            label8.TabIndex = 4;
            label8.Text = "Tiền thừa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(56, 266);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 3;
            label9.Text = "Tiền khách đưa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(54, 201);
            label10.Name = "label10";
            label10.Size = new Size(180, 23);
            label10.TabIndex = 2;
            label10.Text = "Hình thức thanh toán ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.Location = new Point(56, 91);
            label13.Name = "label13";
            label13.Size = new Size(87, 23);
            label13.TabIndex = 1;
            label13.Text = "Tiền ship: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(56, 28);
            label11.Name = "label11";
            label11.Size = new Size(131, 23);
            label11.TabIndex = 0;
            label11.Text = "Tổng tiền hàng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 1051);
            panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(dtgGioHang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1285, 545);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ hàng ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(656, 487);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên sản phẩm cần tìm....";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(371, 41);
            textBox1.TabIndex = 31;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(314, 355);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(240, 48);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm vào giỏ hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(3, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(254, 48);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgGioHang
            // 
            dtgGioHang.AllowUserToAddRows = false;
            dtgGioHang.AllowUserToDeleteRows = false;
            dtgGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGioHang.Dock = DockStyle.Top;
            dtgGioHang.Location = new Point(3, 26);
            dtgGioHang.MultiSelect = false;
            dtgGioHang.Name = "dtgGioHang";
            dtgGioHang.ReadOnly = true;
            dtgGioHang.RowHeadersWidth = 51;
            dtgGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGioHang.Size = new Size(1279, 302);
            dtgGioHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgDanhSachSP);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 805);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1285, 246);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm ";
            // 
            // dtgDanhSachSP
            // 
            dtgDanhSachSP.AllowUserToAddRows = false;
            dtgDanhSachSP.AllowUserToDeleteRows = false;
            dtgDanhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachSP.Dock = DockStyle.Fill;
            dtgDanhSachSP.Location = new Point(3, 26);
            dtgDanhSachSP.MultiSelect = false;
            dtgDanhSachSP.Name = "dtgDanhSachSP";
            dtgDanhSachSP.ReadOnly = true;
            dtgDanhSachSP.RowHeadersWidth = 51;
            dtgDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachSP.Size = new Size(1279, 217);
            dtgDanhSachSP.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgDanhSachHD);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1285, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dtgDanhSachHD
            // 
            dtgDanhSachHD.AllowUserToAddRows = false;
            dtgDanhSachHD.AllowUserToDeleteRows = false;
            dtgDanhSachHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachHD.Dock = DockStyle.Fill;
            dtgDanhSachHD.Location = new Point(3, 26);
            dtgDanhSachHD.MultiSelect = false;
            dtgDanhSachHD.Name = "dtgDanhSachHD";
            dtgDanhSachHD.ReadOnly = true;
            dtgDanhSachHD.RowHeadersWidth = 51;
            dtgDanhSachHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachHD.Size = new Size(1279, 231);
            dtgDanhSachHD.TabIndex = 0;
            dtgDanhSachHD.CellClick += dtgDanhSachHD_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PhieuXuatF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1051);
            Controls.Add(panel1);
            Controls.Add(groupBox5);
            Name = "PhieuXuatF";
            Text = "HoaDon";
            Load += HoaDon_Load;
            groupBox5.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabHoaDon.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabDatHang.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgGioHang).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachSP).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHD).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox5;
        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private DataGridView dtgGioHang;
        private DataGridView dtgDanhSachSP;
        private DataGridView dtgDanhSachHD;
        private TabControl tabControl1;
        private TabPage tabHoaDon;
        private TabPage tabDatHang;
        private Button btnXoa;
        private TextBox textBox1;
        private Button btnThem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel3;
        private Button btnHuy;
        private Button btnTao;
        private Button btnThanhToan;
        private Panel panel2;
        private ComboBox cbHTTT;
        private TextBox txtTien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbTongtienhd;
        private Panel panel4;
        private TextBox txtTendh;
        private Label label1;
        private Panel panel6;
        private TextBox txtSdtdh;
        private TextBox txtTenKH;
        private Label label14;
        private Label label15;
        private Panel panel7;
        private Panel panel5;
        private Button btnHoanTra;
        private Button btnTrangThai;
        private Button btnGiaoHang;
        private Button btnTaoHoaDon;
        private Label label16;
        private Label label12;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label11;
        private Button btnThemkh;
        private TextBox txtsdt;
        private Label label2;
    }
}