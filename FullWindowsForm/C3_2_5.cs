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
        static string numberToText(char c, int n)
        {
            if (n == 0)
            {
                
                    switch (c)
                    {
                        case '1':
                            return "Một";
                        case '2':
                            return "Hai";
                            
                        case '3':
                            return "Ba";
                            
                        case '4':
                            return "Bốn";
                            
                        case '5':
                            return "Năm";
                            
                        case '6':
                            return "Sáu";
                            
                        case '7':
                            return "Bảy";
                            
                        case '8':
                            return "Tám";
                            
                        case '9':
                            return "Chín";
                        default:
                            break;
                    }
            }
            else if (n == 1)
            {
                switch (c)
                {
                    case '1':
                        return "Một trăm";
                    case '2':
                        return "Hai trăm";

                    case '3':
                        return "Ba trăm";

                    case '4':
                        return "Bốn trăm";

                    case '5':
                        return "Năm trăm";

                    case '6':
                        return "Sáu trăm";

                    case '7':
                        return "Bảy trăm";

                    case '8':
                        return "Tám trăm";

                    case '9':
                        return "Chín trăm";
                    default:
                        break;
                }
            }
            else if (n == 2)
            {

            }
            return "";
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
            
            
        }

        private void C3_2_5_Load(object sender, EventArgs e)
        {

        }
    }
}
