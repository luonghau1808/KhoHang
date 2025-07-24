using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom4
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void lbQuenMatKhau_MouseEnter(object sender, EventArgs e)
        {

            lbQuenMatKhau.BackColor = Color.LightBlue;
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {


        }

        private void lbQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lbQuenMatKhau.BackColor = Color.Transparent;
        }
    }
}
