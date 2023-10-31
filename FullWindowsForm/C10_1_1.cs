using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsForm
{
    public partial class C10_1_1 : Form
    {
        SqlConnection conn;
        DataSet ds_QLSV = new DataSet();
        public C10_1_1()
        {
            conn = new SqlConnection("Data Source = DUYHCMUE; Initial Catalog = QLSinhVien; Integrated Security = True");
            InitializeComponent();
        }

        void loadDuLieuKhoa()
        {
            string strsel = "select * from Khoa";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(strsel, conn);
            da_Khoa.Fill(ds_QLSV, "Khoa");
            dataGridView1.DataSource = ds_QLSV.Tables["Khoa"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLSV.Tables["Khoa"].Columns[0];
            ds_QLSV.Tables["Khoa"].PrimaryKey = key;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = true;
                }
            }
            btnLuu.Enabled = true;
            txtMaKhoa.Focus();
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }
        private void dgv_Khoa_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                DataTable dt_lop = new DataTable();
                SqlDataAdapter da_Khoa = new SqlDataAdapter("select * from Lop where makhoa= '" + txtMaKhoa.Text + "'", conn);
                da_Khoa.Fill(dt_lop);
                if (dt_lop.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xoá");
                    return;
                }
                DataRow update_New = ds_QLSV.Tables["Khoa"].Rows.Find(txtMaKhoa.Text);
                if (update_New != null)
                {
                    update_New.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder();
                da_Khoa.Update(ds_QLSV, "Khoa");
                MessageBox.Show("Thành công");
            }
 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtMaKhoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập Mã Khoa");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập Tên Khoa");
                txtTenKhoa.Focus();
                return;
            }
            if (txtMaKhoa.Enabled == true)
            {
                DataRow insert_New = ds_QLSV.Tables["Khoa"].NewRow();
                insert_New["MaKhoa"] = txtMaKhoa.Text;
                insert_New["TenKhoa"] = txtTenKhoa.Text;
                ds_QLSV.Tables["Khoa"].Rows.Add(insert_New);
            }
            else
            {
                DataRow update_New = ds_QLSV.Tables["Khoa"].Rows.Find(txtMaKhoa.Text);
                if (update_New != null)
                {
                    update_New["TenKhoa"] = txtTenKhoa.Text;
                }
            }
            string strsel = "select * from Khoa";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(strsel, conn);
            da_Khoa.Fill(ds_QLSV, "Khoa");
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_Khoa);
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void C10_1_1_Load(object sender, EventArgs e)
        {
            loadDuLieuKhoa();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = false;
                }
            }
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dataGridView1.SelectionChanged += dgv_Khoa_SelectionChanged;
        }
    }
}
