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
using System.Text.RegularExpressions;

namespace DuAn1_Nhom4.GUI
{
    public partial class QuanLyNhanVien : Form
    {
        GenericBLL<NhanVien> nvBll = new GenericBLL<NhanVien>();
        GenericBLL<ChucVu> cvBll = new GenericBLL<ChucVu>();
        GenericBLL<TaiKhoanNhanVien> tkBll = new GenericBLL<TaiKhoanNhanVien>();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadDsNv();
            LoadDsTk();
            LoadCv();
            rbHD.Checked = true;
        }
        #region Tab Thông Tin Nhân Viên
        private void LoadDsNv()
        {
            var dsnv = nvBll.GetAll(x => x.MaChucVuNavigation)
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.Id,
                    x.HoTen,
                    x.SoDienThoai,
                    x.Email,
                    x.MaChucVuNavigation?.TenChucVu,
                }).ToList();
            dataGridView1.DataSource = dsnv;
        }

        private void LoadCv()
        {
            var dsCv = cvBll.GetAll();
            cbVaiTro.DataSource = dsCv;
            cbVaiTro.DisplayMember = "TenChucVu";
            cbVaiTro.ValueMember = "MaChucVu";
        }

        private void clear()
        {
            txbMa.Clear();
            txbHoTen.Clear();
            txbSDT.Clear();
            txbEmail.Clear();
            txbTim.Clear();
        }

        private void addNv()
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = txbHoTen.Text.Trim();
            nv.SoDienThoai = txbSDT.Text.Trim();
            nv.Email = txbEmail.Text.Trim();
            nv.MaChucVu = Convert.ToInt32(cbVaiTro.SelectedValue);

            if (string.IsNullOrWhiteSpace(txbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbSDT.Text) || !txbSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text) || !txbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.");
                return;
            }
            if (!txbEmail.Text.Trim().EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải kết thúc bằng @gmail.com", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBll.Exists(x => x.SoDienThoai == txbSDT.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Số điện thoại đã tồn tại!");
                return;
            }
            if (nvBll.Exists(x => x.Email == txbEmail.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Email đã tồn tại!");
                return;
            }
            if (!Regex.IsMatch(txbSDT.Text.Trim(), @"^0\d{8,}$"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và chỉ chứa chữ số (ít nhất 9 số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nvBll.Add(nv);
            LoadDsNv();
            clear();

            MessageBox.Show($"Thêm thành công!");
        }

        private void editNv()
        {
            if (string.IsNullOrWhiteSpace(txbMa.Text))
            {
                MessageBox.Show($"Vui lòng chọn dòng cần sửa!");
                return;
            }

            var ma = int.Parse(txbMa.Text);
            var timMa = nvBll.GetById(ma);
            timMa.HoTen = txbHoTen.Text.Trim();
            timMa.SoDienThoai = txbSDT.Text.Trim();
            timMa.Email = txbEmail.Text.Trim();
            timMa.MaChucVu = Convert.ToInt32(cbVaiTro.SelectedValue);

            if (string.IsNullOrWhiteSpace(txbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbSDT.Text) || !txbSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text) || !txbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.");
                return;
            }
            if (!txbEmail.Text.Trim().EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải kết thúc bằng @gmail.com", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBll.Exists(x => x.SoDienThoai == txbSDT.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Số điện thoại đã tồn tại!");
                return;
            }
            if (nvBll.Exists(x => x.Email == txbEmail.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Email đã tồn tại!");
                return;
            }
            if (!Regex.IsMatch(txbSDT.Text.Trim(), @"^0\d{8,}$"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và chỉ chứa chữ số (ít nhất 9 số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nvBll.Update(timMa);
            LoadDsNv();
            clear();

            MessageBox.Show($"Sửa thành công!");
        }

        private void deletenv()
        {
            if (string.IsNullOrWhiteSpace(txbMa.Text))
            {
                MessageBox.Show($"Vui lòng chọn dòng cần xóa!");
            }

            var ma = int.Parse(txbMa.Text);
            var timMa = nvBll.GetById(ma);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            nvBll.Delete(timMa.Id);
            LoadDsNv();
            clear();

            MessageBox.Show($"Xóa thành công!");
        }

        private void findNv()
        {
            string duLieu = txbTim.Text.Trim().ToLower();
            var timDl = nvBll.GetAll(x => x.MaChucVuNavigation).Where(x =>
                        x.HoTen.Contains(duLieu) ||
                        x.SoDienThoai.ToString().Contains(duLieu) ||
                        x.Email.Contains(duLieu) ||
                        x.MaChucVuNavigation.TenChucVu.Contains(duLieu))
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.Id,
                    x.HoTen,
                    x.SoDienThoai,
                    x.Email,
                    x.MaChucVuNavigation?.TenChucVu,
                }).ToList();
            dataGridView1.DataSource = timDl;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txbMa.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    txbHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                    txbSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                    txbEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    cbVaiTro.Text = dataGridView1.Rows[e.RowIndex].Cells["TenChucVu"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editNv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletenv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            findNv();
        }

        #endregion
        #region Tab Tài Khoản Nhân Viên

        private void LoadDsTk()
        {
            var dsTk = tkBll.GetAll(x => x.NhanVien)
             .Select((x, Index) => new
             {
                 STT = Index + 1,
                 x.Id,
                 x.NhanVienId,
                 x.NhanVien.HoTen,
                 x.TenDangNhap,
                 x.MatKhau,
                 x.TrangThai
             }).ToList();
            dtgDanhSach.DataSource = dsTk;
        }

        private void Clear2()
        {
            txbMaTk.Clear();
            txbTenNv.Clear();
            txbTenDangNhap.Clear();
            txbMk1.Clear();
            txbTimTk.Clear();
        }

        private void AddTk()
        {
            TaiKhoanNhanVien tk = new TaiKhoanNhanVien();
            tk.NhanVienId = int.Parse(txbTenNv.Text);
            tk.TenDangNhap = txbTenDangNhap.Text;
            tk.MatKhau = txbMk.Text;
            tk.TrangThai = rbHD.Checked ? "Đang Hoạt Động" : "Ngừng Hoạt Động";

            if (tkBll.Exists(x => x.NhanVienId.ToString() == txbTenNv.Text.ToLower()))
            {
                MessageBox.Show($"Nhân viên đã có tài khoản");
                return;
            }
            var nhanVien = nvBll.GetById(int.Parse(txbTenNv.Text));
            if (nhanVien == null)
            {
                MessageBox.Show("Nhân viên này chưa tồn tại trong hệ thống!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txbTenNv.Text) ||
            string.IsNullOrWhiteSpace(txbTenDangNhap.Text) ||
            string.IsNullOrWhiteSpace(txbMk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                return;
            }
            if (tkBll.Exists(x => x.TenDangNhap == txbTenDangNhap.Text.ToLower()))
            {
                MessageBox.Show($"Tên tài khoản đã tồn tại!");
                return;
            }

            tkBll.Add(tk);
            LoadDsTk();
            Clear2();

            MessageBox.Show($"Thêm thành công!");
        }

        private void deleteTk()
        {
            if (string.IsNullOrEmpty(txbMaTk.Text))
            {
                MessageBox.Show($"Vui lòng chọn tài khoản cần xóa!");
                return;
            }
            var ma = int.Parse(txbMaTk.Text);
            var timMa = tkBll.GetById(ma);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            tkBll.Delete(timMa.Id);
            LoadDsTk();
            Clear2();

            MessageBox.Show($"Xóa thành công!");
        }

        private void editTk()
        {
            if (string.IsNullOrEmpty(txbMaTk.Text))
            {
                MessageBox.Show($"Vui lòng chọn tài khoản cần sửa!");
                return;
            }

            var ma = int.Parse(txbMaTk.Text);
            var timMa = tkBll.GetById(ma);

            timMa.NhanVienId = int.Parse(txbTenNv.Text);
            timMa.TenDangNhap = txbTenDangNhap.Text;
            timMa.MatKhau = txbMk.Text;
            timMa.TrangThai = rbHD.Checked ? "Đang Hoạt Động" : "Ngừng Hoạt Động";

            if (tkBll.Exists(x => x.NhanVienId.ToString() == txbTenNv.Text.ToLower()))
            {
                MessageBox.Show($"Nhân viên đã có tài khoản");
                return;
            }
            var nhanVien = nvBll.GetAll().FirstOrDefault(nv => nv.HoTen.Trim().ToLower() == txbTenNv.Text.ToLower());

            if (nhanVien == null)
            {
                MessageBox.Show("Nhân viên này chưa tồn tại trong hệ thống!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txbTenNv.Text) ||
            string.IsNullOrWhiteSpace(txbTenDangNhap.Text) ||
            string.IsNullOrWhiteSpace(txbMk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                return;
            }
            if (tkBll.Exists(x => x.TenDangNhap == txbTenDangNhap.Text.ToLower()))
            {
                MessageBox.Show($"Tên tài khoản đã tồn tại!");
                return;
            }

            tkBll.Update(timMa);
            LoadDsTk();
            Clear2();

            MessageBox.Show($"Sửa thành công!");
        }

        private void findTk()
        {
            var duLieu = txbTimTk.Text.Trim().ToLower();
            var ds = tkBll.GetAll()
                .Where(x =>
                x.NhanVien.HoTen.Contains(duLieu) ||
                x.TenDangNhap.Contains(duLieu))
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.Id,
                    x.NhanVien.HoTen,
                    x.TenDangNhap,
                    x.MatKhau,
                    x.TrangThai
                }).ToList();
        }


        #endregion

        private void dtgDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txbMaTk.Text = dtgDanhSach.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    txbTenNv.Text = dtgDanhSach.Rows[e.RowIndex].Cells["NhanVienId"].Value.ToString();
                    txbTenDangNhap.Text = dtgDanhSach.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                    txbMk1.Text = dtgDanhSach.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                    string trangThai = dtgDanhSach.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

                    if (trangThai == "Đang Hoạt Động")
                    {
                        rbHD.Checked = true;
                    }
                    else if (trangThai == "Ngừng Hoạt Động")
                    {
                        rbNgung.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddTk();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            editTk();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deleteTk();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear2();
        }

        private void txbTimTk_TextChanged(object sender, EventArgs e)
        {
            findTk();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}