namespace DuAn1_Nhom4.GUI
{
    partial class FormLichSu
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnTk = new Button();
            dgvPhieu = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            dgvCt = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            labelMaNV = new Label();
            labelTenNV = new Label();
            labelNgayTao = new Label();
            labelTrangThai = new Label();
            labelTongTien = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCt).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTk);
            groupBox1.Controls.Add(dgvPhieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            groupBox1.Size = new Size(1120, 582);
=======
            groupBox1.Size = new Size(1026, 582);
>>>>>>> Minh
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử hoạt động";
            // 
            // btnTk
            // 
            btnTk.Image = Properties.Resources.icons8_view_30;
            btnTk.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            btnTk.Location = new Point(947, 139);
=======
            btnTk.Location = new Point(835, 139);
>>>>>>> Minh
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(143, 43);
            btnTk.TabIndex = 7;
            btnTk.Text = "Tìm kiếm";
            btnTk.TextAlign = ContentAlignment.MiddleRight;
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // dgvPhieu
            // 
            dgvPhieu.AllowUserToAddRows = false;
            dgvPhieu.AllowUserToDeleteRows = false;
            dgvPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieu.Dock = DockStyle.Bottom;
            dgvPhieu.Location = new Point(3, 228);
            dgvPhieu.MultiSelect = false;
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.ReadOnly = true;
            dgvPhieu.RowHeadersWidth = 51;
            dgvPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            dgvPhieu.Size = new Size(1114, 351);
=======
            dgvPhieu.Size = new Size(1020, 351);
>>>>>>> Minh
            dgvPhieu.TabIndex = 6;
            dgvPhieu.CellClick += dgvPhieu_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 78);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 78);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 4;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 3;
            label1.Text = "Loại phiếu";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(910, 78);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(180, 30);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(515, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 30);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCt);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 582);
            groupBox2.Name = "groupBox2";
<<<<<<< HEAD
            groupBox2.Size = new Size(1120, 330);
=======
            groupBox2.Size = new Size(1026, 330);
>>>>>>> Minh
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvCt
            // 
            dgvCt.AllowUserToAddRows = false;
            dgvCt.AllowUserToDeleteRows = false;
            dgvCt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCt.Dock = DockStyle.Fill;
            dgvCt.Location = new Point(3, 26);
            dgvCt.MultiSelect = false;
            dgvCt.Name = "dgvCt";
            dgvCt.ReadOnly = true;
            dgvCt.RowHeadersWidth = 51;
            dgvCt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            dgvCt.Size = new Size(1114, 301);
=======
            dgvCt.Size = new Size(1020, 301);
>>>>>>> Minh
            dgvCt.TabIndex = 7;
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
            // labelMaNV
            // 
            labelMaNV.AutoSize = true;
            labelMaNV.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            labelMaNV.Location = new Point(38, 71);
            labelMaNV.Name = "labelMaNV";
            labelMaNV.Size = new Size(146, 30);
            labelMaNV.TabIndex = 0;
            labelMaNV.Text = "Mã nhân viên:";
            // 
            // labelTenNV
            // 
            labelTenNV.AutoSize = true;
            labelTenNV.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            labelTenNV.Location = new Point(38, 144);
            labelTenNV.Name = "labelTenNV";
            labelTenNV.Size = new Size(149, 30);
            labelTenNV.TabIndex = 1;
            labelTenNV.Text = "Tên nhân viên:";
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            labelNgayTao.Location = new Point(38, 228);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(107, 30);
            labelNgayTao.TabIndex = 4;
            labelNgayTao.Text = "Ngày tạo:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            labelTrangThai.Location = new Point(40, 397);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(114, 30);
            labelTrangThai.TabIndex = 5;
            labelTrangThai.Text = "Trạng thái:";
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            labelTongTien.Location = new Point(38, 310);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(116, 30);
            labelTongTien.TabIndex = 6;
            labelTongTien.Text = "Tổng tiền: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTongTien);
            panel1.Controls.Add(labelTrangThai);
            panel1.Controls.Add(labelNgayTao);
            panel1.Controls.Add(labelTenNV);
            panel1.Controls.Add(labelMaNV);
            panel1.Dock = DockStyle.Right;
<<<<<<< HEAD
            panel1.Location = new Point(1120, 0);
=======
            panel1.Location = new Point(1026, 0);
>>>>>>> Minh
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 912);
            panel1.TabIndex = 0;
            // 
            // FormLichSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 912);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormLichSu";
            Text = "FormLichSu";
            Load += FormLichSu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvPhieu;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private DataGridView dgvCt;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Button btnTk;
        private Label labelMaNV;
        private Label labelTenNV;
        private Label labelNgayTao;
        private Label labelTrangThai;
        private Label labelTongTien;
        private Panel panel1;
    }
}