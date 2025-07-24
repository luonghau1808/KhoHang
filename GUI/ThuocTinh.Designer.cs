namespace DuAn1_Nhom4.GUI
{
    partial class ThuocTinh
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
            rbMauSac = new RadioButton();
            rbKichThuoc = new RadioButton();
            label1 = new Label();
            txtTenThuocTinh = new TextBox();
            groupBox2 = new GroupBox();
            dtgThongTin = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTin).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(rbMauSac);
            groupBox1.Controls.Add(rbKichThuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenThuocTinh);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thuộc tính sản phẩm ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F);
            btnLamMoi.Image = Properties.Resources.icons8_clean_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(996, 206);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(240, 48);
            btnLamMoi.TabIndex = 32;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(678, 206);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(240, 48);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa thuộc tính";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Image = Properties.Resources.icons8_change_24;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(361, 206);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(240, 48);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa thuộc tính";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(37, 206);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(240, 48);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm thuộc tính ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // rbMauSac
            // 
            rbMauSac.AutoSize = true;
            rbMauSac.Font = new Font("Segoe UI", 10.2F);
            rbMauSac.Location = new Point(974, 97);
            rbMauSac.Name = "rbMauSac";
            rbMauSac.Size = new Size(99, 27);
            rbMauSac.TabIndex = 3;
            rbMauSac.TabStop = true;
            rbMauSac.Text = "Màu sắc ";
            rbMauSac.UseVisualStyleBackColor = true;
            // 
            // rbKichThuoc
            // 
            rbKichThuoc.AutoSize = true;
            rbKichThuoc.Font = new Font("Segoe UI", 10.2F);
            rbKichThuoc.Location = new Point(711, 98);
            rbKichThuoc.Name = "rbKichThuoc";
            rbKichThuoc.Size = new Size(117, 27);
            rbKichThuoc.TabIndex = 2;
            rbKichThuoc.TabStop = true;
            rbKichThuoc.Text = "Kích thước ";
            rbKichThuoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(37, 101);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên thuộc tính";
            // 
            // txtTenThuocTinh
            // 
            txtTenThuocTinh.BorderStyle = BorderStyle.FixedSingle;
            txtTenThuocTinh.Font = new Font("Segoe UI", 10.2F);
            txtTenThuocTinh.Location = new Point(210, 99);
            txtTenThuocTinh.Name = "txtTenThuocTinh";
            txtTenThuocTinh.Size = new Size(349, 30);
            txtTenThuocTinh.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgThongTin);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1311, 378);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thuộc tính ";
            // 
            // dtgThongTin
            // 
            dtgThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongTin.Dock = DockStyle.Bottom;
            dtgThongTin.Location = new Point(3, 69);
            dtgThongTin.Name = "dtgThongTin";
            dtgThongTin.RowHeadersWidth = 51;
            dtgThongTin.Size = new Size(1305, 306);
            dtgThongTin.TabIndex = 0;
            // 
            // ThuocTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 706);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ThuocTinh";
            Text = "ThuocTinh";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTenThuocTinh;
        private RadioButton rbMauSac;
        private RadioButton rbKichThuoc;
        private GroupBox groupBox2;
        private DataGridView dtgThongTin;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}