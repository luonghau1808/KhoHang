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
    public partial class TaiKhoanF : Form
    {
        NhanVien _NhanVien;
        GenericBLL<TaiKhoanNhanVien> _tkBLL = new GenericBLL<TaiKhoanNhanVien>();
        GenericBLL<ChucVu> _chucVuBLL = new GenericBLL<ChucVu>();
        public TaiKhoanF(NhanVien nhanVien)
        {
            InitializeComponent();
            _NhanVien = nhanVien;
        }
        private void LoadNhanVien()
        {
            var tk = _tkBLL.GetAll().FirstOrDefault(x => x.Id == _NhanVien.Id);
            var chucVu = _chucVuBLL.GetById((int)_NhanVien.MaChucVu);
            var capChar = CapChar();
            txtMa.Text = _NhanVien.Id.ToString();
            txtHoTen.Text = _NhanVien.HoTen;
            txtSDT.Text = _NhanVien.SoDienThoai;
            txtEmail.Text = _NhanVien.Email;
            txtChucVu.Text = chucVu.TenChucVu;
            txtTenDangNhap.Text = tk.TenDangNhap;
            lbcapchar.Text = capChar;

        }
        private string CapChar(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void TaiKhoanF_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text == txtXacNhan.Text)
            {
                var tk = _tkBLL.GetAll().FirstOrDefault(x => x.Id == _NhanVien.Id);
                if (tk != null)
                {
                    if(txtMkCu.Text != tk.MatKhau)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, vui lòng nhập lại.");
                        return;
                    }
                    tk.MatKhau = txtMKMoi.Text;
                    _tkBLL.Update(tk);
                    MessageBox.Show("Cập nhật mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản của nhân viên này.");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại.");
            }
            ResetFields();
        }
        private void ResetFields()
        {
            txtMKMoi.Clear();
            txtMkCu.Clear();
            txtXacNhan.Clear();
        }

    }
}
