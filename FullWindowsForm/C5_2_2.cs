using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C5_2_2 : Form
    {
        public C5_2_2()
        {
            InitializeComponent();
        }

        private void treeViewLop_Load()
        {
            treeViewLop.Nodes.Add("05DHTH1");
            treeViewLop.Nodes.Add("05DHTH2");
            treeViewLop.Nodes.Add("05DHTH3");
            treeViewLop.Nodes.Add("05DHTH4");
            foreach (TreeNode node in treeViewLop.Nodes)
            {
                cboChonLop.Items.Add(node.Text);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string s = txtMaSV.Text + ", " + txtHoTen.Text;
            int index = -1;
            foreach (TreeNode node in treeViewLop.Nodes)
            {
                if (node.Text == cboChonLop.SelectedItem.ToString())
                {
                    index = node.Index; break;
                }
            }
            foreach (TreeNode node in treeViewLop.Nodes[index].Nodes)
            {
                if (node.Text == s)
                {
                    MessageBox.Show("Sinh viên đã có trong lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            treeViewLop.Nodes[index].Nodes.Add(s).Nodes.Add(txtDiaChi.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xoá sinh viên đang chọn không ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                TreeNode selectedNode = treeViewLop.SelectedNode;
                if (selectedNode.Parent != null && selectedNode.Nodes.Count == 0)
                {
                    selectedNode.Remove();
                }
                else
                {
                    MessageBox.Show("Không thể xoá lớp đi được và chỉ xoá được cả học sinh thôi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeViewLop.Nodes)
            {
                if (node.Text == txtTenLop.Text)
                {
                    MessageBox.Show("Lớp đã có trong khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            treeViewLop.Nodes.Add(txtTenLop.Text);
        }

        private void C5_2_2_Load(object sender, EventArgs e)
        {
            treeViewLop_Load();
            groupBox2.Visible = false;
        }

        private void ckbThemLop_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbThemLop.Checked)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }
    }
}
