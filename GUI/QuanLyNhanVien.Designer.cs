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
            tabTK = new TabPage();
            tabControl1.SuspendLayout();
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
            tabControl1.Size = new Size(1000, 518);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabNV
            // 
            tabNV.Location = new Point(4, 32);
            tabNV.Margin = new Padding(4, 3, 4, 3);
            tabNV.Name = "tabNV";
            tabNV.Padding = new Padding(4, 3, 4, 3);
            tabNV.Size = new Size(992, 482);
            tabNV.TabIndex = 0;
            tabNV.Text = "Thông tin nhân viên";
            tabNV.UseVisualStyleBackColor = true;
            // 
            // tabTK
            // 
            tabTK.Location = new Point(4, 32);
            tabTK.Margin = new Padding(4, 3, 4, 3);
            tabTK.Name = "tabTK";
            tabTK.Padding = new Padding(4, 3, 4, 3);
            tabTK.Size = new Size(992, 482);
            tabTK.TabIndex = 1;
            tabTK.Text = "Tài khoản nhân viên ";
            tabTK.UseVisualStyleBackColor = true;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabNV;
        private TabPage tabTK;
    }
}