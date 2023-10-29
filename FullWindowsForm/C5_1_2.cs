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
    public partial class C5_1_2 : Form
    {
        public C5_1_2()
        {
            InitializeComponent();
            label2.Visible = false;
            combbDanToc.SelectedIndexChanged += cbo_SelecteđIndexChanged;
        }

        private void btnLoadDuLieuComboBox_Click(object sender, EventArgs e)
        {
            combbDanToc.Items.Add("Kinh");
            combbDanToc.Items.Add("Hoa");
            combbDanToc.Items.Add("Khơ me");
            combbDanToc.Items.Add("H' Mong");
            combbDanToc.Items.Add("Khác");
            combbDanToc.SelectedIndex = 0;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (combbDanToc.SelectedIndex >= 0)
            {
                label2.Text = "Dân tộc được chọn là: " + combbDanToc.SelectedItem.ToString();
                label2.Visible = true;
                
            }
            else
            {
                label2.Text = "Có lỗi";
                label2.Visible = true;
            }
        }

        private void cbo_SelecteđIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn là: " + combbDanToc.SelectedItem.ToString());
        }
    }
}
