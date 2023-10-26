using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FullWindowsForm
{
    public partial class C4_1_1 : Form
    {
        public C4_1_1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(txtA.Text);
            decimal b = decimal.Parse(txtB.Text);
            if (rdbDivision.Checked)
            {
                if (b == 0)
                {
                    MessageBox.Show("Không được chia cho 0");
                }
                else
                {
                    MessageBox.Show("Kết quả là: " + a.ToString() + "/" + b.ToString() + "\n" + "=" + (a / b).ToString());
                    txtKetQua.Text = (a / b).ToString();
                }
            }
            else if (rdbMinus.Checked)
            {
                MessageBox.Show("Kết quả là: " + a.ToString() + "-" + b.ToString() + "\n" + "=" + (a - b).ToString());
                txtKetQua.Text = (a - b).ToString();
            }
            else if (rdbMultiple.Checked)
            {
                MessageBox.Show("Kết quả là: " + a.ToString() + "*" + b.ToString() + "\n" + "=" + (a * b).ToString());
                txtKetQua.Text = (a * b).ToString();
            }
            else
            {
                MessageBox.Show("Kết quả là: " + a.ToString() + "+" + b.ToString() + "\n" + "=" + (a + b).ToString());
                txtKetQua.Text = (a + b).ToString();
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
        private void C4_1_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
