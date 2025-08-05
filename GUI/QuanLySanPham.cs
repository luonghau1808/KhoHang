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
using DuAn1_Nhom4.GUI;
using DuAn1_Nhom4.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn1_Nhom4
{
    public partial class QuanLySanPham : Form
    {
        GenericBLL<ChiTietSanPham> ctspBll = new GenericBLL<ChiTietSanPham>();
        GenericBLL<KichThuoc> ktBll = new GenericBLL<KichThuoc>();
        GenericBLL<Models.MauSac> msBll = new GenericBLL<Models.MauSac>();
        GenericBLL<ThuongHieu> thBll = new GenericBLL<ThuongHieu>();
        GenericBLL<NhaCungCap> nccBll = new GenericBLL<NhaCungCap>();
        public QuanLySanPham()
        {
            InitializeComponent();
            LoadDSSP();
            LoadDsKt();
            LoadDsMs();
            LoadTh();
            LoadKt();
            LoadMs();
            LoadNcc();
            rbConHang.Checked = true;
        }
        #region Tab Thông Tin Sản Phẩm
        private void LoadDSSP()
        {
            var ds = ctspBll.GetAll(x => x.MaSpNavigation.MaNccNavigation, x => x.MaMauNavigation, x => x.MaKichThuocNavigation, x => x.MaSpNavigation.MaThuongHieuNavigation)
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.MaCtsp,
                    x.MaSpNavigation.TenSp,
                    x.DonGiaNhap,
                    x.SoLuong,
                    x.MaKichThuocNavigation?.TenKichThuoc,
                    x.MaSpNavigation.MaThuongHieuNavigation?.TenThuongHieu,
                    TenMau = x.MaMauNavigation?.TenMau,
                    x.MaSpNavigation.MaNccNavigation?.TenNcc,
                    x.MaSpNavigation.TrangThai
                }).ToList();
            dtgThongTinSP.DataSource = ds;
        }

        private void LoadKt()
        {
            var dskt = ktBll.GetAll();
            cbKichThuoc.DataSource = dskt;
            cbKichThuoc.DisplayMember = "TenKichThuoc";
            cbKichThuoc.ValueMember = "MaKichThuoc";
        }

        private void LoadMs()
        {
            var dsMs = msBll.GetAll();
            cbMau.DataSource = dsMs;
            cbMau.DisplayMember = "TenMau";
            cbMau.ValueMember = "MaMau";
        }

        private void LoadTh()
        {
            var dsTh = thBll.GetAll();
            cbTH.DataSource = dsTh;
            cbTH.DisplayMember = "TenThuongHieu";
            cbTH.ValueMember = "MaThuongHieu";
        }

        private void LoadNcc()
        {
            var dsNcc = nccBll.GetAll();
            cbNcc.DataSource = dsNcc;
            cbNcc.DisplayMember = "TenNcc";
            cbNcc.ValueMember = "MaNcc";
        }
        private void Clear()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTim.Clear();
        }
        private void addSp()
        {
            ChiTietSanPham ctsp = new ChiTietSanPham();
            ctsp.MaSpNavigation = new SanPham();
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                !decimal.TryParse(txtDonGia.Text, out decimal donGiaNhap) ||
                !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                return;
            }

            // Kiểm tra trùng tên
            if (ctspBll.Exists(x => x.MaSpNavigation.TenSp.ToLower() == txtTen.Text.ToLower()))
            {
                MessageBox.Show($"Tên này đã tồn tại!");
                return;
            }

            ctsp.MaSpNavigation.TenSp = txtTen.Text.Trim();
            ctsp.DonGiaNhap = donGiaNhap;
            ctsp.SoLuong = soLuong;
            ctsp.MaSpNavigation.MaNcc = Convert.ToInt32(cbNcc.SelectedValue);
            ctsp.MaKichThuoc = Convert.ToInt32(cbKichThuoc.SelectedValue);
            ctsp.MaSpNavigation.MaThuongHieu = Convert.ToInt32(cbTH.SelectedValue);
            ctsp.MaMau = Convert.ToInt32(cbMau.SelectedValue);
            ctsp.MaSpNavigation.TrangThai = rbConHang.Checked ? "Còn hàng" : "Ngừng kinh doanh";

            ctspBll.Add(ctsp);

            LoadDSSP();
            Clear();
            MessageBox.Show($"Thêm thành công!");
        }
        private void deleteSp()
        {
            try
            {
                // Kiểm tra nếu không nhập mã
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!");
                    return;
                }

                int id = int.Parse(txtMa.Text);

                var timId = ctspBll.GetById(id);

                if (timId == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần xóa!");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;

                ctspBll.Delete(id);
                LoadDSSP();
                Clear();

                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void editSp()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!");
                    return;
                }

                int id = int.Parse(txtMa.Text);
                var timId = ctspBll.GetById(id);

                if (timId == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần sửa!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                    !decimal.TryParse(txtDonGia.Text, out decimal donGiaNhap) ||
                    !int.TryParse(txtSoLuong.Text, out int soLuong))
                {
                    MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                    return;
                }

                // Kiểm tra tên đã tồn tại (loại trừ chính mình)
                if (ctspBll.Exists(x => x.MaSpNavigation.TenSp.ToLower() == txtTen.Text.ToLower()))
                {
                    MessageBox.Show("Tên này đã tồn tại!");
                    return;
                }

                // Cập nhật dữ liệu
                timId.MaSpNavigation.TenSp = txtTen.Text.Trim();
                timId.DonGiaNhap = donGiaNhap;
                timId.SoLuong = soLuong;

                // Gán ID, không gán tên
                timId.MaKichThuoc = Convert.ToInt32(cbKichThuoc.SelectedValue);
                timId.MaSpNavigation.MaThuongHieu = Convert.ToInt32(cbTH.SelectedValue);
                timId.MaMau = Convert.ToInt32(cbMau.SelectedValue);
                timId.MaSpNavigation.MaNcc = Convert.ToInt32(cbNcc.SelectedValue);
                timId.MaSpNavigation.TrangThai = rbConHang.Checked ? "Còn hàng" : "Ngừng kinh doanh";

                ctspBll.Update(timId);
                LoadDSSP();
                Clear();

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void findSp()
        {
            string keyword = txtTim.Text.Trim().ToLower();
            var danhSach = ctspBll.GetAll(x => x.MaSpNavigation);

            var ketQua = danhSach.Where(x =>
                x.MaSpNavigation.TenSp.ToLower().Contains(keyword) ||
                x.MaSpNavigation.MaThuongHieuNavigation.TenThuongHieu.ToString().ToLower().Contains(keyword) ||
                x.MaSpNavigation.MaNccNavigation.TenNcc.ToString().ToLower().Contains(keyword)
            ).Select((x, Index) => new
            {
                STT = Index + 1,
                x.MaCtsp,
                x.MaSpNavigation.TenSp,
                x.DonGiaNhap,
                x.SoLuong,
                x.MaKichThuocNavigation?.TenKichThuoc,
                x.MaSpNavigation.MaThuongHieuNavigation?.TenThuongHieu,
                x.MaMauNavigation?.TenMau,
                x.MaSpNavigation.MaNccNavigation.TenNcc,
                x.MaSpNavigation.TrangThai
            }).ToList();

            // Hiển thị lên DataGridView
            dtgThongTinSP.DataSource = ketQua;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addSp();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            editSp();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deleteSp();
        }

        private void dtgThongTinSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtMa.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["MaCtsp"].Value.ToString();
                    txtTen.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["TenSp"].Value.ToString();
                    txtDonGia.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();
                    txtSoLuong.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                    cbKichThuoc.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["TenKichThuoc"].Value.ToString();
                    cbMau.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["TenMau"].Value.ToString();
                    cbTH.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["TenThuongHieu"].Value.ToString();
                    //cbNcc.Text = dtgThongTinSP.Rows[e.RowIndex].Cells["TenNcc"].Value.ToString();

                    // Gán RadioButton theo trạng thái
                    string trangThai = dtgThongTinSP.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

                    if (trangThai == "Còn hàng")
                    {
                        rbConHang.Checked = true;
                    }
                    else if (trangThai == "Ngừng kinh doanh")
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            findSp();
        }
        #endregion
        #region Tab Thuộc Tính Sản Phẩm
        private void LoadDsKt()
        {
            var dsKt = ktBll.GetAll()
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.MaKichThuoc,
                    x.TenKichThuoc
                }).ToList();
            dgvKt.DataSource = dsKt;
        }

        private void LoadDsMs()
        {
            var dsMs = msBll.GetAll()
                .Select((x, Index) => new
                {
                    STT = Index + 1,
                    x.MaMau,
                    x.TenMau
                }).ToList();
            dgvMs.DataSource = dsMs;
        }

        private void Clear2()
        {
            txbKt.Clear();
            txbMs.Clear();
        }

        private void AddKt()
        {
            KichThuoc kt = new KichThuoc();
            kt.TenKichThuoc = txbKt.Text.Trim();

            if (string.IsNullOrWhiteSpace(txbKt.Text))
            {
                MessageBox.Show($"Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (ktBll.Exists(x => x.TenKichThuoc == txbKt.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Tên này đã tồn tại!");
                return;
            }

            ktBll.Add(kt);
            LoadKt();
            Clear2();
            MessageBox.Show($"Thêm thành công!");
        }

        private void AddMs()
        {
            Models.MauSac ms = new Models.MauSac();
            ms.TenMau = txbMs.Text.Trim();
            if (string.IsNullOrWhiteSpace(txbMs.Text))
            {
                MessageBox.Show($"Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (msBll.Exists(x => x.TenMau == txbMs.Text.Trim().ToLower()))
            {
                MessageBox.Show($"Tên này đã tồn tại!");
                return;
            }
            msBll.Add(ms);
            LoadMs();
            Clear2();
            MessageBox.Show($"Thêm thành công!");
        }

        private void editKt()
        {
            if (dgvKt.Rows.Count == 0)
            {
                MessageBox.Show($"Vui lòng chọn dòng cần sửa!");
                return;
            }

            var duLieu = int.Parse(dgvKt.CurrentRow.Cells["MaKichThuoc"].Value.ToString());
            var timDuLieu = ktBll.GetById(duLieu);

            timDuLieu.TenKichThuoc = txbKt.Text.Trim();

            ktBll.Update(timDuLieu);
            LoadDsKt();
            Clear2();
            MessageBox.Show($"Sửa thành công!");
        }

        private void editMs()
        {
            if (dgvMs.Rows.Count == 0)
            {
                MessageBox.Show($"Vui lòng chọn dòng cần sửa!");
                return;
            }

            var duLieu = int.Parse(dgvMs.CurrentRow.Cells["MaMau"].Value.ToString());
            var timDuLieu = msBll.GetById(duLieu);

            timDuLieu.TenMau = txbKt.Text.Trim();

            msBll.Update(timDuLieu);
            LoadDsKt();
            Clear2();
            MessageBox.Show($"Sửa thành công!");
        }

        private void deleteKt()
        {
            if (dgvKt.RowCount == 0)
            {
                MessageBox.Show($"Vui lòng chọn dòng cần xóa!");
                return;
            }
            int maKichThuoc = int.Parse(dgvKt.CurrentRow.Cells["MaKichThuoc"].Value.ToString());
            var timMa = ktBll.GetById(maKichThuoc);

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            ktBll.Delete(maKichThuoc);
            LoadDsKt();

            MessageBox.Show($"Xóa thành công!");
        }

        private void deleteMs()
        {
            if (dgvMs.RowCount == 0)
            {
                MessageBox.Show($"Vui lòng chọn dòng cần xóa!");
                return;
            }
            int ma = int.Parse(dgvMs.CurrentRow.Cells["MaMau"].Value.ToString());
            var timMa = ktBll.GetById(ma);

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            msBll.Delete(ma);
            LoadDsMs();

            MessageBox.Show($"Xóa thành công!");
        }


        #endregion

        private void btnAddKt_Click(object sender, EventArgs e)
        {
            AddKt();
        }

        private void btnEditKt_Click(object sender, EventArgs e)
        {
            editKt();
        }

        private void btnDeleteKt_Click(object sender, EventArgs e)
        {
            deleteKt();
        }

        private void btnAddMs_Click(object sender, EventArgs e)
        {
            AddMs();
        }

        private void btnEditMs_Click(object sender, EventArgs e)
        {
            editMs();
        }

        private void btnDeleteMs_Click(object sender, EventArgs e)
        {
            deleteMs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear2();
        }

        private void dgvKt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txbKt.Text = dgvKt.Rows[e.RowIndex].Cells["TenKichThuoc"].Value.ToString();
            }
        }

        private void dgvMs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                txbMs.Text = dgvMs.Rows[e.RowIndex].Cells["TenMau"].Value.ToString();
            }
        }
    }
}
