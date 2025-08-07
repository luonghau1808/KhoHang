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
            btnLammoi = new Button();
            btnHuy = new Button();
            btnTao = new Button();
            btnThanhToan = new Button();
            panel2 = new Panel();
            label3 = new Label();
            txtTienkhach = new TextBox();
            lbNV = new Label();
            cbHTTT = new ComboBox();
            lbTienthua = new Label();
            label6 = new Label();
            label5 = new Label();
            lbTongtienhd = new Label();
            panel4 = new Panel();
            txtsdt = new TextBox();
            label2 = new Label();
            btnThemkh = new Button();
            txtTen = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnSua = new Button();
            label4 = new Label();
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
            panel3.Controls.Add(btnLammoi);
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnTao);
            panel3.Controls.Add(btnThanhToan);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 620);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 363);
            panel3.TabIndex = 11;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLammoi.Image = Properties.Resources.icons8_replace_301;
            btnLammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLammoi.Location = new Point(41, 263);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(419, 61);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Image = Properties.Resources.icons8_delete_document_30;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(292, 165);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(168, 70);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTao
            // 
            btnTao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTao.Image = Properties.Resources.icons8_create_order_30;
            btnTao.ImageAlign = ContentAlignment.MiddleLeft;
            btnTao.Location = new Point(41, 165);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(167, 70);
            btnTao.TabIndex = 1;
            btnTao.Text = "Tạo hóa đơn";
            btnTao.TextAlign = ContentAlignment.MiddleRight;
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI Semibold", 13.2F, FontStyle.Bold);
            btnThanhToan.Image = Properties.Resources.icons8_money_601;
            btnThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.Location = new Point(41, 39);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(424, 85);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán ";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTienkhach);
            panel2.Controls.Add(lbNV);
            panel2.Controls.Add(cbHTTT);
            panel2.Controls.Add(lbTienthua);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lbTongtienhd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 781);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 221);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "đ";
            // 
            // txtTienkhach
            // 
            txtTienkhach.BorderStyle = BorderStyle.FixedSingle;
            txtTienkhach.Location = new Point(288, 215);
            txtTienkhach.Name = "txtTienkhach";
            txtTienkhach.Size = new Size(177, 27);
            txtTienkhach.TabIndex = 7;
            txtTienkhach.TextAlign = HorizontalAlignment.Right;
            txtTienkhach.TextChanged += txtTienkhach_TextChanged;
            // 
            // lbNV
            // 
            lbNV.AutoSize = true;
            lbNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbNV.Location = new Point(64, 116);
            lbNV.Name = "lbNV";
            lbNV.Size = new Size(98, 23);
            lbNV.TabIndex = 6;
            lbNV.Text = "Nhân viên: ";
            // 
            // cbHTTT
            // 
            cbHTTT.FormattingEnabled = true;
            cbHTTT.Location = new Point(288, 158);
            cbHTTT.Name = "cbHTTT";
            cbHTTT.Size = new Size(172, 28);
            cbHTTT.TabIndex = 5;
            // 
            // lbTienthua
            // 
            lbTienthua.AutoSize = true;
            lbTienthua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbTienthua.Location = new Point(64, 274);
            lbTienthua.Name = "lbTienthua";
            lbTienthua.Size = new Size(87, 23);
            lbTienthua.TabIndex = 4;
            lbTienthua.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(64, 219);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 3;
            label6.Text = "Tiền khách đưa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(64, 166);
            label5.Name = "label5";
            label5.Size = new Size(182, 23);
            label5.TabIndex = 2;
            label5.Text = "Hình thức thanh toán ";
            // 
            // lbTongtienhd
            // 
            lbTongtienhd.AutoSize = true;
            lbTongtienhd.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongtienhd.Location = new Point(56, 43);
            lbTongtienhd.Name = "lbTongtienhd";
            lbTongtienhd.Size = new Size(190, 41);
            lbTongtienhd.TabIndex = 0;
            lbTongtienhd.Text = "Tổng tiền: 0 ";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtsdt);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnThemkh);
            panel4.Controls.Add(txtTen);
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
            txtsdt.Location = new Point(226, 87);
            txtsdt.Name = "txtsdt";
            txtsdt.ReadOnly = true;
            txtsdt.Size = new Size(203, 27);
            txtsdt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(67, 85);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại";
            // 
            // btnThemkh
            // 
            btnThemkh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemkh.Image = Properties.Resources.icons8_find_user_male_30;
            btnThemkh.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemkh.Location = new Point(280, 139);
            btnThemkh.Name = "btnThemkh";
            btnThemkh.Size = new Size(189, 43);
            btnThemkh.TabIndex = 3;
            btnThemkh.Text = "Chọn khách hàng";
            btnThemkh.TextAlign = ContentAlignment.MiddleRight;
            btnThemkh.UseVisualStyleBackColor = true;
            btnThemkh.Click += btnThemkh_Click;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(226, 30);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(203, 27);
            txtTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(56, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
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
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(dtgGioHang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1285, 568);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ hàng ";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(609, 355);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(254, 48);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa số lượng";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 466);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 32;
            label4.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(290, 466);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(371, 30);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.icons8_add_to_shopping_basket_301;
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
            btnXoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.icons8_delete_302;
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
            groupBox2.Location = new Point(0, 828);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1285, 223);
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
            dtgDanhSachSP.Size = new Size(1279, 194);
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
        private Button btnXoa;
        private TextBox textBox1;
        private Button btnThem;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Button btnSua;
        private TabControl tabControl1;
        private TabPage tabHoaDon;
        private Panel panel3;
        private Button btnLammoi;
        private Button btnHuy;
        private Button btnTao;
        private Button btnThanhToan;
        private Panel panel2;
        private Label label3;
        private TextBox txtTienkhach;
        private Label lbNV;
        private ComboBox cbHTTT;
        private Label lbTienthua;
        private Label label6;
        private Label label5;
        private Label lbTongtienhd;
        private Panel panel4;
        private TextBox txtsdt;
        private Label label2;
        private Button btnThemkh;
        private TextBox txtTen;
        private Label label1;
    }
}