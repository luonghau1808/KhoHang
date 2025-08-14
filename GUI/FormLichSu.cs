using System.Data;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI
{
    public partial class FormLichSu : Form
    {
        private GenericBLL<PhieuXuat> _pxBLL = new GenericBLL<PhieuXuat>();
        private GenericBLL<PhieuNhap> _pnBLL = new GenericBLL<PhieuNhap>();
        private GenericBLL<ChiTietPhieuNhap> _ctpn = new GenericBLL<ChiTietPhieuNhap>();
        private GenericBLL<PhieuXuatChiTiet> _ctpx = new GenericBLL<PhieuXuatChiTiet>();
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void LoadCB()
        {
            comboBox1.Items.Add("Phiếu nhập");
            comboBox1.Items.Add("Phiếu xuất");
            comboBox1.SelectedIndex = 0; // Mặc định chọn Phiếu nhập

            cbTrangthai.Items.Add("Tất cả");
            cbTrangthai.Items.Add("Chưa thanh toán");
            cbTrangthai.Items.Add("Đã thanh toán");
            cbTrangthai.Items.Add("Đã hủy");
            cbTrangthai.SelectedIndex = 0; // Mặc định chọn Tất cả


            cbNgayloc.Items.Add("Tất cả");
            cbNgayloc.Items.Add("Khoảng thời gian");
            cbNgayloc.SelectedIndex = 0; // Mặc định chọn Tất cả

        }
        private void FormLichSu_Load(object sender, EventArgs e)
        {
            LoadCB();
            ApplyFilters(); // Gọi hàm lọc khi form được tải
            if (dgvPhieu.Rows.Count >= 0)
            {
                dgvPhieu.ClearSelection(); // Xóa lựa chọn cũ trong DataGridView phiếu
                dgvPhieu_CellClick(dgvPhieu, new DataGridViewCellEventArgs(0, 0)); // Gọi sự kiện click để hiển thị chi tiết
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbTrangthai.SelectedItem = "Tất cả"; // Đặt lại trạng thái về "Tất cả" khi thay đổi loại phiếu
            ApplyFilters(); // Gọi hàm lọc khi thay đổi loại phiếu
            dgvCt.DataSource = null; // Xóa dữ liệu cũ trong DataGridView chi tiết
            if (dgvPhieu.Rows.Count > 0)
            {
                dgvPhieu.ClearSelection();
                dgvPhieu.Rows[0].Selected = true;

                dgvPhieu_CellClick(dgvPhieu, new DataGridViewCellEventArgs(0, 0));
            }
        }
        private void LoadCTPX(int maPX)
        {
            var list = _ctpx.GetAll(
                x => x.MaCtspNavigation.MaSpNavigation,
                x => x.MaCtspNavigation.MaMauNavigation,
                x => x.MaCtspNavigation.MaKichThuocNavigation,
                x => x.MaPhieuXuatNavigation)
                .Where(x => x.MaPhieuXuat == maPX)
                .ToList();

            dgvCt.DataSource = list.Select((ct, index) => new
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

            dgvCt.Columns["STT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["MaCT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["TenSP"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["MauSac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["KichThuoc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["ThanhTien"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvCt.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["MaCT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



        }

        private void LoadCTPN(int maPN)
        {
            var list = _ctpn.GetAll(
               x => x.MaCtspNavigation.MaSpNavigation,
               x => x.MaCtspNavigation.MaMauNavigation,
               x => x.MaCtspNavigation.MaKichThuocNavigation,
               x => x.MaPhieuNhapNavigation)
               .Where(x => x.MaPhieuNhap == maPN)
               .ToList();
            dgvCt.DataSource = list.Select((ctpn, index) => new
            {
                STT = index + 1,
                MaCTPN = ctpn.MaPhieuNhap,
                TenSp = ctpn.MaCtspNavigation.MaSpNavigation.TenSp,
                SoLuong = ctpn.SoLuong,
                DonGia = ctpn.DonGia,
                ThanhTien = ctpn.SoLuong * ctpn.DonGia
            }).ToList();

            dgvCt.Columns["STT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["MaCTPN"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["TenSp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["SoLuong"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["ThanhTien"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvCt.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCt.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCt.Columns["MaCTPN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (e.RowIndex < 0)
                    return;

                if (comboBox1.SelectedIndex == 0) // Phiếu Nhập
                {
                    int maPN = Convert.ToInt32(dgvPhieu.Rows[e.RowIndex].Cells["MaPN"].Value);
                    var pn = _pnBLL.GetById(maPN);
                    if (pn != null)
                    {
                        LoadCTPN(maPN);

                        labelMaNV.Text = "Mã nhân viên: " + pn.MaNvNavigation?.Id;
                        labelTenNV.Text = "Tên nhân viên: " + pn.MaNvNavigation?.HoTen;
                        labelNgayTao.Text = "Ngày tạo: " + pn.NgayNhap.ToString("dd/MM/yyyy");
                        labelTrangThai.Text = "Trạng thái: " + pn.TrangThaiThanhToan;

                        var tongTien = _ctpn.GetAll().Where(x => x.MaPhieuNhap == maPN)
                            .Sum(x => x.SoLuong * x.DonGia);
                        labelTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
                    }
                }

            }
            else
            {
                if (e.RowIndex < 0)
                {
                    return; // Không có hàng nào được chọn
                }
                var px = _pxBLL.GetById(Convert.ToInt32(dgvPhieu.Rows[e.RowIndex].Cells["MaPX"].Value));
                if (px != null)
                {
                    LoadCTPX(px.MaPhieuXuat);
                    labelMaNV.Text = "Mã khách hàng: " + px.MaKhNavigation?.MaKh;
                    labelTenNV.Text = "Tên khách hàng: " + px.MaKhNavigation?.Ten;
                    labelNgayTao.Text = "Ngày xuất: " + px.NgayXuat.ToString();
                    labelTrangThai.Text = "Trạng thái: " + px.TrangThaiThanhToan;

                    var tongtien = _ctpx.GetAll()
                        .Where(x => x.MaPhieuXuat == px.MaPhieuXuat)
                        .Sum(x => x.SoLuong * (x.MaCtspNavigation?.DonGiaXuat ?? 0));
                    labelTongTien.Text = "Tổng tiền: " + tongtien.ToString("N0") + " VNĐ";

                }

            }
        }


        private void btnTk_Click(object sender, EventArgs e)
        {

            ApplyFilters(); // Gọi hàm lọc khi nhấn nút tìm kiếm
        }

        private void cbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {


            ApplyFilters(); // Gọi hàm lọc khi thay đổi trạng thái
        }

        private void ApplyFilters()
        {
            // Lấy giá trị từ các control
            string loaiPhieu = comboBox1.Text;
            string trangThai = cbTrangthai.Text;

            // Lấy trạng thái của combobox ngày lọc
            int ngayLocIndex = cbNgayloc.SelectedIndex;

            // Khai báo biến cho ngày, sẽ dùng sau
            DateOnly tuNgay = DateOnly.FromDateTime(DateTime.MinValue);
            DateOnly denNgay = DateOnly.FromDateTime(DateTime.MaxValue);

            if (ngayLocIndex == 1) // "Khoảng thời gian"
            {
                tuNgay = DateOnly.FromDateTime(dateTimePicker1.Value.Date);
                denNgay = DateOnly.FromDateTime(dateTimePicker2.Value.Date);

                // Kiểm tra khoảng ngày có hợp lệ không
                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            // --- Lọc theo Loại phiếu ---
            if (loaiPhieu == "Phiếu nhập")
            {
                var query = _pnBLL.GetAll(x => x.MaNvNavigation);

                // Áp dụng bộ lọc trạng thái
                if (trangThai != "Tất cả")
                {
                    query = query.Where(pn => pn.TrangThaiThanhToan == trangThai);
                }

                // Áp dụng bộ lọc ngày tháng (chỉ khi người dùng chọn "Khoảng thời gian")
                if (ngayLocIndex == 1)
                {
                    query = query.Where(pn => pn.NgayNhap >= tuNgay && pn.NgayNhap <= denNgay);
                }

                // Hiển thị kết quả
                dgvPhieu.DataSource = query.Select((pn, index) => new
                {
                    STT = index + 1,
                    MaPN = pn.MaPhieuNhap,
                    TenNV = pn.MaNvNavigation.HoTen,
                    NgayNhap = pn.NgayNhap,
                    TrangThaiPN = pn.TrangThaiThanhToan
                }).ToList();

                dgvPhieu.Columns["STT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["MaPN"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["TenNV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["NgayNhap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["TrangThaiPN"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dgvPhieu.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["MaPN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPhieu.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            }
            else if (loaiPhieu == "Phiếu xuất")
            {
                var query = _pxBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation);

                // Áp dụng bộ lọc trạng thái
                if (trangThai != "Tất cả")
                {
                    query = query.Where(px => px.TrangThaiThanhToan == trangThai);
                }

                // Áp dụng bộ lọc ngày tháng (chỉ khi người dùng chọn "Khoảng thời gian")
                if (ngayLocIndex == 1)
                {
                    query = query.Where(px => px.NgayXuat >= tuNgay && px.NgayXuat <= denNgay);
                }

                // Hiển thị kết quả
                dgvPhieu.DataSource = query.Select((px, index) => new
                {
                    STT = index + 1,
                    MaPX = px.MaPhieuXuat,
                    TenKH = px.MaKhNavigation.Ten,
                    TenNV = px.MaNvNavigation.HoTen,
                    NgayXuat = px.NgayXuat,
                    TrangThaiPX = px.TrangThaiThanhToan
                }).ToList();


                dgvPhieu.Columns["STT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["MaPX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["TenKH"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["NgayXuat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["TrangThaiPX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvPhieu.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieu.Columns["MaPX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPhieu.Columns["NgayXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void cbNgayloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNgayloc.SelectedIndex == 0) // "Tất cả"
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                btnTk.Visible = false;
                lbDenngay.Visible = false;
                lbTungay.Visible = false;

            }
            else // "Khoảng thời gian"
            {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                btnTk.Visible = true;
                lbDenngay.Visible = true;
                lbTungay.Visible = true;

            }

            // Quan trọng: Gọi hàm lọc để cập nhật dữ liệu ngay lập tức
            ApplyFilters();
        }
    }
}
