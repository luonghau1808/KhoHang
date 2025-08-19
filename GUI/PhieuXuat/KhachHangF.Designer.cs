namespace DuAn1_Nhom4.GUI.Hóa_đơn
{
    partial class KhachHangF
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
            tabPage1 = new TabPage();
            btnXacNhan = new Button();
            txtTk = new TextBox();
            label2 = new Label();
            dtgKH = new DataGridView();
            tabPage2 = new TabPage();
            btnLamMoi = new Button();
            btnThem = new Button();
            label6 = new Label();
            txtDiachi = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSdt = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKH).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 441);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnXacNhan);
            tabPage1.Controls.Add(txtTk);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dtgKH);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(801, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.Image = Properties.Resources.icons8_tick_30;
            btnXacNhan.ImageAlign = ContentAlignment.MiddleLeft;
            btnXacNhan.Location = new Point(542, 40);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(135, 36);
            btnXacNhan.TabIndex = 8;
            btnXacNhan.Text = "OK";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtTk
            // 
            txtTk.BorderStyle = BorderStyle.FixedSingle;
            txtTk.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtTk.Location = new Point(187, 40);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(305, 30);
            txtTk.TabIndex = 7;
            txtTk.TextChanged += txtTk_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(42, 42);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            // 
            // dtgKH
            // 
            dtgKH.AllowUserToAddRows = false;
            dtgKH.AllowUserToDeleteRows = false;
            dtgKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKH.Dock = DockStyle.Bottom;
            dtgKH.Location = new Point(3, 135);
            dtgKH.MultiSelect = false;
            dtgKH.Name = "dtgKH";
            dtgKH.ReadOnly = true;
            dtgKH.RowHeadersWidth = 51;
            dtgKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgKH.Size = new Size(795, 267);
            dtgKH.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLamMoi);
            tabPage2.Controls.Add(btnThem);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtDiachi);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtSdt);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtTen);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(801, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thêm khách hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLamMoi.Image = Properties.Resources.icons8_replace_30;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(446, 305);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(196, 39);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.icons8_add_user_male_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(180, 305);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(196, 39);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(237, 35);
            label6.Name = "label6";
            label6.Size = new Size(297, 31);
            label6.TabIndex = 8;
            label6.Text = "Nhập thông tin khách hàng";
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Location = new Point(534, 221);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(223, 30);
            txtDiachi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(446, 221);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(153, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 30);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(67, 221);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Location = new Point(534, 130);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(223, 30);
            txtSdt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(404, 130);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(153, 125);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(223, 30);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(16, 125);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // KhachHangF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 441);
            Controls.Add(tabControl1);
            Name = "KhachHangF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Khách hàng";
            Load += KhachHangF_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKH).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnXacNhan;
        private TextBox txtTk;
        private Label label2;
        private DataGridView dtgKH;
        private TextBox txtTen;
        private Label label1;
        private Label label6;
        private TextBox txtDiachi;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSdt;
        private Label label3;
        private Button btnLamMoi;
        private Button btnThem;
    }
}