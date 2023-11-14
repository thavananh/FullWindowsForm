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
    public partial class C5_4_3 : Form
    {
        public C5_4_3()
        {
            InitializeComponent();
        }

        private void C5_4_3_Load(object sender, EventArgs e)
        {
            loadDanhBa();
        }

        private void loadDanhBa()
        {
            int a = 65;
            while (a > 64 && a < 91)
            {
                trvDanhBa.Nodes.Add(Convert.ToChar(a).ToString());
                a++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = txtFirstName.Text + ", " + txtLastName.Text;
            for (int i = trvDanhBa.Nodes.Count - 1; i >= 0; i--)
            {
                if (txtFirstName.Text[0] == Convert.ToChar(trvDanhBa.Nodes[i].Text))
                {
                    trvDanhBa.Nodes[i].Nodes.Add(s);
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
