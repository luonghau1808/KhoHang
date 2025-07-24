namespace DuAn1_Nhom4.GUI
{
    partial class DonDatHang
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
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnHoanTra = new Button();
            btnTrangThai = new Button();
            btnGiaoHang = new Button();
            btnTaoHoaDon = new Button();
            label8 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            cbHTTT = new ComboBox();
            txtTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1295, 119);
            panel1.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F);
            txtSDT.Location = new Point(213, 87);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(172, 30);
            txtSDT.TabIndex = 3;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Font = new Font("Segoe UI", 10.2F);
            txtTenKH.Location = new Point(213, 23);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(172, 30);
            txtTenKH.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(56, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(cbHTTT);
            panel2.Controls.Add(txtTien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 789);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHoanTra);
            panel3.Controls.Add(btnTrangThai);
            panel3.Controls.Add(btnGiaoHang);
            panel3.Controls.Add(btnTaoHoaDon);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(1295, 283);
            panel3.TabIndex = 11;
            // 
            // btnHoanTra
            // 
            btnHoanTra.Image = Properties.Resources.icons8_delete_301;
            btnHoanTra.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoanTra.Location = new Point(56, 191);
            btnHoanTra.Name = "btnHoanTra";
            btnHoanTra.Size = new Size(389, 61);
            btnHoanTra.TabIndex = 3;
            btnHoanTra.Text = "Hoàn trả";
            btnHoanTra.UseVisualStyleBackColor = true;
            // 
            // btnTrangThai
            // 
            btnTrangThai.Image = Properties.Resources.icons8_shopify_301;
            btnTrangThai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangThai.Location = new Point(278, 117);
            btnTrangThai.Name = "btnTrangThai";
            btnTrangThai.Size = new Size(167, 52);
            btnTrangThai.TabIndex = 2;
            btnTrangThai.Text = "Đã giao";
            btnTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnGiaoHang
            // 
            btnGiaoHang.Image = Properties.Resources.icons8_delivery_time_301;
            btnGiaoHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiaoHang.Location = new Point(56, 117);
            btnGiaoHang.Name = "btnGiaoHang";
            btnGiaoHang.Size = new Size(178, 52);
            btnGiaoHang.TabIndex = 1;
            btnGiaoHang.Text = "Giao hàng";
            btnGiaoHang.UseVisualStyleBackColor = true;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Image = Properties.Resources.icons8_dollar_bag_30;
            btnTaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.Location = new Point(54, 27);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(396, 61);
            btnTaoHoaDon.TabIndex = 0;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(56, 146);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 10;
            label8.Text = "Khách cần trả: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(56, 377);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 9;
            label9.Text = "Ghi chú:";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10.2F);
            richTextBox1.Location = new Point(56, 423);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(394, 77);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // cbHTTT
            // 
            cbHTTT.FormattingEnabled = true;
            cbHTTT.Location = new Point(278, 196);
            cbHTTT.Name = "cbHTTT";
            cbHTTT.Size = new Size(172, 28);
            cbHTTT.TabIndex = 5;
            // 
            // txtTien
            // 
            txtTien.BorderStyle = BorderStyle.FixedSingle;
            txtTien.Location = new Point(278, 266);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(172, 27);
            txtTien.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(54, 325);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 4;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(56, 266);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 3;
            label6.Text = "Tiền khách đưa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(54, 201);
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
            label4.Size = new Size(87, 23);
            label4.TabIndex = 1;
            label4.Text = "Tiền ship: ";
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
            // DonDatHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 908);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DonDatHang";
            Text = "DonDatHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox1;
        private ComboBox cbHTTT;
        private TextBox txtTien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button btnHoanTra;
        private Button btnTrangThai;
        private Button btnGiaoHang;
        private Button btnTaoHoaDon;
    }
}