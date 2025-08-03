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
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI.Nhập_hàng
{
    public partial class SanPhamF : Form
    {
        GenericBLL<ChiTietSanPham> ctSanPhamBAL;
        GenericBLL<SanPham> sanPhamBAL;
        PhieuNhapF _phieuNhapF;

        private int maSp = 0;
        private decimal donGia = 0;

        public SanPhamF(PhieuNhapF phieuNhapF)
        {
            _phieuNhapF = phieuNhapF;
            InitializeComponent();

            ctSanPhamBAL = new GenericBLL<ChiTietSanPham>();
            sanPhamBAL = new GenericBLL<SanPham>();
        }
        private void LoadSP()
        {
            try
            {
                var list = ctSanPhamBAL.GetAll(
                    x => x.MaSpNavigation,
                    x => x.MaMauNavigation,
                    x => x.MaKichThuocNavigation,
                    x => x.MaSpNavigation.MaThuongHieuNavigation,
                    x => x.MaSpNavigation.MaNccNavigation);

                dgvSP.DataSource = list.Select((sp, index) => new
                {
                    STT = index + 1,
                    MaSP = sp.MaCtsp,
                    TenSP = sp.MaSpNavigation.TenSp,
                    MauSac = sp.MaMauNavigation.TenMau,
                    DonGia = sp.DonGiaNhap,
                    KichThuoc = sp.MaKichThuocNavigation.TenKichThuoc,
                    ThuongHieu = sp.MaSpNavigation.MaThuongHieuNavigation.TenThuongHieu,
                    NhaCungCap = sp.MaSpNavigation.MaNccNavigation.TenNcc
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load sản phẩm: " + ex.Message);
            }
        }
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSP.Rows[e.RowIndex];
            txtSanPham.Text = row.Cells["TenSP"].Value.ToString();
            maSp = int.Parse(row.Cells["MaSP"].Value.ToString() ?? "0");
            var gia = row.Cells["DonGia"].Value.ToString()?.Replace(".00", "0");
            donGia = decimal.Parse(gia ?? "0");
        }
        private void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuong = int.Parse(txtSoluongNhap.Text);
                _phieuNhapF.ThemGioHang(maSp, soLuong, donGia);

                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtSearch.Text.Trim().ToLower();

                var danhSach = sanPhamBAL.GetAll();

                // Lọc theo tên sản phẩm
                var ketQua = danhSach
                    .Where(sp => sp.TenSp != null && sp.TenSp.ToLower().Contains(tuKhoa))
                    .ToList();

                dgvSP.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
