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
    public partial class C6_3_1 : Form
    {
        public C6_3_1()
        {
            InitializeComponent();
        }

        private void C6_3_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void endMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void mnst_InputHocVienMoi_Click(object sender, EventArgs e)
        {

        }

        private void mnst_ChuyenSangLopB_Click(object sender, EventArgs e)
        {

        }

        private void mnst_ChuyenSangLopA_Click(object sender, EventArgs e)
        {

        }

        private void mnst_XoaHocVien_Click(object sender, EventArgs e)
        {

        }
    }
}
