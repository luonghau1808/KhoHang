namespace DuAn1_Nhom4.GUI
{
    partial class FormLichSu
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
            richTextBox1 = new RichTextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            dgvPhieu = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            dgvCt = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            btnTk = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1087, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 912);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(51, 576);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(243, 95);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(51, 515);
            label12.Name = "label12";
            label12.Size = new Size(87, 23);
            label12.TabIndex = 8;
            label12.Text = "Lý do hủy:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(50, 174);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 7;
            label11.Text = "Tên khách hàng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(50, 398);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 6;
            label10.Text = "Tổng tiền: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(50, 455);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 5;
            label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(50, 336);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 4;
            label8.Text = "Ngày tạo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(50, 281);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 3;
            label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(50, 227);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 2;
            label6.Text = "Số điện thoại: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(50, 121);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 1;
            label5.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(50, 64);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã nhân viên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTk);
            groupBox1.Controls.Add(dgvPhieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1087, 551);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử hoạt động";
            // 
            // dgvPhieu
            // 
            dgvPhieu.AllowUserToAddRows = false;
            dgvPhieu.AllowUserToDeleteRows = false;
            dgvPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieu.Dock = DockStyle.Bottom;
            dgvPhieu.Location = new Point(3, 183);
            dgvPhieu.MultiSelect = false;
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.ReadOnly = true;
            dgvPhieu.RowHeadersWidth = 51;
            dgvPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieu.Size = new Size(1081, 365);
            dgvPhieu.TabIndex = 6;
            dgvPhieu.CellClick += dgvPhieu_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(698, 75);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 75);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Loại phiếu";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(798, 75);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(180, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(494, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCt);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 551);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1087, 361);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvCt
            // 
            dgvCt.AllowUserToAddRows = false;
            dgvCt.AllowUserToDeleteRows = false;
            dgvCt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCt.Dock = DockStyle.Fill;
            dgvCt.Location = new Point(3, 23);
            dgvCt.MultiSelect = false;
            dgvCt.Name = "dgvCt";
            dgvCt.ReadOnly = true;
            dgvCt.RowHeadersWidth = 51;
            dgvCt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCt.Size = new Size(1081, 335);
            dgvCt.TabIndex = 7;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(884, 121);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(111, 40);
            btnTk.TabIndex = 7;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // FormLichSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 912);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormLichSu";
            Text = "FormLichSu";
            Load += FormLichSu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvPhieu;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private DataGridView dgvCt;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label12;
        private Label label11;
        private Button btnTk;
    }
}