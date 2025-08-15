using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom4.GUI
{
    public partial class QuanLyNCC : Form
    {
        GenericBLL<NhaCungCap> nhaCungCapBAL;
        public QuanLyNCC()
        {
            InitializeComponent();
            nhaCungCapBAL = new GenericBLL<NhaCungCap>();
        }
        private void LoadNCC()
        {
            var danhSachNCC = nhaCungCapBAL.GetAll();
            dtgDanhSachNCC.DataSource = danhSachNCC;

            dtgDanhSachNCC.Columns["MaNcc"].HeaderText = "Mã nhà cung cấp";
            dtgDanhSachNCC.Columns["TenNcc"].HeaderText = "Tên nhà cung cấp";
            dtgDanhSachNCC.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgDanhSachNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgDanhSachNCC.Columns["Email"].HeaderText = "Email";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show( "Bạn có chắc chắn muốn thêm nhà cung cấp mới không?","Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (result != DialogResult.Yes) return;
            AddAndUpdate form = new AddAndUpdate(null);
            form.ShowDialog();
            LoadNCC();
            ClearForm();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra có chọn dòng hay chưa
            if (dtgDanhSachNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy Mã NCC từ dòng đang chọn
            var maNCC = dtgDanhSachNCC.SelectedRows[0].Cells["MaNcc"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(maNCC))
            {
                MessageBox.Show("Không tìm thấy mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu NCC từ DB
            var ncc = nhaCungCapBAL.GetAll().FirstOrDefault(n => n.MaNcc.ToString() == maNCC);
            if (ncc == null)
            {
                MessageBox.Show("Nhà cung cấp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhà cung cấp không?","Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (result != DialogResult.Yes) return;
            // Mở form cập nhật
            AddAndUpdate form = new AddAndUpdate(ncc);
            form.ShowDialog();
            LoadNCC();
            ClearForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNCC();
            ClearForm();

        }
        private void dtgDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dtgDanhSachNCC.Rows[e.RowIndex];
            txtMaNCC.Text = row.Cells["MaNcc"].Value.ToString();
            txtTenNCC.Text = row.Cells["TenNcc"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();

        }
        private void QuanLyNCC_Load(object sender, EventArgs e)
        {
            LoadNCC();
            ClearForm();
        }
        private void ClearForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim().ToLower();

            var ketQua = nhaCungCapBAL.GetAll()
               .Where(ncc =>
                    ncc.TenNcc.ToLower().Contains(tuKhoa)  // tìm theo tên                   
                )
                .ToList();

            dtgDanhSachNCC.DataSource = ketQua;

        }


    }
}
