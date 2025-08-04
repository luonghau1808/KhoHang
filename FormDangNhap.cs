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
using DuAn1_Nhom4.DAL;
using DuAn1_Nhom4.GUI;
using DuAn1_Nhom4.Models;


namespace DuAn1_Nhom4
{
    public partial class FormDangNhap : Form
    {
        GenericDAL<TaiKhoanNhanVien> taiKhoanBLL = new GenericDAL<TaiKhoanNhanVien>(new QuanLyKhoHangQuanAoContext());
        GenericBLL<NhanVien> nhanVienBLL = new GenericBLL<NhanVien>();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void lbQuenMatKhau_MouseEnter(object sender, EventArgs e)
        {

            lbQuenMatKhau.BackColor = Color.LightBlue;
            lbQuenMatKhau.Cursor = Cursors.Hand;
        }

        private void lbQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lbQuenMatKhau.BackColor = Color.Transparent;
            lbQuenMatKhau.Cursor = Cursors.Default;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string tenTk = txtUser.Text;
                string matKhau = txtPass.Text;
                var taiKhoan = taiKhoanBLL.GetAllAccount(tk => tk.NhanVien, tk => tk.NhanVien.MaChucVuNavigation)
                               .FirstOrDefault(tk => tk.TenDangNhap == tenTk);

                if (taiKhoan != null)
                {
                    if (taiKhoan.MatKhau.Equals(matKhau))
                    {
                        var nhanvien = nhanVienBLL.GetById(taiKhoan.NhanVienId);
                        string hoTen = taiKhoan.NhanVien.HoTen;
                        string chucVu = taiKhoan.NhanVien.MaChucVuNavigation?.TenChucVu ?? "Không rõ";
                        MessageBox.Show($"Xin chào {hoTen} ({chucVu})", "Đăng nhập thành công");
                        this.Hide();

                        var formMain = new FormMain();
                        formMain.NhanVien = nhanvien;
                        formMain.ShowDialog();

                        // Sau khi đóng FormMain, hiển thị lại FormDangNhap nếu cần
                        this.txtPass.Clear();
                       
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void HienThiMk_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = HienThiMk.Checked ? '\0' : '*';
        }
        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhauF quenMatKhauF = new QuenMatKhauF();
            this.Hide(); // Ẩn form đăng nhập hiện tại
            quenMatKhauF.ShowDialog();
            this.Show(); // Hiển thị lại form đăng nhập sau khi đóng form quên mật khẩu

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser; // Đặt focus vào ô nhập tài khoản khi form được tải
        }
    }
}

