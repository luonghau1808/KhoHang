using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.DAL;
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

        }
        private void FormLichSu_Load(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void LoadPhieuXuat()
        {
            var list = _pxBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation);
            dgvPhieu.DataSource = list.Select((px, index) => new
            {
                STT = index + 1,
                MaPX = px.MaPhieuXuat,
                TenKH = px.MaKhNavigation.Ten,
                TenNV = px.MaNvNavigation.HoTen,
                NgayXuat = px.NgayXuat,
                TrangThaiPX = px.TrangThaiThanhToan
            }).ToList();


        }

        private void LoadPhieuNhap()
        {
            var list = _pnBLL.GetAll(x => x.MaNvNavigation);
            dgvPhieu.DataSource = list.Select((pn, index) => new
            {
                STT = index + 1,
                MaPN = pn.MaPhieuNhap,
                TenNV = pn.MaNvNavigation.HoTen,
                NgayNhap = pn.NgayNhap,
                TrangThaiPN = pn.TrangThaiThanhToan,
            }).ToList();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                LoadPhieuNhap();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                LoadPhieuXuat();
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
                MaSP = ctpn.MaCtspNavigation.MaSpNavigation.TenSp,
                SoLuong = ctpn.SoLuong,
                DonGia = ctpn.DonGia,
                ThanhTien = ctpn.SoLuong * ctpn.DonGia
            }).ToList();
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
                else // Phiếu Xuất
                {
                    int maPX = Convert.ToInt32(dgvPhieu.Rows[e.RowIndex].Cells["MaPX"].Value);
                    var px = _pxBLL.GetById(maPX);
                    if (px != null)
                    {
                        LoadCTPX(maPX);

                        labelMaNV.Text = "Mã khách hàng: " + px.MaKhNavigation?.MaKh;
                        labelTenNV.Text = "Tên khách hàng: " + px.MaKhNavigation?.Ten;
                        labelNgayTao.Text = "Ngày xuất: " + px.NgayXuat.ToString("dd/MM/yyyy");
                        labelTrangThai.Text = "Trạng thái: " + px.TrangThaiThanhToan;

                        var tongTien = _ctpx.GetAll()
                            .Where(x => x.MaPhieuXuat == maPX)
                            .Sum(x => x.SoLuong * (x.MaCtspNavigation?.DonGiaXuat ?? 0));
                        labelTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
                    }
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
            }
        }

      
    }
}
