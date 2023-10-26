using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C3_2_3 : Form
    {
        public C3_2_3()
        {
            InitializeComponent();
        }

        static long UCLN(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return UCLN(b, a % b);
        }
        static long BCNN(long a, long b)
        {
            return Math.Abs(a * b) / UCLN(a, b);
        }
        private void C3_2_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textbox, "vui lòng không bỏ trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            long a = long.Parse(txtA.Text);
            long b = long.Parse(txtB.Text);
            txtUCLN.Text = UCLN(a, b).ToString();
            txtBCNN.Text = BCNN(a, b).ToString();
        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
