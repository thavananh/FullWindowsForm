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
    public partial class C6_4_1 : Form
    {
        private long sogiay = 1800;
        public C6_4_1()
        {
            InitializeComponent();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(sogiay);
            lblDongHo.Visible = true;
            lblDongHo.Text = ts.ToString(@"mm\:ss");
            sogiay--;
        }

        private void C6_4_1_Load(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(sogiay);
            lblDongHo.Visible = true;
            lblDongHo.Text = ts.ToString(@"mm\:ss");
        }
    }
}
