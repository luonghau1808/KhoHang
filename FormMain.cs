using System.Windows.Forms;
using DuAn1_Nhom4.GUI;
using DuAn1_Nhom4.GUI.Nhập_hàng;
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
            HighlightButton((Button)sender);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new QuanLyNhanVien());
            HighlightButton((Button)sender);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new PhieuNhapF(NhanVien));
            HighlightButton((Button)sender);
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new GUI.PhieuXuatF(NhanVien));
            HighlightButton((Button)sender);
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
            HighlightButton((Button)sender);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormLichSu());
            HighlightButton((Button)sender);
        }

        private void btnNCC_Click_1(object sender, EventArgs e)
        {
            LoadFormToPanel(new QuanLyNCC());
            HighlightButton((Button)sender);

        }
        private void HighlightButton(Button clickedButton)
        {
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(176, 196, 222); // Màu nền gốc
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);
                }
            }

            // Đổi màu nút đang được click
            clickedButton.BackColor = Color.FromArgb(100, 149, 237); // Màu đậm hơn (CornflowerBlue)
            clickedButton.ForeColor = Color.Black;
            clickedButton.Font = new Font(clickedButton.Font, FontStyle.Bold);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);

            DialogResult result = MessageBox.Show(
        "Bạn có chắc muốn đăng xuất không?",
        "Xác nhận đăng xuất",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ẩn FormMain
                this.Hide();

                // Mở lại FormDangNhap
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();

                // Đóng hẳn FormMain khi FormDangNhap được đóng
                formDangNhap.FormClosed += (s, args) => this.Close();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThongKe());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
