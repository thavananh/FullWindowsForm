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
    public partial class Form1 : Form
    {
        public delegate void truyenChoForm2(string text);

        public truyenChoForm2 TruyendataChoForm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                //Form2 form2 = new Form2(textBox1.Text);
                //form2.ShowDialog();
                TruyendataChoForm2(textBox1.Text.Trim());
            }
        }
    }
}
