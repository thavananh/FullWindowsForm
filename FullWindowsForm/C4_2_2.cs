using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace FullWindowsForm
{
    public partial class C4_2_2 : Form
    {
        public C4_2_2()
        {

            InitializeComponent();
            btnThucHien.Enabled = false;
        }
        private void swap(ref long a, ref long b)
        {
            long tmp = a;
            a = b;
            b = tmp;
        }
        private void C4_2_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void C4_2_2_Load(object sender, EventArgs e)
        {

        }

        private void xoaMang(ref long[] a, int index)
        {

            long[] tmp = a;
            a = new long[a.Length - 1];
            int j = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                a[j] = tmp[i];
                j++;
            }

        }

        private void themMang(ref long[] a, int index, long value)
        {
            long[] tmp = a;
            a = new long[a.Length + 1];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == index)
                {
                    a[i] = value;
                    continue;
                }
                a[i] = tmp[j];
                j++;
            }
        }

        private void thayMang(ref long[] a, int index, long value)
        {
            long[] tmp = a;
            a = new long[a.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == index)
                {
                    a[i] = value;
                    continue;
                }
                a[i] = tmp[i];
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Clear();
                }
            }
            btnThucHien.Enabled = false;
            Array.Clear(a, 0, a.Length);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textbox, "Vui Lòng Nhập Dữ Liệu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b' || e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        long[] a;
        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            string[] s = txtInputMang.Text.Split(' ');
            a = new long[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = long.Parse(s[i]);
            }
            btnThucHien.Enabled = true;
        }


        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdbSapXepTang.Checked)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            swap(ref a[i], ref a[j]);
                        }
                    }
                }
            }
            else if (rdbSapXepGiam.Checked)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            swap(ref a[i], ref a[j]);
                        }
                    }
                }
            }

            if (rdbTimGiaTriCanTim.Checked)
            {
                long tmp = long.Parse(txtTimGiaTriCanTim.Text);
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == tmp)
                    {
                        txtSoTimDuoc.Clear();
                        txtSoTimDuoc.Text += i;
                        break;
                    }
                }

            }
            else if (rdbTimViTriCanTim.Checked)
            {
                txtSoTimDuoc.Clear();
                txtSoTimDuoc.Text += a[int.Parse(txtTimViTriCanTim.Text)];
            }
            if (rdbTimGiaTriCanXoa.Checked && rdbSapXepTang.Checked)
            {
                long tmp = long.Parse(txtTimGiaTriCanXoa.Text);
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == tmp)
                    {
                        xoaMang(ref a, i);
                    }
                }
                txtKetQuaMang.Clear();
                for (int i = 0; i < a.Length; i++)
                {
                    txtKetQuaMang.Text += a[i] + " ";
                }
            }
            else if (rdbTimViTriCanXoa.Checked && rdbSapXepTang.Checked)
            {
                xoaMang(ref a, int.Parse(txtTimViTriCanXoa.Text));
                txtKetQuaMang.Clear();
                for (int i = 0; i < a.Length; i++)
                {
                    txtKetQuaMang.Text += a[i] + " ";
                }
            }
            if (rdbGiaTriCanThem.Checked)
            {
                themMang(ref a, int.Parse(txtViTriCanThem.Text), long.Parse(txtSoThayThe.Text));
                txtKetQuaMang.Clear();
                for (int i = 0; i < a.Length; i++)
                {
                    txtKetQuaMang.Text += a[i] + " ";
                }
            }
            if (rdbGiaTriCanThayThe.Checked)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == long.Parse(txtGiaTriCanThayThe.Text))
                    {
                        thayMang(ref a, i, long.Parse(txtSoThayThe.Text));
                    }
                }
                txtKetQuaMang.Clear();
                for (int i = 0; i < a.Length; i++)
                {
                    txtKetQuaMang.Text += a[i] + " ";
                }
            }
            else if (rdbViTriCanThayThe.Checked)
            {
                thayMang(ref a, int.Parse(txtViTriCanThayThe.Text), long.Parse(txtSoThayThe.Text));
                txtKetQuaMang.Clear();
                for (int i = 0; i < a.Length; i++)
                {
                    txtKetQuaMang.Text += a[i] + " ";
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            long sum = 0;
            long sumLe = 0;
            long sumChan = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (a[i] % 2 == 0)
                {
                    sumChan += a[i];
                }
                else
                {
                    sumLe += a[i];
                }
            }
            txtTongMang.Clear();
            txtTongMang.Text += sumChan;
            txtTongLe.Clear();
            txtTongLe.Text += sumLe;
            txtTongChan.Clear();
            txtTongChan.Text += sumChan;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            long min = a[0];
            long max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            txtGiaTriLonNhat.Clear();
            txtGiaTriLonNhat.Text += max;
            txtGiaTriNhoNhat.Clear();
            txtGiaTriNhoNhat.Text += min;
        }
    }
}
