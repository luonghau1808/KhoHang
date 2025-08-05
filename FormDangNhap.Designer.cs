namespace DuAn1_Nhom4
{
    partial class FormDangNhap
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
            label1 = new Label();
            panel2 = new Panel();
            txtPass = new TextBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtUser = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            HienThiMk = new CheckBox();
            lbQuenMatKhau = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 455);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Screenshot_2025_07_08_195922_removebg_preview1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 48);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 8;
            label1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(424, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 37);
            panel2.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(48, 3);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(286, 31);
            txtPass.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.icons8_lock_50;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtUser);
            panel3.Location = new Point(424, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 37);
            panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.icons8_male_user_30;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Location = new Point(51, 3);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(286, 31);
            txtUser.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.DodgerBlue;
            btnDangNhap.Location = new Point(483, 327);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(113, 41);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(645, 327);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 41);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // HienThiMk
            // 
            HienThiMk.AutoSize = true;
            HienThiMk.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HienThiMk.Location = new Point(472, 274);
            HienThiMk.Name = "HienThiMk";
            HienThiMk.Size = new Size(140, 21);
            HienThiMk.TabIndex = 4;
            HienThiMk.Text = "Hiển thị mật khẩu";
            HienThiMk.UseVisualStyleBackColor = true;
            HienThiMk.CheckedChanged += HienThiMk_CheckedChanged;
            // 
            // lbQuenMatKhau
            // 
            lbQuenMatKhau.AutoSize = true;
            lbQuenMatKhau.BackColor = Color.Transparent;
            lbQuenMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuenMatKhau.Location = new Point(696, 412);
            lbQuenMatKhau.Name = "lbQuenMatKhau";
            lbQuenMatKhau.Size = new Size(137, 23);
            lbQuenMatKhau.TabIndex = 5;
            lbQuenMatKhau.Text = "Quên mật khẩu?";
            lbQuenMatKhau.Click += lbQuenMatKhau_Click;
            lbQuenMatKhau.MouseEnter += lbQuenMatKhau_MouseEnter;
            lbQuenMatKhau.MouseLeave += lbQuenMatKhau_MouseLeave;
            // 
            // FormDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(854, 455);
            Controls.Add(lbQuenMatKhau);
            Controls.Add(HienThiMk);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtPass;
        private Panel panel3;
        private TextBox txtUser;
        private PictureBox pictureBox3;
        private Button btnDangNhap;
        private Button btnThoat;
        private CheckBox HienThiMk;
        private Label lbQuenMatKhau;
    }
}