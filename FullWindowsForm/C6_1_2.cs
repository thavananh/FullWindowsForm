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
    public partial class C6_1_2 : Form
    {
        public C6_1_2()
        {
            InitializeComponent();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            bool found1 = false;
            foreach (ListViewItem itemLoop in listView1.Items)
            {
                string val = itemLoop.SubItems[0].Text;
                if (val == txtMaSinhVien.Text)
                {
                    found1 = true;
                }
            }
            if (found1)
            {
                MessageBox.Show("Mã sinh viên bạn nhập đã tồn tại");
                return;
            }
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            item.Text = txtMaSinhVien.Text;
            subItem.Text = txtHoTen.Text;
            ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
            subItem1.Text = "Sống vui";
            item.SubItems.Add(subItem);
            item.SubItems.Add(subItem1);
            listView1.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listView1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null && listView1.FocusedItem.Index >= 0)
            {
                ListViewItem item = listView1.FocusedItem;
                item.SubItems[0].Text = txtMaSinhVien.Text;
                item.SubItems[1].Text = txtHoTen.Text;
            }
        }
    }
}
