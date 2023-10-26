using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C3_3_1 : Form
    {
        public C3_3_1()
        {
            InitializeComponent();
        }

        private void C3_3_1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.Contains("button"))
                    {
                        c.Click += btnDatGhe_Click;
                    }
                }
            }
        }
        private void C3_3_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnDatGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == SystemColors.Control)
            {
                btn.BackColor = Color.Yellow;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = SystemColors.Control;
                btn.UseVisualStyleBackColor = true;
            }
        }
        Decimal thanhTien = 0;
        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("button") && c.BackColor == Color.Yellow)
                {
                    c.BackColor = Color.Blue;
                    int soGhe = int.Parse(c.Name.Substring(6));
                    if (soGhe < 6)
                    {
                        thanhTien += 1000;
                    }
                    else if (soGhe > 5)
                    {
                        thanhTien += 1500;
                    }
                    else
                    {
                        thanhTien += 2000;
                    }
                }
            }
            txtThanhTien.Text = thanhTien.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if ((c.Name.Contains("button")))
                {
                    Button btn = (Button)c;
                    btn.BackColor = SystemColors.Control;
                    btn.UseVisualStyleBackColor = true;
                }
            }
            txtThanhTien.Clear();
            thanhTien = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
