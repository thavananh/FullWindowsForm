using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C2_2_4 : Form
    {
        public C2_2_4()
        {
            InitializeComponent();
        }

        private void C3_2_4_FormClosing(object sender, FormClosingEventArgs e)
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
        List<int> list = new List<int>();
        private void Nhap_Click(object sender, EventArgs e)
        {
            txtDaySo.Text += (txtNumber.Text + " ");
            list.Add(Convert.ToInt32(txtNumber.Text));
            txtNumber.Clear();
        }
        private void TiepTuc_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            txtTongCacPhanTu.Text = sum.ToString();
            long sum1 = 0;
            long sum2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    sum1 += list[i];
                }
                else
                {
                    sum2 += list[i];
                }
            }
            txtTongChan.Text = sum1.ToString();
            txtTongLe.Text = sum2.ToString();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
