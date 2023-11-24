using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C6_3_1_1 : Form
    {
        public delegate void truyenChoC6_3_1(string hoTen, string lop);

        public truyenChoC6_3_1 TruyenDataChoC631;
        public C6_3_1_1()
        {
            InitializeComponent();
        }


        private void C6_3_1_1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length > 0 && txtLop.Text.Trim().Length > 0)
            {
                TruyenDataChoC631(txtHoTen.Text.Trim(), txtLop.Text.Trim());
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {

        }
    }
}
