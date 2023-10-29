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
    public partial class C5_2_1 : Form
    {
        public C5_2_1()
        {
            InitializeComponent();
        }

        private bool snt(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNhapSo.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtNhapSo, "Vui lòng nhập số trước khi bấm cập nhật");
            }
            else
            {
                this.errorProvider1.Clear();
                foreach (object item in cboDanhSachSo.Items)
                {
                    if (item.ToString() == txtNhapSo.Text)
                    {
                        this.errorProvider1.SetError(txtNhapSo, "Vui lòng không nhập số có trong danh sách");
                        return;
                    }
                }
                cboDanhSachSo.Items.Add(txtNhapSo.Text);
                listBox1.Items.Add(txtNhapSo.Text);
                cboDanhSachSo.SelectedIndex = cboDanhSachSo.Items.Count - 1;
                txtNhapSo.Clear();
            }
        }
        private void cboDanhSachSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            long numb = long.Parse(cboDanhSachSo.SelectedItem.ToString());
            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    listBox1.Items.Add(numb.ToString());
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnTongCacUocSo_Click(object sender, EventArgs e)
        {
            long numb = long.Parse(cboDanhSachSo.SelectedItem.ToString());
            long sumCacUocSo = 0;
            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    sumCacUocSo += i;
                }
            }
            MessageBox.Show("Tổng các ước số: " + sumCacUocSo.ToString());
        }

        private void btnSoLuongCacUocSoChan_Click(object sender, EventArgs e)
        {
            long numb = long.Parse(cboDanhSachSo.SelectedItem.ToString());
            long sumCacUocSoChan = 0;
            for (int i = 2; i <= numb; i += 2)
            {
                if (numb % i == 0)
                {
                    sumCacUocSoChan += i;
                }
            }
            MessageBox.Show("Tổng các ước số chẵn: " + sumCacUocSoChan.ToString());
        }

        private void btnSoLuongCacUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            long numb = long.Parse(cboDanhSachSo.SelectedItem.ToString());
            long sumCacUocSoNguyenTo = 0;
            for (int i = 2; i <= numb; i += 2)
            {
                if (numb % i == 0 && snt(i))
                {
                    sumCacUocSoNguyenTo += i;
                }
            }
            MessageBox.Show("Tổng các ước số nguyên tố: " + sumCacUocSoNguyenTo.ToString());
        }
    }
}
