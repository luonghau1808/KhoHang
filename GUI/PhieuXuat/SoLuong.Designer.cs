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
            SuspendLayout();
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSoluong.Location = new Point(94, 70);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(389, 30);
            txtSoluong.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(94, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 1;
            label1.Text = "Nhập số lượng";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSubmit.Image = Properties.Resources.icons8_tick_301;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(369, 130);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(114, 35);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // SoLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 177);
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
    }
}