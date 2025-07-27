namespace DuAn1_Nhom4.GUI
{
    partial class HoaDon
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
            groupBox5 = new GroupBox();
            tabControl1 = new TabControl();
            tabHoaDon = new TabPage();
            tabDatHang = new TabPage();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            dtgGioHang = new DataGridView();
            groupBox2 = new GroupBox();
            dtgDanhSachSP = new DataGridView();
            groupBox1 = new GroupBox();
            dtgDanhSachHD = new DataGridView();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox5.SuspendLayout();
            tabControl1.SuspendLayout();
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
            tabHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabHoaDon.Location = new Point(4, 32);
            tabHoaDon.Name = "tabHoaDon";
            tabHoaDon.Padding = new Padding(3);
            tabHoaDon.Size = new Size(501, 986);
            tabHoaDon.TabIndex = 0;
            tabHoaDon.Text = "Hóa đơn";
            tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // tabDatHang
            // 
            tabDatHang.Location = new Point(4, 32);
            tabDatHang.Name = "tabDatHang";
            tabDatHang.Padding = new Padding(3);
            tabDatHang.Size = new Size(501, 986);
            tabDatHang.TabIndex = 1;
            tabDatHang.Text = "Đặt hàng";
            tabDatHang.UseVisualStyleBackColor = true;
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
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(dtgGioHang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1285, 505);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ hàng ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(38, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(254, 48);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgGioHang
            // 
            dtgGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGioHang.Dock = DockStyle.Top;
            dtgGioHang.Location = new Point(3, 26);
            dtgGioHang.Name = "dtgGioHang";
            dtgGioHang.RowHeadersWidth = 51;
            dtgGioHang.Size = new Size(1279, 268);
            dtgGioHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgDanhSachSP);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 765);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1285, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm ";
            // 
            // dtgDanhSachSP
            // 
            dtgDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachSP.Dock = DockStyle.Fill;
            dtgDanhSachSP.Location = new Point(3, 26);
            dtgDanhSachSP.Name = "dtgDanhSachSP";
            dtgDanhSachSP.RowHeadersWidth = 51;
            dtgDanhSachSP.Size = new Size(1279, 257);
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
            dtgDanhSachHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachHD.Dock = DockStyle.Fill;
            dtgDanhSachHD.Location = new Point(3, 26);
            dtgDanhSachHD.Name = "dtgDanhSachHD";
            dtgDanhSachHD.RowHeadersWidth = 51;
            dtgDanhSachHD.Size = new Size(1279, 231);
            dtgDanhSachHD.TabIndex = 0;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 1051);
            Controls.Add(panel1);
            Controls.Add(groupBox5);
            Name = "HoaDon";
            Text = "HoaDon";
            groupBox5.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
    }
}