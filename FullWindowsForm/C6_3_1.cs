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
    public partial class C6_3_1 : Form
    {
        public C6_3_1()
        {
            InitializeComponent();
        }

        private void C6_3_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void addItemVaoLopAVaB()
        {
            lstbLopA.Items.Add("Trần Hùng");
            lstbLopA.Items.Add("Nguyễn Hưng");
            lstbLopA.Items.Add("Lâm Tứ");
            lstbLopB.Items.Add("Tuấn Hưng");
            lstbLopB.Items.Add("Hồng Ngọc");
            lstbLopB.Items.Add("Anh Minh");
            lstbLopB.Items.Add("Bảo Lâm");
        }

        private void endMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void mnst_InputHocVienMoi_Click(object sender, EventArgs e)
        {
            C6_3_1_1 frmC6_3_1_1 = new C6_3_1_1();
            frmC6_3_1_1.Show();
            this.Hide();
            C6_3_1_1.isOpenForm;
        }

        private void mnst_ChuyenSangLopB_Click(object sender, EventArgs e)
        {
            for (int i = lstbLopB.Items.Count - 1; i >= 0; i--)
            {
                if (lstbLopB.GetSelected(i))
                {
                    lstbLopA.Items.Add(lstbLopB.Items[i]);
                    lstbLopB.Items.RemoveAt(i);
                }
            }
        }

        private void mnst_ChuyenSangLopA_Click(object sender, EventArgs e)
        {
            for (int i = lstbLopA.Items.Count - 1; i >= 0; i--)
            {
                if (lstbLopA.GetSelected(i))
                {
                    lstbLopB.Items.Add(lstbLopA.Items[i]);
                    lstbLopA.Items.RemoveAt(i);
                }
            }
        }

        private void mnst_XoaHocVien_Click(object sender, EventArgs e)
        {
            for (int i = lstbLopA.Items.Count - 1; i >= 0; i--)
            {
                if (lstbLopA.GetSelected(i))
                {
                    lstbLopA.Items.RemoveAt(i);
                }
            }

            for (int i = lstbLopB.Items.Count - 1; i >= 0; i--)
            {
                if (lstbLopB.GetSelected(i))
                {
                    lstbLopB.Items.RemoveAt(i);
                }
            }
        }
    }
}
