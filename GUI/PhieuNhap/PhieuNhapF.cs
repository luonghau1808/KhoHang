using System.Data;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    public partial class PhieuNhapF : Form
    {

        private GenericBLL<ChiTietPhieuNhap> phieuNhapCtBLL;
        private GenericBLL<ChiTietSanPham> sanPhamBLL;
        private GenericBLL<PhieuNhap> phieuNhapBLL;
        decimal _tongTien = 0;
        private int maPN = 0;
        private int maCT = 0; // thêm biến toàn cục để lưu mã chi tiết sản phẩm
        private string trangThaiThanhToan = "Chưa thanh toán";
        private NhanVien _nhanVien;
        public PhieuNhapF(NhanVien nhanVien)
        {
            InitializeComponent();
            phieuNhapBLL = new GenericBLL<PhieuNhap>();
            phieuNhapCtBLL = new GenericBLL<ChiTietPhieuNhap>();
            sanPhamBLL = new GenericBLL<ChiTietSanPham>();
            _nhanVien = nhanVien;
        }

        private void LoadTrangThaiThanhToan()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Tất cả");
            cbTrangThai.Items.Add("Đã thanh toán");
            cbTrangThai.Items.Add("Chưa thanh toán");
            cbTrangThai.Items.Add("Đã hủy");
            cbTrangThai.Text = trangThaiThanhToan;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadTrangThaiThanhToan();
        }
        private void LoadPhieuNhap()
        {
            var list = phieuNhapBLL.GetAll(x => x.MaNvNavigation);


            if (trangThaiThanhToan != "Tất cả")
            {
                list = list.Where(x => x.TrangThaiThanhToan == trangThaiThanhToan);
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
            dgvDanhSachPhieuNhap.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
            dgvDanhSachPhieuNhap.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvDanhSachPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvDanhSachPhieuNhap.Columns["TrangThai"].HeaderText = "Trạng thái";


        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0) return;
            string columnName = "";
            // Get the name of the clicked column
            try
            {
                columnName = dgvGioHang.Columns[e.ColumnIndex].Name;
            }
            catch (Exception)
            {

            }
            // Get the ID of the selected row (e.g., MaCT is the key)
            maCT = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["MaCT"].Value);
        }

        private void dgvDanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row
            if (e.RowIndex < 0) return;
            var row = dgvDanhSachPhieuNhap.Rows[e.RowIndex];
            var ma = row.Cells["MaPN"].Value.ToString() ?? "0";
            maPN = int.Parse(ma);
            var phieuNhap = phieuNhapBLL.GetById(maPN);
            btnHuyPhieu.Enabled = !(phieuNhap.TrangThaiThanhToan == "Đã hủy" || phieuNhap.TrangThaiThanhToan == "Đã thanh toán");
            btnThayDoiSoLuong.Enabled = !(phieuNhap.TrangThaiThanhToan == "Đã hủy" || phieuNhap.TrangThaiThanhToan == "Đã thanh toán");
            btnXoaSanPham.Enabled = !(phieuNhap.TrangThaiThanhToan == "Đã hủy" || phieuNhap.TrangThaiThanhToan == "Đã thanh toán");
            btnThem.Enabled = !(phieuNhap.TrangThaiThanhToan == "Đã hủy" || phieuNhap.TrangThaiThanhToan == "Đã thanh toán");
            btnThanhToan.Enabled = !(phieuNhap.TrangThaiThanhToan == "Đã hủy" || phieuNhap.TrangThaiThanhToan == "Đã thanh toán");
            if (phieuNhap == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập.");
                return;
            }
            string columnName = "";

            // Get the name of the clicked column
            try
            {
                columnName = dgvDanhSachPhieuNhap.Columns[e.ColumnIndex].Name;
            }
            catch (Exception)
            {

            }

            LoadCTPN(maPN);
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

            // 6. Tổng tiền
            _tongTien = list.Sum(x => x.SoLuong * (x.MaCtspNavigation?.DonGiaNhap ?? 1));
            lbTongTien.Text = "Tổng tiền: " + _tongTien.ToString("N0") + " VNĐ";

            dgvGioHang.Columns["MaCT"].HeaderText = "Mã chi tiết";
            dgvGioHang.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvGioHang.Columns["MauSac"].HeaderText = "Màu sắc";
            dgvGioHang.Columns["KichThuoc"].HeaderText = "Kích thước";
            dgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn phiếu nhập chưa
            if (maPN == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy phiếu nhập hiện tại
            var phieuNhap = phieuNhapBLL.GetById(maPN);
            if (phieuNhap == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Nếu hợp lệ thì mở form thêm sản phẩm
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
            var phieuNhap = phieuNhapBLL.GetById(maPN);
            if (phieuNhap == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập.");
                return;
            }
            DialogResult result = MessageBox.Show(
                 "Bạn có chắc muốn hoàn thành thanh toán?",
                 "Xác nhận hoàn thành",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var chiTiets = phieuNhapCtBLL.GetAll().Where(x => x.MaPhieuNhap == maPN);

                foreach (var chiTiet in chiTiets)
                {
                    var chiTietSanPham = sanPhamBLL.GetById(chiTiet.MaCtsp);
                    if (chiTietSanPham == null) continue;

                    chiTietSanPham.SoLuong += chiTiet.SoLuong;
                    sanPhamBLL.Update(chiTietSanPham);
                }

                phieuNhap.TrangThaiThanhToan = "Đã thanh toán";
                phieuNhapBLL.Update(phieuNhap);

                MessageBox.Show("Hoàn thành thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            trangThaiThanhToan = "Chưa thanh toán";
            cbTrangThai.SelectedItem = "Chưa thanh toán";

            LoadPhieuNhap();

            // Lấy mã phiếu vừa thêm (lớn nhất trong danh sách chưa thanh toán)
            var danhSach = phieuNhapBLL
                .GetAll()
                .Where(x => x.TrangThaiThanhToan == "Chưa thanh toán")
                .ToList();

            maPN = danhSach.Max(x => x.MaPhieuNhap);
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangThaiThanhToan = cbTrangThai!.SelectedItem!.ToString()!;
            LoadPhieuNhap();
            maPN = 0;

            dgvGioHang.DataSource = null;
            dgvGioHang.Columns.Clear();

            //btnThem.Enabled = (trangThaiThanhToan == "Chưa thanh toán");
        }
        private void btnThayDoiSoLuong_Click(object sender, EventArgs e)
        {
            if (maCT == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvGioHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ct = phieuNhapCtBLL.GetById(maCT);
            if (ct == null) return;

            var phieuNhap = phieuNhapBLL.GetById(ct.MaPhieuNhap); // Giả sử ct có MaPn

            PhieuNhapSoLuong frm = new PhieuNhapSoLuong(ct.SoLuong);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ct.SoLuong = frm.SoLuongMoi;
                phieuNhapCtBLL.Update(ct);
                MessageBox.Show("Cập nhật thành công.");
                LoadCTPN(maPN);
            }
        }
        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (maCT == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ct = phieuNhapCtBLL.GetById(maCT);
            if (ct == null) return;
            var phieuNhap = phieuNhapBLL.GetById(ct.MaPhieuNhap);

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
                maCT = 0; // reset sau khi xóa
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
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
                dgvGioHang.Columns.Clear();
            }
        }
    }
}
