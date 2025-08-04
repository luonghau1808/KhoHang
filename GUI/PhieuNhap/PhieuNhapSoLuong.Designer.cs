namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    partial class PhieuNhapSoLuong
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
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXacNhan;

        private void InitializeComponent()
        {
            txtSoLuong = new TextBox();
            lblTitle = new Label();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 10F);
            txtSoLuong.Location = new Point(15, 45);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(563, 30);
            txtSoLuong.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nhập số lượng mới:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(419, 103);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(159, 35);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // PhieuNhapSoLuong
            // 
            AcceptButton = btnXacNhan;
            ClientSize = new Size(602, 150);
            Controls.Add(lblTitle);
            Controls.Add(txtSoLuong);
            Controls.Add(btnXacNhan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PhieuNhapSoLuong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chỉnh sửa số lượng";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}