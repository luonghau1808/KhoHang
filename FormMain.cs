using System.Windows.Forms;
using DuAn1_Nhom4.GUI;

namespace DuAn1_Nhom4
{
    public partial class FormMain : Form
    {
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
            LoadFormToPanel(new NhaCungCap());

        }


        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new HoaDon());

        }

      

      
    }

}
