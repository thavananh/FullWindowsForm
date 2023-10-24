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
    public partial class C3_2_1 : Form
    {
        public C3_2_1()
        {
            InitializeComponent();
        }
        private void C3_2_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You should input");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt64(txtA.Text);
            double b = Convert.ToInt64(txtB.Text);
            txtKetQua.Text = (a + b).ToString();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt64(txtA.Text);
            double b = Convert.ToInt64(txtB.Text);
            txtKetQua.Text = (a - b).ToString();
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt64(txtA.Text);
            double b = Convert.ToInt64(txtB.Text);
            txtKetQua.Text = (a * b).ToString();
        }
        private void btnChia_ClicK(object sender, EventArgs e)
        {
            double a = Convert.ToInt64(txtA.Text);
            double b = Convert.ToInt64(txtB.Text);
            txtKetQua.Text = (a / b).ToString();
        }

    }

}
