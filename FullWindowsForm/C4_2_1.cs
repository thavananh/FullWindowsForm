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
    public partial class C4_2_1 : Form
    {
        public C4_2_1()
        {
            InitializeComponent();
        }

        private void phuongTrinhBac2(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                txtKetQua.Text = "Phương trình không có nghiệm";
            }
            else if (delta == 0)
            {
                txtKetQua.Text = "Phương trình có nghiệm kép x1 = x2 = " + (-b / 2 * a).ToString();
            }
            else if (delta > 0)
            {
                txtKetQua.Text = "Phương trình có 2 nghiệm phân biệt " + "\n" + "x1 = " + ((-b + Math.Sqrt(delta)) / 2 * a) + " " + "x1 = " + ((-b - Math.Sqrt(delta)) / 2 * a);
            }
        }
        private void phuongTrinhBac1(double a, double b = 0)
        {
            if (a == 0)
            {
                txtKetQua.Text = "Phương trình không có nghiệm";
            }
            else
            {
                txtKetQua.Text = "Phương trình có nghiệm x = " + (-b / a).ToString();
            }
        }

        private void C4_2_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
                this.errorProvider1.SetError(textbox, "Hãy nhập dữ liệu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (rdbPtrinhBac2.Checked)
            {
                phuongTrinhBac2(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text));
            }
            else
            {
                phuongTrinhBac1(double.Parse(txtA.Text), double.Parse(txtB.Text));
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
