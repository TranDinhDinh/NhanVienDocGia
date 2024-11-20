using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viên
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnQLNV_Click(object sender, EventArgs e)
        {
            frmNV frmNV = new frmNV();
            frmNV.MdiParent = this;
            frmNV.Show();
        }
    }
}
