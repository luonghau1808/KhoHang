using System.Data;
using System.Security.Cryptography;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI
{
    public partial class PhieuXuatF : Form
    {
        private GenericBLL<ChiTietSanPham> _ctSanphamBLL = new GenericBLL<ChiTietSanPham>();
        private GenericBLL<PhieuXuat> _phieuXuatBLL = new GenericBLL<PhieuXuat>();
        private GenericBLL<PhieuXuatChiTiet> _ctPhieuXuatBLL = new GenericBLL<PhieuXuatChiTiet>();
        decimal _tongTien = 0;
        public PhieuXuatF()
        {
            InitializeComponent();
        }

        private void LoadSanPham()
        {
            var list = _ctSanphamBLL.GetAll(x => x.MaSpNavigation, x => x.MaMauNavigation, x => x.MaKichThuocNavigation);
            dtgDanhSachSP.DataSource = list.Select((sp, index) => new
            {
                STT = index + 1,
                MaSP = sp.MaCtsp,
                TenSP = sp.MaSpNavigation.TenSp,
                MauSac = sp.MaMauNavigation?.TenMau,
                KichThuoc = sp.MaKichThuocNavigation?.TenKichThuoc,
                SoLuong = sp.SoLuong,
                DonGiaNhap = sp.DonGiaNhap,
                DonGiaXuat = sp.DonGiaXuat

            }).ToList();
        }

        private void LoadPhieuXuat()
        {
            _tongTien = TinhTongTien();
            var list = _phieuXuatBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation).Where(x => x.TrangThaiThanhToan != "Đã thanh toán");
            dtgDanhSachHD.DataSource = list.Select((px, index) => new
            {
                STT = index + 1,
                MaPX = px.MaPhieuXuat,
                TenKH = px.MaKhNavigation.Ten,
                TenNV = px.MaNvNavigation.HoTen,
                NgayXuat = px.NgayXuat,
                TrangThai = px.TrangThaiThanhToan,
            }).ToList();
            lbTongtienhd.Text = "Tổng tiền: " + TinhTongTien().ToString(); // Cập nhật tổng tiền của hóa đơn
        }


        private void LoadCTPX(int maPX)
        {
            var list = _ctPhieuXuatBLL.GetAll(
                x => x.MaCtspNavigation.MaSpNavigation,
                x => x.MaCtspNavigation.MaMauNavigation,
                x => x.MaCtspNavigation.MaKichThuocNavigation,
                x => x.MaPhieuXuatNavigation)
                .Where(x => x.MaPhieuXuat == maPX)
                .ToList();

            dtgGioHang.DataSource = list.Select((ct, index) => new
            {
                STT = index + 1,
                MaCT = ct.MaCt,
                TenSP = ct.MaCtspNavigation?.MaSpNavigation?.TenSp ?? "",
                MauSac = ct.MaCtspNavigation?.MaMauNavigation?.TenMau ?? "",
                KichThuoc = ct.MaCtspNavigation?.MaKichThuocNavigation?.TenKichThuoc ?? "",
                SoLuong = ct.SoLuong,
                DonGia = ct.MaCtspNavigation?.DonGiaXuat ?? 0,
                ThanhTien = ct.SoLuong * (ct.MaCtspNavigation?.DonGiaXuat ?? 0)
            }).ToList();

            lbTongtienhd.Text = "Tổng tiền: " + TinhTongTien().ToString(); // Cập nhật tổng tiền của hóa đơn

        }


        private decimal TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            return tongTien;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dtgDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; // Không có hàng nào được chọn
            }
            int maPx = Convert.ToInt32(dtgDanhSachHD.Rows[e.RowIndex].Cells[1].Value);
            dtgDanhSachHD.ClearSelection();
            LoadCTPX(maPx);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadPhieuXuat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sp = dtgDanhSachSP.CurrentRow.Cells["MaSP"].Value;
            var px = dtgDanhSachHD.CurrentRow.Cells["MaPX"].Value;
            var donGia = dtgDanhSachSP.CurrentRow.Cells["DonGiaXuat"].Value;
            var soLuong = 0;
            SoLuong soLuongForm = new SoLuong();
            soLuongForm.ShowDialog();
            soLuong = soLuongForm.SoLuongSanPham;

            var ctpx = new PhieuXuatChiTiet
            {
                MaCtsp = (int)sp,
                GiaBan = (decimal)donGia,
                SoLuong = soLuong,
                MaPhieuXuat = (int)px // Chưa có mã phiếu xuất, sẽ cập nhật sau khi tạo phiếu xuất
            };

            // Kiểm tra số lượng sản phẩm có đủ không
            var ctSanPham = _ctSanphamBLL.GetById(ctpx.MaCtsp);
            if (ctSanPham.SoLuong < soLuong)
            {
                MessageBox.Show("Số lượng sản phẩm không đủ để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm vào giỏ hàng nếu số lượng không đủ
            }
            else
            {
                ctSanPham.SoLuong -= soLuong; // Giảm số lượng sản phẩm trong kho
                _ctSanphamBLL.Update(ctSanPham); // Cập nhật số lượng sản phẩm trong kho
                _ctPhieuXuatBLL.Add(ctpx);
                LoadSanPham();
                LoadCTPX((int)px); // Cập nhật giỏ hàng

            }


        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var main = new FormMain();
            var nhanVien = main.NhanVien;

            var phieuXuat = new PhieuXuat()
            {
                MaKh = 1,
                MaNv = nhanVien.Id,
                NgayXuat = DateOnly.FromDateTime(DateTime.Now),
                TrangThaiThanhToan = "Chưa thanh toán",
            };
        }
    }
}
