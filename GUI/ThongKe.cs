using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1_Nhom4.Models;
namespace DuAn1_Nhom4.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private void LoadThongTinTongQuan()
        {
            using (var db = new QuanLyKhoHangQuanAoContext())
            {
                // Tổng phiếu xuất
                int tongPhieuXuat = db.PhieuXuats.Count();

                // Tổng phiếu nhập
                int tongPhieuNhap = db.PhieuNhaps.Count();

                // Tổng số lượng tồn kho (tổng tất cả số lượng còn trong ChiTietSanPham)
                int tongSoLuongTonKho = db.ChiTietSanPhams.Sum(ct => ct.SoLuong);

                // Tổng số khách hàng
                int tongKhachHang = db.KhachHangs.Count();

                // Gán vào các Label
                lblTongPhieuXuat.Text = tongPhieuXuat.ToString();
                lblTongPhieuNhap.Text = tongPhieuNhap.ToString();
                lblTonKho.Text = tongSoLuongTonKho.ToString();
                lblKhachHang.Text = tongKhachHang.ToString();
            }
        }
        private void LoadTongDoanhThu()
        {
            using (var db = new QuanLyKhoHangQuanAoContext())
            {
                var tongDoanhThu = db.PhieuXuatChiTiets
                    .Sum(ct => ct.SoLuong * ct.GiaBan);

                lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ"; // Định dạng tiền VNĐ
            }
        }
        private List<NhanVienThongKeDTO> LayDanhSachThongKeNhanVien()
        {
            using (var db = new QuanLyKhoHangQuanAoContext())
            {
                var query = from tk in db.TaiKhoanNhanViens
                            join nv in db.NhanViens on tk.NhanVienId equals nv.Id
                            join px in db.PhieuXuats on nv.Id equals px.MaNv into pxGroup
                            select new NhanVienThongKeDTO
                            {
                                TenDangNhap = tk.TenDangNhap,
                                SoDonTiepNhan = pxGroup.Count(),
                                SoDonThanhToan = pxGroup.Count(p => p.TrangThaiThanhToan == "Đã thanh toán"),
                                TongDoanhThu = pxGroup
                                    .SelectMany(p => p.PhieuXuatChiTiets)
                                    .Sum(ct => (decimal?)ct.SoLuong * ct.GiaBan) ?? 0
                            };

                return query.ToList();
            }
        }
        private void HienThiDuLieu(List<NhanVienThongKeDTO> data)
        {
            dgvNhanVien.DataSource = data.Select((nv, index) => new
            {
                STT = index + 1,
                nv.TenDangNhap,
                nv.SoDonTiepNhan,
                nv.SoDonThanhToan,
                DoanhThu = nv.TongDoanhThu.ToString("N0") + " đ"
            }).ToList();
        }
        private void LoadDoanhThuMacDinh()
        {
            DateOnly tuNgay = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
            DateOnly denNgay = DateOnly.FromDateTime(DateTime.Today);

            using (var db = new QuanLyKhoHangQuanAoContext())
            {
                var phieuXuatTrongKhoang = db.PhieuXuats
                    .Where(p => p.NgayXuat >= tuNgay && p.NgayXuat <= denNgay)
                    .ToList();

                int soDonHang = phieuXuatTrongKhoang.Count;

                int soKhachHang = phieuXuatTrongKhoang
                    .Select(p => p.MaKh)
                    .Distinct()
                    .Count();

                var chiTietPhieu = phieuXuatTrongKhoang
                    .SelectMany(p => db.PhieuXuatChiTiets.Where(ct => ct.MaPhieuXuat == p.MaPhieuXuat))
                    .ToList();

                decimal doanhThu = chiTietPhieu.Sum(ct => ct.SoLuong * ct.GiaBan);

                dgvDoanhThu.DataSource = new List<DoanhThuDTO>
        {
            new DoanhThuDTO
            {
                ThoiGian = $"{tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy}",
                SoKhachHang = soKhachHang,
                SoDonHang = soDonHang,
                DoanhThu = doanhThu
            }
        };

                // Định dạng doanh thu
                dgvDoanhThu.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadThongTinTongQuan();
            LoadTongDoanhThu();
            LoadDoanhThuMacDinh();

            cmbBoLocNhanVien.Items.Add("Nhân viên có đơn nhiều nhất");
            cmbBoLocNhanVien.Items.Add("Nhân viên có doanh thu cao nhất");
            cmbBoLocNhanVien.SelectedIndex = 0;
            var danhSach = LayDanhSachThongKeNhanVien();
            HienThiDuLieu(danhSach);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateOnly tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            DateOnly denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new QuanLyKhoHangQuanAoContext())
            {
                // Lọc phiếu xuất trong khoảng thời gian đã chọn
                var phieuXuatTrongKhoang = db.PhieuXuats
                    .Where(p => p.NgayXuat >= tuNgay && p.NgayXuat <= denNgay)
                    .ToList();

                // Đếm số đơn hàng
                int soDonHang = phieuXuatTrongKhoang.Count;

                // Đếm số lượng khách hàng khác nhau
                int soKhachHang = phieuXuatTrongKhoang
                    .Select(p => p.MaKh)
                    .Distinct()
                    .Count();

                // Tính tổng doanh thu từ chi tiết phiếu xuất
                var chiTietPhieu = phieuXuatTrongKhoang
                            .SelectMany(p => db.PhieuXuatChiTiets.Where(ct => ct.MaPhieuXuat == p.MaPhieuXuat))
                            .ToList();

                // Tính doanh thu
                decimal doanhThu = chiTietPhieu.Sum(ct => ct.SoLuong * ct.GiaBan);

                // Đưa lên DataGridView
                dgvDoanhThu.DataSource = new List<DoanhThuDTO>
        {
            new DoanhThuDTO
            {
                ThoiGian = $"{tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy}",
                SoKhachHang = soKhachHang,
                SoDonHang = soDonHang,
                DoanhThu = doanhThu
            }
        };
            }
        }

        private void cmbBoLocNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var danhSach = LayDanhSachThongKeNhanVien();

            string luaChon = cmbBoLocNhanVien.SelectedItem.ToString();

            if (luaChon == "Nhân viên có đơn nhiều nhất")
            {
                var top = danhSach.OrderByDescending(x => x.SoDonTiepNhan).Take(10).ToList();
                HienThiDuLieu(top);
            }
            else if (luaChon == "Nhân viên có doanh thu cao nhất")
            {
                var top = danhSach.OrderByDescending(x => x.TongDoanhThu).Take(10).ToList();
                HienThiDuLieu(top);
            }
        }

        private void lblTongPhieuXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
