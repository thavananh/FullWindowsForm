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
    public partial class C5_4_2 : Form
    {
        public C5_4_2()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstNhap.Items.Add(txtNhap.Text);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnTongCacPhanTuTrongList_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count > 0)
            {
                long sum = 0;
                foreach (var items in lstNhap.Items)
                {
                    sum += Convert.ToInt64(items.ToString());
                }
                MessageBox.Show($"Tổng các phần tử trong list là: {sum}");
            }
        }

        private void btnXoaPhanTuDauVaCuoi_Click(object sender, EventArgs e)
        {
            if (lstNhap.Items.Count >= 2)
            {
                lstNhap.Items.RemoveAt(0);
                lstNhap.Items.RemoveAt(lstNhap.Items.Count - 1);
            }
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            if (lstNhap.SelectedItem != null)
            {
                lstNhap.Items.RemoveAt(lstNhap.SelectedIndex);
            }
        }

        private void btnTangMoiPhanTuLenHai_Click(object sender, EventArgs e)
        {
            for (int i = lstNhap.Items.Count - 1; i >= 0; i--)
            {
                lstNhap.Items[i] = Convert.ToInt64(lstNhap.Items[i]) + 2;
            }
        }

        private void btnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = lstNhap.Items.Count - 1; i >= 0; i--)
            {
                lstNhap.Items[i] = Math.Sqrt(Convert.ToInt64(lstNhap.Items[i]));
            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            for (int i = lstNhap.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt64(lstNhap.Items[i]) % 2 != 0)
                {
                    lstNhap.Items.RemoveAt(i);
                }
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstNhap.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt64(lstNhap.Items[i]) % 2 == 0)
                {
                    lstNhap.Items.RemoveAt(i);
                }
            }
        }
    }
}
