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
            textBox1 = new TextBox();
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
            textBox2 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            tabTK = new TabPage();
            groupBox2 = new GroupBox();
            txtTim = new TextBox();
            label9 = new Label();
            dtgDanhSach = new DataGridView();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            label8 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
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
            tabControl1.Size = new Size(1355, 683);
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
            tabNV.Size = new Size(1347, 647);
            tabNV.TabIndex = 0;
            tabNV.Text = "Thông tin nhân viên";
            tabNV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 10.2000008F);
            groupBox3.Location = new Point(4, 511);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1339, 133);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhân viên";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(813, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 34);
            textBox1.TabIndex = 9;
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, -203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1333, 333);
            dataGridView1.TabIndex = 0;
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
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label13);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 10.2000008F);
            groupBox4.Location = new Point(4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1339, 508);
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(1022, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(405, 30);
            textBox2.TabIndex = 7;
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
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 10.2F);
            textBox5.Location = new Point(252, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(405, 30);
            textBox5.TabIndex = 5;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.Location = new Point(252, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(405, 30);
            textBox3.TabIndex = 3;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10.2F);
            textBox4.Location = new Point(252, 99);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(405, 30);
            textBox4.TabIndex = 1;
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
            tabTK.Location = new Point(4, 29);
            tabTK.Margin = new Padding(4, 3, 4, 3);
            tabTK.Name = "tabTK";
            tabTK.Padding = new Padding(4, 3, 4, 3);
            tabTK.Size = new Size(1347, 650);
            tabTK.TabIndex = 1;
            tabTK.Text = "Tài khoản nhân viên ";
            tabTK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtgDanhSach);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2000008F);
            groupBox2.Location = new Point(4, 510);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1339, 137);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tài khoản";
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Font = new Font("Segoe UI", 12F);
            txtTim.Location = new Point(813, 40);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(319, 34);
            txtTim.TabIndex = 9;
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
            dtgDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSach.Dock = DockStyle.Bottom;
            dtgDanhSach.Location = new Point(3, -199);
            dtgDanhSach.Name = "dtgDanhSach";
            dtgDanhSach.RowHeadersWidth = 51;
            dtgDanhSach.Size = new Size(1333, 333);
            dtgDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(rbNu);
            groupBox1.Controls.Add(rbNam);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2000008F);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1339, 507);
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
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Font = new Font("Segoe UI", 10.2F);
            rbNu.Location = new Point(553, 281);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(174, 27);
            rbNu.TabIndex = 16;
            rbNu.TabStop = true;
            rbNu.Text = "Ngừng hoạt động ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Font = new Font("Segoe UI", 10.2F);
            rbNam.Location = new Point(252, 286);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(157, 27);
            rbNam.TabIndex = 15;
            rbNam.TabStop = true;
            rbNam.Text = "Đang hoạt động";
            rbNam.UseVisualStyleBackColor = true;
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
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(1022, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(405, 30);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(829, 189);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F);
            txtSDT.Location = new Point(1022, 96);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(405, 30);
            txtSDT.TabIndex = 5;
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
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10.2F);
            txtHoTen.Location = new Point(252, 188);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(405, 30);
            txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(59, 192);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "Mã nhân viên";
            // 
            // txtMa
            // 
            txtMa.BorderStyle = BorderStyle.FixedSingle;
            txtMa.Font = new Font("Segoe UI", 10.2F);
            txtMa.Location = new Point(252, 99);
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(405, 30);
            txtMa.TabIndex = 1;
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
            ClientSize = new Size(1355, 683);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
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
        private TextBox txtTim;
        private Label label9;
        private DataGridView dtgDanhSach;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Label label8;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox textBox1;
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
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox3;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
    }
}