namespace DuAn1_Nhom4.GUI
{
    partial class TaoHoaDon
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
            panel3 = new Panel();
            btnHuy = new Button();
            btnTao = new Button();
            btnThanhToan = new Button();
            panel2 = new Panel();
            cbHTTT = new ComboBox();
            txtTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnTao);
            panel3.Controls.Add(btnThanhToan);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 564);
            panel3.Name = "panel3";
            panel3.Size = new Size(1757, 342);
            panel3.TabIndex = 8;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(283, 129);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(167, 63);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            btnTao.Image = Properties.Resources.icons8_add_301;
            btnTao.ImageAlign = ContentAlignment.MiddleLeft;
            btnTao.Location = new Point(41, 129);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(173, 63);
            btnTao.TabIndex = 1;
            btnTao.Text = "Tạo hóa đơn";
            btnTao.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Image = Properties.Resources.icons8_dollar_bag_30;
            btnThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.Location = new Point(41, 27);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(409, 61);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán ";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbHTTT);
            panel2.Controls.Add(txtTien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(1757, 750);
            panel2.TabIndex = 7;
            // 
            // cbHTTT
            // 
            cbHTTT.FormattingEnabled = true;
            cbHTTT.Location = new Point(278, 148);
            cbHTTT.Name = "cbHTTT";
            cbHTTT.Size = new Size(172, 28);
            cbHTTT.TabIndex = 5;
            // 
            // txtTien
            // 
            txtTien.BorderStyle = BorderStyle.FixedSingle;
            txtTien.Location = new Point(278, 215);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(172, 27);
            txtTien.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(54, 276);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 4;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(54, 219);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 3;
            label6.Text = "Tiền khách đưa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(54, 156);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 2;
            label5.Text = "Hình thức thanh toán ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(56, 91);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 1;
            label4.Text = "Khách cần trả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(56, 28);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 0;
            label3.Text = "Tổng tiền hàng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1757, 156);
            panel1.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(213, 102);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(172, 27);
            txtSDT.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(213, 38);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(172, 27);
            txtTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(56, 101);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // TaoHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1757, 906);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TaoHoaDon";
            Text = "TaoHoaDon";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnHuy;
        private Button btnTao;
        private Button btnThanhToan;
        private Panel panel2;
        private ComboBox cbHTTT;
        private TextBox txtTien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private TextBox txtSDT;
        private TextBox txtTen;
        private Label label2;
        private Label label1;
    }
}