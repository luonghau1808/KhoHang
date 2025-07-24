using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1_Nhom4.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn1_Nhom4
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
            LoadFormInTab(new ThongTinSanPham(), tabThongTin);
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
                    LoadFormInTab(new ThongTinSanPham(), tabThongTin);
                    break;
                case 1:
                    LoadFormInTab(new ThuocTinh(), tabThuocTinh);
                    break;

            }
        }
    }
}
