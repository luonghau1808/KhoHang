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
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(762, 403);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnXacNhan);
            tabPage1.Controls.Add(txtTk);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dtgKH);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(754, 370);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(542, 20);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 8;
            btnXacNhan.Text = "OK";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtTk
            // 
            txtTk.BorderStyle = BorderStyle.FixedSingle;
            txtTk.Location = new Point(145, 20);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(305, 27);
            txtTk.TabIndex = 7;
            txtTk.TextChanged += txtTk_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 22);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
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
            dtgKH.Location = new Point(3, 100);
            dtgKH.MultiSelect = false;
            dtgKH.Name = "dtgKH";
            dtgKH.ReadOnly = true;
            dtgKH.RowHeadersWidth = 51;
            dtgKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgKH.Size = new Size(748, 267);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(754, 370);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thêm khách hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(602, 305);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(481, 305);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(237, 35);
            label6.Name = "label6";
            label6.Size = new Size(294, 31);
            label6.TabIndex = 8;
            label6.Text = "Nhập thông tin khách hàng";
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Location = new Point(507, 219);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(223, 27);
            txtDiachi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 221);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(133, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 221);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Location = new Point(507, 128);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(223, 27);
            txtSdt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 130);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(133, 123);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(223, 27);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 125);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // KhachHangF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 403);
            Controls.Add(tabControl1);
            Name = "KhachHangF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
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