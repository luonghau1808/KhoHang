namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    partial class SanPhamF
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
            panel1 = new Panel();
            txtSanPham = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            dgvSP = new DataGridView();
            txtSearch = new TextBox();
            btnThemGioHang = new Button();
            label8 = new Label();
            txtSoluongNhap = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtSanPham);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnThemGioHang);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSoluongNhap);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 678);
            panel1.TabIndex = 0;
            // 
            // txtSanPham
            // 
            txtSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSanPham.BorderStyle = BorderStyle.FixedSingle;
            txtSanPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSanPham.Location = new Point(380, 64);
            txtSanPham.Name = "txtSanPham";
            txtSanPham.ReadOnly = true;
            txtSanPham.Size = new Size(420, 30);
            txtSanPham.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvSP);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 367);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 17;
            label2.Text = "Tên sản phẩm ";
            // 
            // dgvSP
            // 
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Dock = DockStyle.Bottom;
            dgvSP.Location = new Point(3, 133);
            dgvSP.MultiSelect = false;
            dgvSP.Name = "dgvSP";
            dgvSP.ReadOnly = true;
            dgvSP.RowHeadersWidth = 51;
            dgvSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSP.Size = new Size(1143, 231);
            dgvSP.TabIndex = 11;
            dgvSP.CellClick += dgvSP_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(165, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm cần tìm";
            txtSearch.Size = new Size(420, 30);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnThemGioHang
            // 
            btnThemGioHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThemGioHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThemGioHang.Image = Properties.Resources.icons8_add_shopping_cart_30;
            btnThemGioHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemGioHang.Location = new Point(460, 220);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(259, 48);
            btnThemGioHang.TabIndex = 20;
            btnThemGioHang.Text = "Thêm vào giỏ hàng";
            btnThemGioHang.UseVisualStyleBackColor = true;
            btnThemGioHang.Click += btnThemGioHang_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(245, 150);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 19;
            label8.Text = "Nhập số lượng";
            // 
            // txtSoluongNhap
            // 
            txtSoluongNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSoluongNhap.BorderStyle = BorderStyle.FixedSingle;
            txtSoluongNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSoluongNhap.Location = new Point(380, 143);
            txtSoluongNhap.Name = "txtSoluongNhap";
            txtSoluongNhap.Size = new Size(420, 30);
            txtSoluongNhap.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(248, 71);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 17;
            label1.Text = "Tên sản phẩm ";
            // 
            // SanPhamF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 678);
            Controls.Add(panel1);
            Name = "SanPhamF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += DanhSachSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSanPham;
        private GroupBox groupBox1;
        private Label label2;
        private DataGridView dgvSP;
        private TextBox txtSearch;
        private Button btnThemGioHang;
        private Label label8;
        private TextBox txtSoluongNhap;
        private Label label1;
    }
}