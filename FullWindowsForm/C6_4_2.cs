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
    public partial class C6_4_2 : Form
    {
        public C6_4_2()
        {
            InitializeComponent();
        }

        private void c612ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C6_1_2 frmC612 = new C6_1_2();
            frmC612.ShowDialog();
        }

        private void c613ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C6_1_3 frmC613 = new C6_1_3();
            frmC613.ShowDialog();
        }
    }
}
