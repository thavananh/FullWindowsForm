using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C6_2_2 : Form
    {
        public C6_2_2()
        {
            InitializeComponent();
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textBox, "Vui lòng nhập dữ liệu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private static int stt = 1;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstvKhachHang.FocusedItem;
            item.Remove();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemLoop in lstvKhachHang.Items)
            {
                if (itemLoop.SubItems.Count > 1 && itemLoop.SubItems[1].Text == txtSoTaiKhoan.Text)
                {
                    MessageBox.Show("Số tài khoản bạn nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ListViewItem item = new ListViewItem();
            item.Text = stt.ToString();
            item.SubItems.Add(txtSoTaiKhoan.Text);
            item.SubItems.Add(txtTenKhachHang.Text);
            item.SubItems.Add(txtDiaChiKhachHang.Text);
            item.SubItems.Add(Convert.ToDecimal(txtSoTienTaiKhoan.Text).ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            lstvKhachHang.Items.Add(item);
            stt++;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvKhachHang.FocusedItem == null)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }
        }
    }
}
