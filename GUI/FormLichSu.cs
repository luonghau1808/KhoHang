using System.Data;
using System.Windows.Forms;
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

        }
        private void FormLichSu_Load(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void LoadPhieuXuat(string? trangThai = null)
        {
            var list = _pxBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation).Where(px => trangThai == null || px.TrangThaiThanhToan == trangThai);
            dgvPhieu.DataSource = list.Select((px, index) => new
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

            dgvPhieu.Columns["MaPX"].HeaderText = "Mã phiếu xuất";
            dgvPhieu.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvPhieu.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvPhieu.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dgvPhieu.Columns["TrangThaiPX"].HeaderText = "Trạng thái";
            
        }

        private void LoadPhieuNhap(string? trangThai = null)
        {
            var list = _pnBLL.GetAll(x => x.MaNvNavigation).Where(pn => trangThai == null || pn.TrangThaiThanhToan == trangThai);
            dgvPhieu.DataSource = list.Select((pn, index) => new
            {
                STT = index + 1,
                MaPN = pn.MaPhieuNhap,
                TenNV = pn.MaNvNavigation.HoTen,
                NgayNhap = pn.NgayNhap,
                TrangThaiPN = pn.TrangThaiThanhToan,
            }).ToList();

            dgvPhieu.Columns["STT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieu.Columns["MaPN"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieu.Columns["TenNV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieu.Columns["NgayNhap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieu.Columns["TrangThaiPN"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvPhieu.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieu.Columns["MaPN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhieu.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPhieu.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
            dgvPhieu.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvPhieu.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvPhieu.Columns["TrangThaiPN"].HeaderText = "Trạng thái";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                LoadPhieuNhap();
                cbTrangthai.SelectedItem = "Tất cả";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                LoadPhieuXuat();
                cbTrangthai.SelectedItem = "Tất cả";
            }

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

            dgvCt.Columns["MaCT"].HeaderText = "Mã chi tiết";
            dgvCt.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvCt.Columns["MauSac"].HeaderText = "Màu sắc";
            dgvCt.Columns["KichThuoc"].HeaderText = "Kích thước";
            dgvCt.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCt.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvCt.Columns["ThanhTien"].HeaderText = "Thành tiền";

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

            dgvCt.Columns["MaCTPN"].HeaderText = "Mã chi tiết";
            dgvCt.Columns["TenSp"].HeaderText = "Tên sản phẩm";
            dgvCt.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCt.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvCt.Columns["ThanhTien"].HeaderText = "Thành tiền";

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
            DateOnly datetuNgay = DateOnly.FromDateTime(dateTimePicker1.Value.Date);
            DateOnly dateDenngay = DateOnly.FromDateTime(dateTimePicker2.Value.Date);

            if (datetuNgay > dateDenngay)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                var list = _pnBLL.GetAll(x => x.MaNvNavigation).Where(x => x.NgayNhap >= datetuNgay && x.NgayNhap <= dateDenngay);
                dgvPhieu.DataSource = list.Select((pn, index) => new
                {
                    STT = index + 1,
                    MaPN = pn.MaPhieuNhap,
                    TenNV = pn.MaNvNavigation.HoTen,
                    NgayNhap = pn.NgayNhap,
                    TrangThaiPN = pn.TrangThaiThanhToan,
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
            else
            {
                var list = _pxBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation).Where(x => x.NgayXuat >= datetuNgay && x.NgayXuat <= dateDenngay);
                dgvPhieu.DataSource = list.Select((px, index) => new
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

        private void cbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrangthai.Text == "Tất cả")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    LoadPhieuNhap();
                }
                else
                {
                    LoadPhieuXuat();
                }
            }
            else if (cbTrangthai.Text == "Đã thanh toán")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    LoadPhieuNhap(cbTrangthai.Text);

                }
                else
                {
                    LoadPhieuXuat(cbTrangthai.Text);
                }
            }
            else if (cbTrangthai.Text == "Chưa thanh toán" || cbTrangthai.Text == "Đã hủy")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    LoadPhieuNhap(cbTrangthai.Text);
                }
                else
                {
                    LoadPhieuXuat(cbTrangthai.Text);
                }
            }
        }
    }
}
