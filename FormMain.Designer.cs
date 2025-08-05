namespace DuAn1_Nhom4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btnDangXuat = new Button();
            btnLichSu = new Button();
            btnTaiKhoan = new Button();
            btnHoaDon = new Button();
            btnNCC = new Button();
            btnNV = new Button();
            btnSP = new Button();
            btnThongKe = new Button();
            pictureBoxLogo = new PictureBox();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightSteelBlue;
            panelSidebar.Controls.Add(btnDangXuat);
            panelSidebar.Controls.Add(btnLichSu);
            panelSidebar.Controls.Add(btnTaiKhoan);
            panelSidebar.Controls.Add(btnHoaDon);
            panelSidebar.Controls.Add(btnNCC);
            panelSidebar.Controls.Add(btnNV);
            panelSidebar.Controls.Add(btnSP);
            panelSidebar.Controls.Add(btnThongKe);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(283, 922);
            panelSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnDangXuat.ForeColor = SystemColors.ActiveCaptionText;
            btnDangXuat.Image = Properties.Resources.icons8_shopify_30;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 784);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 77);
            btnDangXuat.TabIndex = 14;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnLichSu
            // 
            btnLichSu.Dock = DockStyle.Top;
            btnLichSu.FlatAppearance.BorderSize = 0;
            btnLichSu.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnLichSu.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnLichSu.ForeColor = SystemColors.ActiveCaptionText;
            btnLichSu.Image = Properties.Resources.z6860265719254_d26a62abf706e90cbbbab99478350798_removebg_preview;
            btnLichSu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLichSu.Location = new Point(0, 707);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(283, 77);
            btnLichSu.TabIndex = 12;
            btnLichSu.Text = "Lịch sử";
            btnLichSu.UseVisualStyleBackColor = true;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnTaiKhoan.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
            btnTaiKhoan.Image = Properties.Resources.icons8_login_30;
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(0, 630);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(283, 77);
            btnTaiKhoan.TabIndex = 11;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnHoaDon.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnHoaDon.ForeColor = SystemColors.ActiveCaptionText;
            btnHoaDon.Image = Properties.Resources.icons8_shopify_30;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 553);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(283, 77);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Xuất hàng";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNCC
            // 
            btnNCC.Dock = DockStyle.Top;
            btnNCC.FlatAppearance.BorderSize = 0;
            btnNCC.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnNCC.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnNCC.FlatStyle = FlatStyle.Flat;
            btnNCC.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnNCC.ForeColor = SystemColors.ActiveCaptionText;
            btnNCC.Image = Properties.Resources.icons8_delivery_time_30;
            btnNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC.Location = new Point(0, 476);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(283, 77);
            btnNCC.TabIndex = 4;
            btnNCC.Text = " Nhập hàng";
            btnNCC.UseVisualStyleBackColor = true;
            btnNCC.Click += btnNCC_Click;
            // 
            // btnNV
            // 
            btnNV.Dock = DockStyle.Top;
            btnNV.FlatAppearance.BorderSize = 0;
            btnNV.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnNV.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnNV.FlatStyle = FlatStyle.Flat;
            btnNV.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnNV.ForeColor = SystemColors.ActiveCaptionText;
            btnNV.Image = Properties.Resources.icons8_people_30;
            btnNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnNV.Location = new Point(0, 399);
            btnNV.Name = "btnNV";
            btnNV.Size = new Size(283, 77);
            btnNV.TabIndex = 3;
            btnNV.Text = "Nhân viên";
            btnNV.UseVisualStyleBackColor = true;
            btnNV.Click += btnNV_Click;
            // 
            // btnSP
            // 
            btnSP.Dock = DockStyle.Top;
            btnSP.FlatAppearance.BorderSize = 0;
            btnSP.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnSP.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnSP.FlatStyle = FlatStyle.Flat;
            btnSP.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSP.ForeColor = SystemColors.ActiveCaptionText;
            btnSP.Image = Properties.Resources.icons8_product_30;
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(0, 322);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(283, 77);
            btnSP.TabIndex = 2;
            btnSP.Text = "Sản phẩm";
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnSP_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ActiveCaptionText;
            btnThongKe.Image = Properties.Resources.icons8_analytics_301;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 245);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 77);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.LightSteelBlue;
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = Properties.Resources.Screenshot_2025_07_08_195922_removebg_preview1;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(283, 245);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(283, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(928, 922);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1211, 922);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnThongKe;
        private PictureBox pictureBoxLogo;
        private Button btnNCC;
        private Button btnNV;
        private Button btnSP;
        private Button btnTaiKhoan;
        private Button btnHoaDon;
        private Panel panelMain;
        private Button btnLichSu;
        private Button btnDangXuat;
    }
}
