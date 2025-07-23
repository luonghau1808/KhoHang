namespace DuAn1_Nhom4.GUI
{
    partial class ThuocTinh
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thuộc tính sản phẩm ";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F);
            button4.Image = Properties.Resources.icons8_clean_30;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(996, 206);
            button4.Name = "button4";
            button4.Size = new Size(240, 48);
            button4.TabIndex = 32;
            button4.Text = "Làm mới ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.Image = Properties.Resources.icons8_delete_30;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(678, 206);
            button3.Name = "button3";
            button3.Size = new Size(240, 48);
            button3.TabIndex = 31;
            button3.Text = "Xóa thuộc tính";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.Image = Properties.Resources.icons8_change_24;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(361, 206);
            button2.Name = "button2";
            button2.Size = new Size(240, 48);
            button2.TabIndex = 30;
            button2.Text = "Sửa thuộc tính";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F);
            button1.Image = Properties.Resources.icons8_add_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(37, 206);
            button1.Name = "button1";
            button1.Size = new Size(240, 48);
            button1.TabIndex = 29;
            button1.Text = "Thêm thuộc tính ";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F);
            radioButton2.Location = new Point(974, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Màu sắc ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F);
            radioButton1.Location = new Point(711, 98);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kích thước ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(37, 101);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên thuộc tính";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F);
            textBox1.Location = new Point(210, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 30);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1311, 378);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thuộc tính ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1305, 306);
            dataGridView1.TabIndex = 0;
            // 
            // ThuocTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 706);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ThuocTinh";
            Text = "ThuocTinh";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}