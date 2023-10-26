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
    public partial class C3_3_2 : Form
    {
        public C3_3_2()
        {
            InitializeComponent();
        }
        private void C3_3_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txtKetQua_Leave(object sender, EventArgs e)
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
        private void txtKetQua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        long a = 0;
        long b = 0;

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name.Contains("btn"))
            {
                int k = 0;
                string s;
                if (int.TryParse(btn.Name.Substring(3), out k))
                {
                    if (txtKetQua.Text == "-" || txtKetQua.Text == "+" || txtKetQua.Text == "*" || txtKetQua.Text == "/")
                    {
                        txtKetQua.Clear();
                    }
                    txtKetQua.Text += k.ToString();
                }
                else
                {
                    s = btn.Name.Substring(3);
                    if (s == "Clear")
                    {
                        txtKetQua.Clear();
                        a = 0; b = 0;
                    }
                    else if (s == "Equal")
                    {
                        if (txtKetQua.Text == "-" || txtKetQua.Text == "+" || txtKetQua.Text == "*" || txtKetQua.Text == "/")
                        {
                            MessageBox.Show("Không được để toán tử một mình");
                        }
                        else
                        {
                            txtKetQua.Text += a.ToString(); 
                        }
                    }
                    else if (s == "Minus")
                    {
                        if (a == 0)
                        {
                            a = long.Parse(txtKetQua.Text);
                        }
                        else
                        {
                            b = long.Parse(txtKetQua.Text);
                        }
                        txtKetQua.Clear();
                        txtKetQua.Text += "-";
                     
                        if (b != 0)
                        {
                            a = a - b;
                            b = 0;
                        }
                    }
                    else if (s == "Plus")
                    {
                        if (a == 0)
                        {
                            a = long.Parse(txtKetQua.Text);
                        }
                        else
                        {
                            b = long.Parse(txtKetQua.Text);
                        }
                        txtKetQua.Clear();
                        txtKetQua.Text += "+";
                        
                        if (b != 0)
                        {
                            a = a + b;
                            b = 0;
                        }
                    }
                    else if (s == "Multiple")
                    {
                        if (a == 0)
                        {
                            a = long.Parse(txtKetQua.Text);
                        }
                        else
                        {
                            b = long.Parse(txtKetQua.Text);
                        }
                        txtKetQua.Clear();
                        txtKetQua.Text += "*";
                        
                        if (b != 0)
                        {
                            a = a * b;
                            b = 0;
                        }
                    }
                    else if (s == "Division")
                    {
                        if (a == 0)
                        {
                            a = long.Parse(txtKetQua.Text);
                        }
                        else
                        {
                            b = long.Parse(txtKetQua.Text);
                        }
                        txtKetQua.Clear();
                        txtKetQua.Text += "/";
                        
                        if (b != 0)
                        {
                            a = a / b;
                            b = 0;
                        }
                    }
                }
            }
        }

        private void C3_3_2_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.Contains("btn"))
                    {
                        c.Click += btn_Click;
                    }
                }
            }
        }
    }
}
