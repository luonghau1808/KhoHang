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
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var ncc = new NhaCungCap
            {
                TenNcc = txtTenNCC.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                SoDienThoai = txtSDT.Text
            };
            nhaCungCapBAL.Add(ncc);
            LoadNCC();
            ClearForm();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (!int.TryParse(txtMaNCC.Text, out int id)) return;
            var ncc = nhaCungCapBAL.GetById(id);
            if (ncc == null) return;
            ncc.TenNcc = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.Email = txtEmail.Text;
            ncc.SoDienThoai = txtSDT.Text;

            nhaCungCapBAL.Update(ncc);
            LoadNCC();
            ClearForm();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNCC.Text, out int id)) return;
            var a = MessageBox.Show("Bạn có chắc chắn muốn xoá nhà cung cấp này không ?", "Xác nhận",
                 MessageBoxButtons.YesNo);
            if (a != DialogResult.Yes) return;
            nhaCungCapBAL.Delete(id);
            LoadNCC();
            ClearForm();
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool CheckSDT(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            try
            {
                long.Parse(phone);
            }
            catch
            {
                return false;
            }
            return phone.Length >= 9 && phone.Length <= 11;
        }
        private bool CheckEmail(string email)
        {
            return email.Contains("@") && email.Contains(".") && email.Length >= 6;
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (!CheckSDT(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            if (!CheckEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim().ToLower();

            var ketQua = nhaCungCapBAL.GetAll()
               .Where(ncc =>
             ncc.TenNcc.ToLower().Contains(tuKhoa) ||
             ncc.Email.ToLower().Contains(tuKhoa) ||
             (ncc.DiaChi != null && ncc.DiaChi.ToLower().Contains(tuKhoa))
         )
         .ToList();

            dtgDanhSachNCC.DataSource = ketQua;
        }
    }
}
