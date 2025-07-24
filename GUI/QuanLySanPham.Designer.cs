namespace DuAn1_Nhom4
{
    partial class QuanLySanPham
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
            tabThongTin = new TabPage();
            tabThuocTinh = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabThongTin);
            tabControl1.Controls.Add(tabThuocTinh);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabThongTin
            // 
            tabThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabThongTin.Location = new Point(4, 37);
            tabThongTin.Name = "tabThongTin";
            tabThongTin.Padding = new Padding(3);
            tabThongTin.Size = new Size(792, 409);
            tabThongTin.TabIndex = 0;
            tabThongTin.Text = "Thông tin sản phẩm";
            tabThongTin.UseVisualStyleBackColor = true;
            // 
            // tabThuocTinh
            // 
            tabThuocTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabThuocTinh.Location = new Point(4, 37);
            tabThuocTinh.Name = "tabThuocTinh";
            tabThuocTinh.Padding = new Padding(3);
            tabThuocTinh.Size = new Size(792, 409);
            tabThuocTinh.TabIndex = 1;
            tabThuocTinh.Text = "Thuộc tính sản phẩm ";
            tabThuocTinh.UseVisualStyleBackColor = true;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabThongTin;
        private TabPage tabThuocTinh;
    }
}