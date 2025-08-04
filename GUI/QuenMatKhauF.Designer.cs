namespace DuAn1_Nhom4.GUI
{
    partial class QuenMatKhauF
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
            pictureBox1 = new PictureBox();
            lbQuenMatKhau = new Label();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtOTP = new TextBox();
            lbOTP = new Label();
            txtMkmoi = new TextBox();
            lbMkmoi = new Label();
            txtMkxacNhan = new TextBox();
            lbMkxacNhan = new Label();
            btnXacnhan = new Button();
            btnEmail = new Button();
            btnOTP = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 408);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Screenshot_2025_07_08_195922_removebg_preview1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbQuenMatKhau
            // 
            lbQuenMatKhau.AutoSize = true;
            lbQuenMatKhau.BackColor = Color.Transparent;
            lbQuenMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuenMatKhau.Location = new Point(680, 412);
            lbQuenMatKhau.Name = "lbQuenMatKhau";
            lbQuenMatKhau.Size = new Size(137, 23);
            lbQuenMatKhau.TabIndex = 14;
            lbQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(499, 40);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 16;
            label1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 17;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(525, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtOTP
            // 
            txtOTP.BorderStyle = BorderStyle.FixedSingle;
            txtOTP.Location = new Point(525, 164);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(234, 27);
            txtOTP.TabIndex = 20;
            txtOTP.Visible = false;
            // 
            // lbOTP
            // 
            lbOTP.AutoSize = true;
            lbOTP.Location = new Point(459, 171);
            lbOTP.Name = "lbOTP";
            lbOTP.Size = new Size(60, 20);
            lbOTP.TabIndex = 19;
            lbOTP.Text = "Mã OTP";
            lbOTP.Visible = false;
            // 
            // txtMkmoi
            // 
            txtMkmoi.BorderStyle = BorderStyle.FixedSingle;
            txtMkmoi.Location = new Point(525, 220);
            txtMkmoi.Name = "txtMkmoi";
            txtMkmoi.Size = new Size(234, 27);
            txtMkmoi.TabIndex = 22;
            txtMkmoi.Visible = false;
            // 
            // lbMkmoi
            // 
            lbMkmoi.AutoSize = true;
            lbMkmoi.Location = new Point(419, 222);
            lbMkmoi.Name = "lbMkmoi";
            lbMkmoi.Size = new Size(100, 20);
            lbMkmoi.TabIndex = 21;
            lbMkmoi.Text = "Mật khẩu mới";
            lbMkmoi.Visible = false;
            // 
            // txtMkxacNhan
            // 
            txtMkxacNhan.BorderStyle = BorderStyle.FixedSingle;
            txtMkxacNhan.Location = new Point(525, 274);
            txtMkxacNhan.Name = "txtMkxacNhan";
            txtMkxacNhan.Size = new Size(234, 27);
            txtMkxacNhan.TabIndex = 24;
            txtMkxacNhan.Visible = false;
            // 
            // lbMkxacNhan
            // 
            lbMkxacNhan.AutoSize = true;
            lbMkxacNhan.Location = new Point(385, 274);
            lbMkxacNhan.Name = "lbMkxacNhan";
            lbMkxacNhan.Size = new Size(134, 20);
            lbMkxacNhan.TabIndex = 23;
            lbMkxacNhan.Text = "Xác nhận mật khẩu";
            lbMkxacNhan.Visible = false;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(709, 332);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(94, 29);
            btnXacnhan.TabIndex = 25;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Visible = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(766, 110);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(58, 27);
            btnEmail.TabIndex = 26;
            btnEmail.Text = "Gửi";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // btnOTP
            // 
            btnOTP.Location = new Point(766, 163);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(58, 28);
            btnOTP.TabIndex = 27;
            btnOTP.Text = "OK";
            btnOTP.UseVisualStyleBackColor = true;
            btnOTP.Visible = false;
            btnOTP.Click += btnOTP_Click;
            // 
            // QuenMatKhauF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 408);
            Controls.Add(btnOTP);
            Controls.Add(btnEmail);
            Controls.Add(btnXacnhan);
            Controls.Add(txtMkxacNhan);
            Controls.Add(lbMkxacNhan);
            Controls.Add(txtMkmoi);
            Controls.Add(lbMkmoi);
            Controls.Add(txtOTP);
            Controls.Add(lbOTP);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lbQuenMatKhau);
            Name = "QuenMatKhauF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuenMatKhauF";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbQuenMatKhau;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtOTP;
        private Label lbOTP;
        private TextBox txtMkmoi;
        private Label lbMkmoi;
        private TextBox txtMkxacNhan;
        private Label lbMkxacNhan;
        private Button btnXacnhan;
        private Button btnEmail;
        private Button btnOTP;
    }
}