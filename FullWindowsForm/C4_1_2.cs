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
    public partial class C4_1_2 : Form
    {

        public C4_1_2()
        {
            InitializeComponent();
        }
        private void C4_1_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void ckbFontRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFontRegular.Checked)
            {
                labelHeader.Font = new Font(labelHeader.Font, FontStyle.Regular);
            }

        }

        private void ckbFontBold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFontBold.Checked)
            {
                labelHeader.Font = new Font(labelHeader.Font, FontStyle.Bold);
            }

        }

        private void ckbFontItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFontItalic.Checked)
            {
                labelHeader.Font = new Font(labelHeader.Font, FontStyle.Italic);
            }

        }

        private void ckbFontBoldAndItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFontBoldAndItalic.Checked)
            {
                labelHeader.Font = new Font(labelHeader.Font, (FontStyle)(FontStyle.Bold | FontStyle.Italic));
            }

        }
        private void rdbFontAutoColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFontAutoColor.Checked)
            {
                labelHeader.ForeColor = Color.Black;
            }
        }

        private void rdbFontRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFontRed.Checked)
            {
                labelHeader.ForeColor = Color.Red;
            }


        }

        private void rdbFontGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFontGreen.Checked)
            {
                labelHeader.ForeColor = Color.Green;
            }

        }

        private void rdbFontBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFontBlue.Checked)
            {
                labelHeader.ForeColor = Color.Blue;
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
