namespace DuAn1_Nhom4.GUI
{
    partial class NhaCungCap
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
            groupBox1 = new GroupBox();
            rbNgungHopTac = new RadioButton();
            rbHopTac = new RadioButton();
            label6 = new Label();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtgDanhSachNCC);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2000008F);
            groupBox2.Location = new Point(0, 520);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1515, 402);
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
            txtTim.Size = new Size(319, 34);
            txtTim.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(678, 47);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 8;
            label9.Text = "Tìm kiếm ";
            // 
            // dtgDanhSachNCC
            // 
            dtgDanhSachNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachNCC.Dock = DockStyle.Bottom;
            dtgDanhSachNCC.Location = new Point(3, 109);
            dtgDanhSachNCC.Name = "dtgDanhSachNCC";
            dtgDanhSachNCC.RowHeadersWidth = 51;
            dtgDanhSachNCC.Size = new Size(1509, 290);
            dtgDanhSachNCC.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNgungHopTac);
            groupBox1.Controls.Add(rbHopTac);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2000008F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1515, 520);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // rbNgungHopTac
            // 
            rbNgungHopTac.AutoSize = true;
            rbNgungHopTac.Font = new Font("Segoe UI", 10.2F);
            rbNgungHopTac.Location = new Point(1303, 259);
            rbNgungHopTac.Name = "rbNgungHopTac";
            rbNgungHopTac.Size = new Size(147, 27);
            rbNgungHopTac.TabIndex = 27;
            rbNgungHopTac.TabStop = true;
            rbNgungHopTac.Text = "Ngừng hợp tác";
            rbNgungHopTac.UseVisualStyleBackColor = true;
            // 
            // rbHopTac
            // 
            rbHopTac.AutoSize = true;
            rbHopTac.Font = new Font("Segoe UI", 10.2F);
            rbHopTac.Location = new Point(1100, 259);
            rbHopTac.Name = "rbHopTac";
            rbHopTac.Size = new Size(91, 27);
            rbHopTac.TabIndex = 26;
            rbHopTac.TabStop = true;
            rbHopTac.Text = "Hợp tác";
            rbHopTac.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(925, 262);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 25;
            label6.Text = "Trạng thái ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(1270, 407);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(257, 48);
            btnLamMoi.TabIndex = 24;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(915, 407);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(254, 48);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa nhà cung cấp";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Image = Properties.Resources.icons8_change_24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(524, 407);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(254, 48);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa nhà cung cấp";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(134, 407);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(254, 48);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm nhà cung cấp";
            btnThem.UseVisualStyleBackColor = true;
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
            label5.Font = new Font("Segoe UI", 10.2F);
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
            label4.Font = new Font("Segoe UI", 10.2F);
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
            label3.Font = new Font("Segoe UI", 10.2F);
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
            label2.Font = new Font("Segoe UI", 10.2F);
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
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(89, 77);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã nhà cung cấp";
            // 
            // NhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 922);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NhaCungCap";
            Text = "NhaCungCap";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNCC).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtTim;
        private Label label9;
        private DataGridView dtgDanhSachNCC;
        private GroupBox groupBox1;
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
        private RadioButton rbNgungHopTac;
        private RadioButton rbHopTac;
        private Label label6;
    }
}