namespace DuAn1_Nhom4.GUI
{
    partial class QuanLyNCC
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
            groupBox2 = new GroupBox();
            txtTim = new TextBox();
            label9 = new Label();
            dtgDanhSachNCC = new DataGridView();
            groupBoxTTNCC = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            txtTenNCC = new TextBox();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNCC).BeginInit();
            groupBoxTTNCC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtgDanhSachNCC);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 520);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1649, 402);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Font = new Font("Segoe UI", 12F);
            txtTim.Location = new Point(813, 40);
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Nhập thông tin tìm kiếm";
            txtTim.Size = new Size(319, 34);
            txtTim.TabIndex = 9;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(678, 47);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 8;
            label9.Text = "Tìm kiếm ";
            // 
            // dtgDanhSachNCC
            // 
            dtgDanhSachNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachNCC.Dock = DockStyle.Bottom;
            dtgDanhSachNCC.Location = new Point(3, 109);
            dtgDanhSachNCC.MultiSelect = false;
            dtgDanhSachNCC.Name = "dtgDanhSachNCC";
            dtgDanhSachNCC.ReadOnly = true;
            dtgDanhSachNCC.RowHeadersWidth = 51;
            dtgDanhSachNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachNCC.Size = new Size(1643, 290);
            dtgDanhSachNCC.TabIndex = 0;
            dtgDanhSachNCC.CellClick += dtgDanhSachNCC_CellClick;
            // 
            // groupBoxTTNCC
            // 
            groupBoxTTNCC.Controls.Add(btnLamMoi);
            groupBoxTTNCC.Controls.Add(btnXoa);
            groupBoxTTNCC.Controls.Add(btnSua);
            groupBoxTTNCC.Controls.Add(btnThem);
            groupBoxTTNCC.Controls.Add(txtDiaChi);
            groupBoxTTNCC.Controls.Add(label5);
            groupBoxTTNCC.Controls.Add(txtEmail);
            groupBoxTTNCC.Controls.Add(label4);
            groupBoxTTNCC.Controls.Add(txtSDT);
            groupBoxTTNCC.Controls.Add(label3);
            groupBoxTTNCC.Controls.Add(txtTenNCC);
            groupBoxTTNCC.Controls.Add(label2);
            groupBoxTTNCC.Controls.Add(txtMaNCC);
            groupBoxTTNCC.Controls.Add(label1);
            groupBoxTTNCC.Dock = DockStyle.Top;
            groupBoxTTNCC.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxTTNCC.Location = new Point(0, 0);
            groupBoxTTNCC.Name = "groupBoxTTNCC";
            groupBoxTTNCC.Size = new Size(1649, 520);
            groupBoxTTNCC.TabIndex = 2;
            groupBoxTTNCC.TabStop = false;
            groupBoxTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(1270, 407);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(257, 48);
            btnLamMoi.TabIndex = 24;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.icons8_delete_303;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(915, 407);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(254, 48);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa nhà cung cấp";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.icons8_edit_302;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(524, 407);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(254, 48);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa nhà cung cấp";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(134, 407);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(254, 48);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm nhà cung cấp";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10.2F);
            txtDiaChi.Location = new Point(295, 259);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(421, 30);
            txtDiaChi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(89, 266);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 8;
            label5.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(1092, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(425, 30);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(925, 80);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F);
            txtSDT.Location = new Point(1092, 162);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(425, 30);
            txtSDT.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(925, 165);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderStyle = BorderStyle.FixedSingle;
            txtTenNCC.Font = new Font("Segoe UI", 10.2F);
            txtTenNCC.Location = new Point(295, 159);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(421, 30);
            txtTenNCC.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(89, 166);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            txtMaNCC.BorderStyle = BorderStyle.FixedSingle;
            txtMaNCC.Font = new Font("Segoe UI", 10.2F);
            txtMaNCC.Location = new Point(295, 70);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(421, 30);
            txtMaNCC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(89, 77);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã nhà cung cấp";
            // 
            // QuanLyNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 922);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxTTNCC);
            Name = "QuanLyNCC";
            Text = "NhaCungCap";
            Load += QuanLyNCC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNCC).EndInit();
            groupBoxTTNCC.ResumeLayout(false);
            groupBoxTTNCC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtTim;
        private Label label9;
        private DataGridView dtgDanhSachNCC;
        private GroupBox groupBoxTTNCC;
        private TextBox txtDiaChi;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtTenNCC;
        private Label label2;
        private TextBox txtMaNCC;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}