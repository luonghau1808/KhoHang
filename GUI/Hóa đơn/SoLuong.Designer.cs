namespace DuAn1_Nhom4.GUI
{
    partial class SoLuong
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
            txtSoluong = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Location = new Point(94, 70);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(389, 27);
            txtSoluong.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập số lượng";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(308, 130);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(130, 35);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(444, 130);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 3;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SoLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 177);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtSoluong);
            Name = "SoLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoLuong";
            FormClosing += SoLuong_FormClosing;
            Load += SoLuong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoluong;
        private Label label1;
        private Button btnSubmit;
        private Button button1;
    }
}