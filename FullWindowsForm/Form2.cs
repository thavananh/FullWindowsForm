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
    public partial class Form2 : Form
    {
        private string helloworld;
        public Form2()
        {
            InitializeComponent();
        }

        //public Form2(string helloworld)
        //{
        //    InitializeComponent();
        //    this.helloworld = helloworld;
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = helloworld;
        }

        private void loadData(string data)
        {
            label2.Text = "";
            label2.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.TruyendataChoForm2 = new Form1.truyenChoForm2(loadData);
            form1.ShowDialog();
        }
    }
}
