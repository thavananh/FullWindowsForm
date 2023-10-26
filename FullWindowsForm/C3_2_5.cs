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
    public partial class C3_2_5 : Form
    {
        public C3_2_5()
        {
            InitializeComponent();
        }
        static string numberToText(string s)
        {
            string rs = "";
            if (s.Length == 1)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    switch (s[i])
                    {
                        case '1':
                            rs += "Một";
                            break;
                        case '2':
                            rs += "Hai";
                            break;
                        case '3':
                            rs += "Ba";
                            break;
                        case '4':
                            rs += "Bốn";
                            break;
                        case '5':
                            rs += "Năm";
                            break;
                        case '6':
                            rs += "Sáu";
                            break;
                        case '7':
                            rs += "Bảy";
                            break;
                        case '8':
                            rs += "Tám";
                            break;
                        case '9':
                            rs += "Chín";
                            break;
                    }
                }
            }
            if (s.Length == 2)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    switch (s[i])
                    {
                        case '1':
                            if (i % 2 != 0)
                            {
                                rs += "Mốt";
                                break;
                            }
                            rs += "Một";
                            break;
                        case '2':
                            rs += "Hai";
                            break;
                        case '3':
                            rs += "Ba";
                            break;
                        case '4':
                            rs += "Bốn";
                            break;
                        case '5':
                            rs += "Năm";
                            break;
                        case '6':
                            rs += "Sáu";
                            break;
                        case '7':
                            rs += "Bảy";
                            break;
                        case '8':
                            rs += "Tám";
                            break;
                        case '9':
                            rs += "Chín";
                            break;
                    }
                    rs += " ";
                    if (i % 2 == 0)
                    {
                        if (s[i] == '1')
                        {
                            rs = "";
                            rs += "Mười";
                        }
                        else
                        {
                            rs += "Mươi";
                        }
                    }
                    rs += " ";
                }
            }
            if (s.Length == 3)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    switch (s[i])
                    {
                        case '1':
                            if (i % 2 != 0)
                            {
                                break;
                            }
                            rs += "Một";
                            break;
                        case '2':
                            rs += "Hai";
                            break;
                        case '3':
                            rs += "Ba";
                            break;
                        case '4':
                            rs += "Bốn";
                            break;
                        case '5':
                            rs += "Năm";
                            break;
                        case '6':
                            rs += "Sáu";
                            break;
                        case '7':
                            rs += "Bảy";
                            break;
                        case '8':
                            rs += "Tám";
                            break;
                        case '9':
                            rs += "Chín";
                            break;
                    }
                    rs += " ";
                    if (i + 1 == s.Length)
                    {
                        break;
                    }
                    if (i % 2 == 0)
                    {
                        rs += "Trăm";
                    }
                    if (i % 2 != 0)
                    {
                        if (s[i] == '1')
                        {
                            rs += "Mười";
                        }
                        else
                        {
                            rs += "Mươi";
                        }
                    }
                    rs += " ";
                }
            }
            return rs;
        }
        private void C3_2_5_FormClosing(object sender, FormClosingEventArgs e)
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
            txtKetQua.Text = numberToText(txtNhap.Text);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();   
        }    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
