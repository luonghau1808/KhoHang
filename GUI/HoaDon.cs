using System.Data;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI
{
    public partial class HoaDon : Form
    {
        private GenericBLL<ChiTietSanPham> ctSanphamBLL = new GenericBLL<ChiTietSanPham>();
        public HoaDon()
        {
            InitializeComponent();
            LoadFormInTab(new TaoHoaDon(), tabHoaDon);
        }

        private void LoadSanPham()
        {
            var list = ctSanphamBLL.GetAll(x => x.MaSpNavigation, x => x.MaMauNavigation, x => x.MaKichThuocNavigation);
            dtgDanhSachSP.DataSource = list.Select((sp, index) => new
            {
                STT = index + 1,
                MaSP = sp.MaSp,
                TenSP = sp.MaSpNavigation.TenSp,
                MauSac = sp.MaMauNavigation.TenMau,
                KichThuoc = sp.MaKichThuocNavigation.TenKichThuoc,
                SoLuong = sp.SoLuong,
                DonGiaNhap = sp.DonGiaNhap,
                DonGiaXuat = sp.DonGiaXuat

            }).ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFormInTab(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Clear();
            tabPage.Controls.Add(form);
            form.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    LoadFormInTab(new TaoHoaDon(), tabHoaDon);
                    break;
                case 1:
                    LoadFormInTab(new DonDatHang(), tabDatHang);
                    break;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
