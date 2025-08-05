namespace DuAn1_Nhom4.GUI
{
    partial class QuanLyNhanVien
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
            tabNV = new TabPage();
            groupBox3 = new GroupBox();
            txbTim = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            cbVaiTro = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            label7 = new Label();
            txbEmail = new TextBox();
            label10 = new Label();
            txbSDT = new TextBox();
            label11 = new Label();
            txbHoTen = new TextBox();
            label12 = new Label();
            txbMa = new TextBox();
            label13 = new Label();
            tabTK = new TabPage();
            groupBox2 = new GroupBox();
            txbTimTk = new TextBox();
            label9 = new Label();
            dtgDanhSach = new DataGridView();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rbNgung = new RadioButton();
            rbHD = new RadioButton();
            label8 = new Label();
            txbMk1 = new TextBox();
            txbMk = new Label();
            txbTenDangNhap = new TextBox();
            label3 = new Label();
            txbTenNv = new TextBox();
            label2 = new Label();
            txbMaTk = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabNV.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            tabTK.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSach).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabNV);
            tabControl1.Controls.Add(tabTK);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1447, 683);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabNV
            // 
            tabNV.Controls.Add(groupBox3);
            tabNV.Controls.Add(groupBox4);
            tabNV.Location = new Point(4, 32);
            tabNV.Margin = new Padding(4, 3, 4, 3);
            tabNV.Name = "tabNV";
            tabNV.Padding = new Padding(4, 3, 4, 3);
            tabNV.Size = new Size(1439, 647);
            tabNV.TabIndex = 0;
            tabNV.Text = "Thông tin nhân viên";
            tabNV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txbTim);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 10.2000008F);
            groupBox3.Location = new Point(4, 511);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1431, 133);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhân viên";
            // 
            // txbTim
            // 
            txbTim.BorderStyle = BorderStyle.FixedSingle;
            txbTim.Font = new Font("Segoe UI", 12F);
            txbTim.Location = new Point(813, 40);
            txbTim.Name = "txbTim";
            txbTim.Size = new Size(319, 34);
            txbTim.TabIndex = 9;
            txbTim.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(678, 47);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 8;
            label6.Text = "Tìm kiếm ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, -203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1425, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbVaiTro);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txbEmail);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txbSDT);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txbHoTen);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txbMa);
            groupBox4.Controls.Add(label13);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 10.2000008F);
            groupBox4.Location = new Point(4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1431, 508);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // cbVaiTro
            // 
            cbVaiTro.Font = new Font("Segoe UI", 10.2F);
            cbVaiTro.FormattingEnabled = true;
            cbVaiTro.Location = new Point(1022, 180);
            cbVaiTro.Name = "cbVaiTro";
            cbVaiTro.Size = new Size(405, 31);
            cbVaiTro.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F);
            button1.Image = Properties.Resources.icons8_clean_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1223, 392);
            button1.Name = "button1";
            button1.Size = new Size(257, 48);
            button1.TabIndex = 20;
            button1.Text = "Làm mới ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.Image = Properties.Resources.icons8_delete_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(845, 392);
            button2.Name = "button2";
            button2.Size = new Size(257, 48);
            button2.TabIndex = 19;
            button2.Text = "Xóa nhân viên ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.Image = Properties.Resources.icons8_change_24;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(468, 392);
            button3.Name = "button3";
            button3.Size = new Size(257, 48);
            button3.TabIndex = 18;
            button3.Text = "Sửa nhân viên ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F);
            button4.Image = Properties.Resources.icons8_add_30;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(102, 392);
            button4.Name = "button4";
            button4.Size = new Size(257, 48);
            button4.TabIndex = 17;
            button4.Text = "Thêm nhân viên";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F);
            radioButton1.Location = new Point(1323, 254);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 27);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nữ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F);
            radioButton2.Location = new Point(1022, 259);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 27);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nam";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(827, 259);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 14;
            label5.Text = "Giới tính ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(827, 180);
            label7.Name = "label7";
            label7.Size = new Size(62, 23);
            label7.TabIndex = 12;
            label7.Text = "Vai Trò";
            // 
            // txbEmail
            // 
            txbEmail.BorderStyle = BorderStyle.FixedSingle;
            txbEmail.Font = new Font("Segoe UI", 10.2F);
            txbEmail.Location = new Point(1022, 96);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(405, 30);
            txbEmail.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(829, 100);
            label10.Name = "label10";
            label10.Size = new Size(51, 23);
            label10.TabIndex = 6;
            label10.Text = "Email";
            // 
            // txbSDT
            // 
            txbSDT.BorderStyle = BorderStyle.FixedSingle;
            txbSDT.Font = new Font("Segoe UI", 10.2F);
            txbSDT.Location = new Point(252, 256);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(405, 30);
            txbSDT.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(59, 260);
            label11.Name = "label11";
            label11.Size = new Size(111, 23);
            label11.TabIndex = 4;
            label11.Text = "Số điện thoại";
            // 
            // txbHoTen
            // 
            txbHoTen.BorderStyle = BorderStyle.FixedSingle;
            txbHoTen.Font = new Font("Segoe UI", 10.2F);
            txbHoTen.Location = new Point(252, 176);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(405, 30);
            txbHoTen.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(59, 180);
            label12.Name = "label12";
            label12.Size = new Size(62, 23);
            label12.TabIndex = 2;
            label12.Text = "Họ tên";
            // 
            // txbMa
            // 
            txbMa.BorderStyle = BorderStyle.FixedSingle;
            txbMa.Font = new Font("Segoe UI", 10.2F);
            txbMa.Location = new Point(252, 99);
            txbMa.Name = "txbMa";
            txbMa.ReadOnly = true;
            txbMa.Size = new Size(405, 30);
            txbMa.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.Location = new Point(59, 103);
            label13.Name = "label13";
            label13.Size = new Size(114, 23);
            label13.TabIndex = 0;
            label13.Text = "Mã nhân viên";
            // 
            // tabTK
            // 
            tabTK.Controls.Add(groupBox2);
            tabTK.Controls.Add(groupBox1);
            tabTK.Location = new Point(4, 32);
            tabTK.Margin = new Padding(4, 3, 4, 3);
            tabTK.Name = "tabTK";
            tabTK.Padding = new Padding(4, 3, 4, 3);
            tabTK.Size = new Size(1439, 647);
            tabTK.TabIndex = 1;
            tabTK.Text = "Tài khoản nhân viên ";
            tabTK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbTimTk);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtgDanhSach);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2000008F);
            groupBox2.Location = new Point(4, 510);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1431, 134);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tài khoản";
            // 
            // txbTimTk
            // 
            txbTimTk.BorderStyle = BorderStyle.FixedSingle;
            txbTimTk.Font = new Font("Segoe UI", 12F);
            txbTimTk.Location = new Point(813, 40);
            txbTimTk.Name = "txbTimTk";
            txbTimTk.Size = new Size(319, 34);
            txbTimTk.TabIndex = 9;
            txbTimTk.TextChanged += txbTimTk_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(678, 47);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 8;
            label9.Text = "Tìm kiếm ";
            // 
            // dtgDanhSach
            // 
            dtgDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSach.Dock = DockStyle.Bottom;
            dtgDanhSach.Location = new Point(3, -202);
            dtgDanhSach.Name = "dtgDanhSach";
            dtgDanhSach.RowHeadersWidth = 51;
            dtgDanhSach.Size = new Size(1425, 333);
            dtgDanhSach.TabIndex = 0;
            dtgDanhSach.CellClick += dtgDanhSach_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(rbNgung);
            groupBox1.Controls.Add(rbHD);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txbMk1);
            groupBox1.Controls.Add(txbMk);
            groupBox1.Controls.Add(txbTenDangNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbTenNv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbMaTk);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2000008F);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1431, 507);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(1234, 402);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(257, 48);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(856, 402);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(257, 48);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa tài khoản";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Image = Properties.Resources.icons8_change_24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(479, 402);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(257, 48);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa tài khoản";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(113, 402);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(257, 48);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm tài khoản";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rbNgung
            // 
            rbNgung.AutoSize = true;
            rbNgung.Font = new Font("Segoe UI", 10.2F);
            rbNgung.Location = new Point(553, 281);
            rbNgung.Name = "rbNgung";
            rbNgung.Size = new Size(174, 27);
            rbNgung.TabIndex = 16;
            rbNgung.TabStop = true;
            rbNgung.Text = "Ngừng hoạt động ";
            rbNgung.UseVisualStyleBackColor = true;
            // 
            // rbHD
            // 
            rbHD.AutoSize = true;
            rbHD.Font = new Font("Segoe UI", 10.2F);
            rbHD.Location = new Point(252, 286);
            rbHD.Name = "rbHD";
            rbHD.Size = new Size(157, 27);
            rbHD.TabIndex = 15;
            rbHD.TabStop = true;
            rbHD.Text = "Đang hoạt động";
            rbHD.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(57, 286);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 14;
            label8.Text = "Trạng thái";
            // 
            // txbMk1
            // 
            txbMk1.BorderStyle = BorderStyle.FixedSingle;
            txbMk1.Font = new Font("Segoe UI", 10.2F);
            txbMk1.Location = new Point(1022, 185);
            txbMk1.Name = "txbMk1";
            txbMk1.Size = new Size(405, 30);
            txbMk1.TabIndex = 7;
            // 
            // txbMk
            // 
            txbMk.AutoSize = true;
            txbMk.Font = new Font("Segoe UI", 10.2F);
            txbMk.Location = new Point(829, 189);
            txbMk.Name = "txbMk";
            txbMk.Size = new Size(82, 23);
            txbMk.TabIndex = 6;
            txbMk.Text = "Mật khẩu";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txbTenDangNhap.Font = new Font("Segoe UI", 10.2F);
            txbTenDangNhap.Location = new Point(1022, 96);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(405, 30);
            txbTenDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(829, 100);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 4;
            label3.Text = "Tên đăng nhập";
            // 
            // txbTenNv
            // 
            txbTenNv.BorderStyle = BorderStyle.FixedSingle;
            txbTenNv.Font = new Font("Segoe UI", 10.2F);
            txbTenNv.Location = new Point(252, 188);
            txbTenNv.Name = "txbTenNv";
            txbTenNv.Size = new Size(405, 30);
            txbTenNv.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(59, 192);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "idNhanVien";
            // 
            // txbMaTk
            // 
            txbMaTk.BorderStyle = BorderStyle.FixedSingle;
            txbMaTk.Font = new Font("Segoe UI", 10.2F);
            txbMaTk.Location = new Point(252, 99);
            txbMaTk.Name = "txbMaTk";
            txbMaTk.ReadOnly = true;
            txbMaTk.Size = new Size(405, 30);
            txbMaTk.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(59, 103);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã tài khoản";
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 683);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
            Load += QuanLyNhanVien_Load;
            tabControl1.ResumeLayout(false);
            tabNV.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabTK.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabNV;
        private TabPage tabTK;
        private GroupBox groupBox2;
        private TextBox txbTimTk;
        private Label label9;
        private DataGridView dtgDanhSach;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private RadioButton rbNgung;
        private RadioButton rbHD;
        private Label label8;
        private TextBox txbMk1;
        private Label txbMk;
        private TextBox txbTenDangNhap;
        private Label label3;
        private TextBox txbTenNv;
        private Label label2;
        private TextBox txbMaTk;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txbTim;
        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private ComboBox cbVaiTro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private Label label7;
        private TextBox txbEmail;
        private Label label10;
        private TextBox txbSDT;
        private Label label11;
        private TextBox txbHoTen;
        private Label label12;
        private TextBox txbMa;
        private Label label13;
    }
}