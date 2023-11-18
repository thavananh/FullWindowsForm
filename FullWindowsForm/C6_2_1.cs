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
    public partial class C6_2_1 : Form
    {
        public C6_2_1()
        {
            InitializeComponent();
        }

        private void C6_2_1_Load(object sender, EventArgs e)
        {
            cboDanToc_Load();
        }

        private void cboDanToc_Load()
        {
            cboDanToc.Items.Add("Kinh");
            cboDanToc.Items.Add("Hoa");
            cboDanToc.Items.Add("H'HMong");
            cboDanToc.SelectedIndex = 0;
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textBox, "Vui lòng nhập dữ liệu");
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        

        private void ptcbThem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem existingItem in lstvSinhVien.Items)
            {
                // Chỉ số '1' giả định rằng mã sinh viên nằm ở cột thứ hai (subitem đầu tiên).
                if (existingItem.SubItems.Count > 1 && existingItem.SubItems[1].Text == txtMaSinhVien.Text)
                {
                    MessageBox.Show("Mã sinh viên bạn nhập đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Assuming 'txtMaSinhVien' is a textbox where you input the student ID.

            ListViewItem item = new ListViewItem(txtHoTen.Text); // Assuming 'txtHoTen' is a textbox for the student's name.
            item.SubItems.Add(txtMaSinhVien.Text); // Adds the sub-item for student ID.
            item.SubItems.Add(rdbNam.Checked ? "Nam" : "Nữ"); // Adds the sub-item for gender.

            string subjects = "";
            if (ckbAnh.Checked) subjects += ckbAnh.Text + ' ';
            if (ckbHoa.Checked) subjects += ckbHoa.Text + ' ';
            if (ckbPhap.Checked) subjects += ckbPhap.Text + ' ';

            item.SubItems.Add(subjects); // Adds the sub-item for subjects.

            if (cboDanToc.SelectedItem != null)
            {
                item.SubItems.Add(cboDanToc.SelectedItem.ToString()); // Adds the sub-item for ethnicity.
            }
            else
            {
                item.SubItems.Add("Not selected"); // Default text if no ethnicity is selected.
            }
            lstvSinhVien.Items.Add(item);
        }
        private void pctbSua_Click(object sender, EventArgs e)
        {
            

            if (lstvSinhVien.FocusedItem != null && lstvSinhVien.FocusedItem.Index >= 0)
            {
                ListViewItem item = lstvSinhVien.FocusedItem;
                item.Text = txtHoTen.Text;
                item.SubItems[1].Text = txtMaSinhVien.Text;
                item.SubItems[2].Text = rdbNam.Checked ? "Nam" : "Nữ";

                string subjects = "";
                if (ckbAnh.Checked) subjects += ckbAnh.Text + ' ';
                if (ckbHoa.Checked) subjects += ckbHoa.Text + ' ';
                if (ckbPhap.Checked) subjects += ckbPhap.Text + ' ';

                item.SubItems[3].Text = subjects;
                item.SubItems[4].Text = cboDanToc.SelectedItem.ToString();
            }
        }

        private void lblXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvSinhVien.Items)
            {
                item.Remove();
            }
        }

        private void pctbXoa_Click(object sender, EventArgs e)
        {
            lblXoa_Click(sender, e);
        }

        private void lblThem_Click(object sender, EventArgs e)
        {
            ptcbThem_Click(sender, e);
        }

        private void lblSua_Click(object sender, EventArgs e)
        {
        }
    }
}
