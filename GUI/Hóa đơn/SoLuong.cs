﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom4.GUI
{
    public partial class SoLuong : Form
    {
        public int SoLuongSanPham { get; set; }
        public SoLuong()
        {
            InitializeComponent();
        }

        private void SoLuong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return; // Không làm gì nếu người dùng chọn "No"
            }
            else
            {
                this.Close(); // Đóng form nếu người dùng chọn "Yes"
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtSoluong.Text.Trim());
            if(input <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SoLuongSanPham = input; // Lưu giá trị số lượng vào thuộc tính
            this.Close(); // Đóng form hiện tại
        }

        private void SoLuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
