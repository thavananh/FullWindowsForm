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
    public partial class C5_1_1 : Form
    {
        public C5_1_1()
        {
            InitializeComponent();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            lstbPhai.Items.Add(lstbTrai.SelectedItem);
            lstbTrai.Items.Remove(lstbTrai.SelectedItem);
        }

        private void btnQuaPhai_All_Click(object sender, EventArgs e)
        {
            lstbPhai.Items.AddRange(lstbTrai.Items);
            lstbTrai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            lstbTrai.Items.Add(lstbPhai.SelectedItem);
            lstbTrai.Items.AddRange(lstbPhai.Items);
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
        }

        private void C5_1_1_Load(object sender, EventArgs e)
        {
            lstbTrai.Items.Add("cam");
            lstbTrai.Items.Add("xoài");
            lstbTrai.Items.Add("cóc");
            lstbTrai.Items.Add("ổi");
            lstbTrai.Items.Add("trà chanh");
        }
    }
}
