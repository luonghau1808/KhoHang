using System.Data;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    public partial class PhieuNhapF : Form
    {
        
        private GenericBLL<ChiTietPhieuNhap> phieuNhapCtBLL;
        private GenericBLL<PhieuNhap> phieuNhapBLL;
        decimal _tongTien = 0;
        private int maPN = 0;
        private string trangThaiThanhToan = "Chưa thanh toán";
        private NhanVien _nhanVien;
        public PhieuNhapF(NhanVien nhanVien)
        {
            InitializeComponent();
            phieuNhapBLL = new GenericBLL<PhieuNhap>();
            phieuNhapCtBLL = new GenericBLL<ChiTietPhieuNhap>();
            _nhanVien = nhanVien;
        }

        private void LoadTrangThaiThanhToan()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Tất cả");
            cbTrangThai.Items.Add("Đã thanh toán");
            cbTrangThai.Items.Add("Chưa thanh toán");
            cbTrangThai.Items.Add("Đã hủy");

            cbTrangThai.SelectedIndex = 0; // Mặc định là "Tất cả"
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadTrangThaiThanhToan();
        } 
        private void LoadPhieuNhap()
        {
            var list = phieuNhapBLL.GetAll(x => x.MaNvNavigation).Where(x => x.TrangThaiThanhToan == trangThaiThanhToan);
            dgvDanhSachPhieuNhap.Columns.Clear();

            dgvDanhSachPhieuNhap.DataSource = list.Select((px, index) => new
            {
                STT = index + 1,
                MaPN = px.MaPhieuNhap,
                TenNV = px.MaNvNavigation.HoTen,
                NgayNhap = px.NgayNhap.ToString("dd/MM/yyyy"),
                TrangThai = px.TrangThaiThanhToan
            }).ToList();

            // 5. Add Delete button
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.HeaderText = "Hủy phiếu";
            deleteBtn.Text = "Hủy";
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Name = "btnDelete";
            dgvDanhSachPhieuNhap.Columns.Add(deleteBtn);
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0) return;

            // Get the name of the clicked column
            string columnName = dgvGioHang.Columns[e.ColumnIndex].Name;

            // Get the ID of the selected row (e.g., MaCT is the key)
            int maCT = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["MaCT"].Value);

            if (columnName == "btnEdit")
            {
                EditSoLuong(maCT);
            }
            else if (columnName == "btnDelete")
            {
                DeletePhieuNhapCT(maCT);
            }
        }

        private void dgvDanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0) return;
            var row = dgvDanhSachPhieuNhap.Rows[e.RowIndex];
            var ma = row.Cells["MaPN"].Value.ToString();
            var phieuNhap = phieuNhapBLL.GetById(maPN);

            maPN = int.Parse(ma ?? "0");
            LoadCTPN(maPN);

            // Get the name of the clicked column
            string columnName = dgvDanhSachPhieuNhap.Columns[e.ColumnIndex].Name;
            if (columnName == "btnDelete")
            {
                if (phieuNhap.TrangThaiThanhToan == "Đã thanh toán")
                {
                    MessageBox.Show("Phiếu đã thanh toán, không được hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                HuyPhieuNhap(maPN);
            }

        }
        public void HuyPhieuNhap(int maPN)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy phiếu nhập này hay không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                var phieuNhap = phieuNhapBLL.GetById(maPN);

                phieuNhap!.TrangThaiThanhToan = "Đã hủy";
                phieuNhapBLL.Update(phieuNhap);

                MessageBox.Show("Hủy thành công.");
                LoadPhieuNhap();

                dgvGioHang.DataSource = null;
            }

        }
        private void LoadCTPN(int maPX)
        {
            // 1. Get list
            var list = phieuNhapCtBLL.GetAll(
                   x => x.MaCtspNavigation.MaSpNavigation,
                   x => x.MaCtspNavigation.MaMauNavigation!,
                   x => x.MaCtspNavigation.MaKichThuocNavigation!,
                   x => x.MaCtspNavigation.MaSpNavigation!,
                   x => x.MaPhieuNhapNavigation)
                   .Where(x => x.MaPhieuNhap == maPX)
                   .ToList();

            // 2. Clear old columns
            dgvGioHang.Columns.Clear();

            // 3. Set DataSource
            dgvGioHang.DataSource = list.Select((ct, index) => new
            {
                STT = index + 1,
                MaCT = ct.MaPhieuCt,
                TenSP = ct.MaCtspNavigation?.MaSpNavigation?.TenSp ?? "",
                MauSac = ct.MaCtspNavigation?.MaMauNavigation?.TenMau ?? "",
                KichThuoc = ct.MaCtspNavigation?.MaKichThuocNavigation?.TenKichThuoc ?? "",
                SoLuong = ct.SoLuong,
                DonGia = ct.MaCtspNavigation?.DonGiaNhap.ToString("N0") + "đ",
                ThanhTien = (ct.SoLuong * (ct.MaCtspNavigation?.DonGiaNhap ?? 0)).ToString("N0") + "đ"
            }).ToList();

            // 4. Add Edit button
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.HeaderText = "Sửa";
            editBtn.Text = "Sửa";
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Name = "btnEdit";
            dgvGioHang.Columns.Add(editBtn);

            // 5. Add Delete button
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.HeaderText = "Xóa";
            deleteBtn.Text = "Xóa";
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Name = "btnDelete";
            dgvGioHang.Columns.Add(deleteBtn);

            // 6. Tổng tiền
            _tongTien = list.Sum(x => x.SoLuong * (x.MaCtspNavigation?.DonGiaNhap ?? 1));
            lbTongTien.Text = "Tổng tiền: " + _tongTien.ToString("N0") + " VNĐ";


        }

        private void EditSoLuong(int maCT)
        {

            if (dgvGioHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ct = phieuNhapCtBLL.GetById(maCT);
            if (ct == null) return;

            PhieuNhapSoLuong frm = new PhieuNhapSoLuong(ct.SoLuong);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ct.SoLuong = frm.SoLuongMoi;
                phieuNhapCtBLL.Update(ct);
                MessageBox.Show("Cập nhật thành công.");
                LoadCTPN(maPN);
            }
        }

        private void DeletePhieuNhapCT(int maCT)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa mặt hàng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                phieuNhapCtBLL.Delete(maCT);
                MessageBox.Show("Xóa thành công.");
                LoadCTPN(maPN);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamF formSpham = new SanPhamF(this);
            var result = formSpham.ShowDialog();
        }

        public void ThemGioHang(int maCtsp, int soLuong, decimal donGia)
        {
            phieuNhapCtBLL.Add(new ChiTietPhieuNhap()
            {
                MaPhieuNhap = maPN,
                MaCtsp = maCtsp,
                SoLuong = soLuong,
                DonGia = donGia,
            });

            LoadCTPN(maPN);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hoàn thành thanh toán?",
                "Xác nhận hoàn thành",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var phieuNhap = phieuNhapBLL.GetById(maPN);

                phieuNhap!.TrangThaiThanhToan = "Đã thanh toán";
                phieuNhapBLL.Update(phieuNhap);

                MessageBox.Show("Hoàn thành thanh toán thành công.");
                LoadPhieuNhap();
            }

        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {

            var phieuMoi = new PhieuNhap
            {
                NgayNhap = DateOnly.FromDateTime(DateTime.Now),
                TrangThaiThanhToan = "Chưa thanh toán",
                MaNv = _nhanVien.Id
            };
            phieuNhapBLL.Add(phieuMoi);
            MessageBox.Show("Thêm phiếu nhập thành công.");

            LoadPhieuNhap();

            // Cập nhật lại maPN hiện tại
            var danhSach = phieuNhapBLL.GetAll();
            maPN = danhSach.Max(x => x.MaPhieuNhap);
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbTrangThai.SelectedItem.ToString();

            var list = phieuNhapBLL.GetAll(x => x.MaNvNavigation);

            if (trangThai != "Tất cả")
            {
                list = list.Where(p => p.TrangThaiThanhToan == trangThai).ToList();
            }

            dgvDanhSachPhieuNhap.Columns.Clear();
            dgvDanhSachPhieuNhap.DataSource = list.Select((px, index) => new
            {
                STT = index + 1,
                MaPN = px.MaPhieuNhap,
                TenNV = px.MaNvNavigation.HoTen,
                NgayNhap = px.NgayNhap.ToString("dd/MM/yyyy"),
                TrangThai = px.TrangThaiThanhToan
            }).ToList();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.HeaderText = "Hủy phiếu";
            deleteBtn.Text = "Hủy";
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Name = "btnDelete";
            dgvDanhSachPhieuNhap.Columns.Add(deleteBtn);
        }

        private void dgvDanhSachPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
