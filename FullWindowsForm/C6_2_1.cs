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
    public partial class C6_2_1 : Form
    {
        public C6_2_1()
        {
            InitializeComponent();
        }

        private void C6_2_1_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textBox, "Vui lòng nhập dữ liệu");
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ptcbThem_Click(object sender, EventArgs e)
        {
            
        }

        private void pctbSua_Click(object sender, EventArgs e)
        {
        }

        private void lblXoa_Click(object sender, EventArgs e)
        {
        }

        private void pctbXoa_Click(object sender, EventArgs e)
        {
        }

        private void lblThem_Click(object sender, EventArgs e)
        {
        }

        private void lblSua_Click(object sender, EventArgs e)
        {
        }
    }
}
