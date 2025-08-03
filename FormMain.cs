using System.Windows.Forms;
using DuAn1_Nhom4.GUI;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4
{
    public partial class FormMain : Form
    {
        public NhanVien NhanVien { get; set; }

        public FormMain()
        {
            InitializeComponent();

        }
        private void LoadFormToPanel(Form form)
        {
            panelMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QuanLySanPham());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QuanLyNhanVien());

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new GUI.NhaCungCap());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new GUI.PhieuXuatF(NhanVien));

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (NhanVien.MaChucVu == 2)
            {
                btnNV.Visible = false;
            }

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new TaiKhoanF(NhanVien));
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormLichSu());

        }
    }

}
