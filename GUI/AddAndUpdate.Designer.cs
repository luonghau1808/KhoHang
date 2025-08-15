namespace DuAn1_Nhom4.GUI
{
    partial class AddAndUpdate
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
            btnLuu = new Button();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            txtTenNCC = new TextBox();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1014, 359);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.icons8_download_from_the_cloud_30;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(406, 279);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(293, 49);
            btnLuu.TabIndex = 30;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10.2F);
            txtDiaChi.Location = new Point(687, 131);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(284, 30);
            txtDiaChi.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(590, 133);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 28;
            label5.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(687, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 30);
            txtEmail.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(601, 72);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F);
            txtSDT.Location = new Point(196, 200);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(307, 30);
            txtSDT.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(51, 202);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 24;
            label3.Text = "Số điện thoại";
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderStyle = BorderStyle.FixedSingle;
            txtTenNCC.Font = new Font("Segoe UI", 10.2F);
            txtTenNCC.Location = new Point(196, 138);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(307, 30);
            txtTenNCC.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(18, 138);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 22;
            label2.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            txtMaNCC.BorderStyle = BorderStyle.FixedSingle;
            txtMaNCC.Font = new Font("Segoe UI", 10.2F);
            txtMaNCC.Location = new Point(196, 79);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(307, 30);
            txtMaNCC.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(18, 81);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 20;
            label1.Text = "Mã nhà cung cấp";
            // 
            // AddAndUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 359);
            Controls.Add(groupBox1);
            Name = "AddAndUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAndUpdate";
          
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLuu;
        private TextBox txtDiaChi;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtTenNCC;
        private Label label2;
        private TextBox txtMaNCC;
        private Label label1;
    }
}