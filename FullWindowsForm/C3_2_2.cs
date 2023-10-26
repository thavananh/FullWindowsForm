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
    public partial class C3_2_2 : Form
    {
        public C3_2_2()
        {
            InitializeComponent();
        }
        private void C3_2_2_FormClosing(object sender, FormClosingEventArgs e)
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
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim().Length != 0)
            {
                string tmp = textbox.Text;
                int dauACong = 0, dauCham = 0;
                for (int i = 0; i < tmp.Length; ++i)
                {
                    if (tmp[i] == '@')
                    {
                        dauACong++;

                    }
                    if (tmp[i] == '.')
                    {
                        dauCham++;
                    }
                }
                if (dauACong > 1 || dauACong == 0 || dauCham == 0)
                {
                    this.errorProvider1.SetError(textbox, "Email không đúng định dạng");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
            else if (textbox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textbox, "Vui lòng không bỏ trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Đăng ký tài khoản thất bại, xác nhận mật khẩu không chính xác", "Form");
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thành công", "Form");
                txtDangNhap.Clear();
                txtEmail.Clear();
                txtMatKhau.Clear();
                txtXacNhanMatKhau.Clear();
            }
        }
    }
}
