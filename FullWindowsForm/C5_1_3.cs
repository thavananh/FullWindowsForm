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
    public partial class C5_1_3 : Form
    {
        public C5_1_3()
        {
            InitializeComponent();

        }

        private void C5_1_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        private void C5_1_3_Load(object sender, EventArgs e)
        {
            TreeView_Load();
        }
        private void TreeView_Load()
        {
            string[] pb = { "Giám đốc", "Tổ chức tài chính", "Kế Hoạch", "Kế Toán" };
            foreach (string element in pb)
            {
                treeView1.Nodes.Add(element);
                cboPhongBan.Items.Add(element);
            }
            cboPhongBan.SelectedIndex = 0;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == cboPhongBan.Text)
                {
                    index = node.Index;
                    break;
                }
            }
            string s = txtHoTen.Text + " (" + txtMaSo.Text + ")";
            treeView1.Nodes[index].Nodes.Add(s);
        }

        private void btnXoaPhongBan_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == txtPhongBan.Text)
                {
                    treeView1.Nodes.Remove(node);
                }
            }
            cboPhongBan.Items.Remove(txtPhongBan.Text);
        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtPhongBan.Text);
            cboPhongBan.Items.Add(txtPhongBan.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
