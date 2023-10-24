using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace FullWindowsForm
{
    public partial class C7_1_1 : Form
    {
        string s = "Data Source=DUYHCMUE;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlConnection conn;
        public C7_1_1()
        {
            conn = new SqlConnection(s); 
            InitializeComponent();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString;
                insertString = "insert into Khoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string updateString;
                updateString = "update Khoa set TenKhoa='" + txtTenKhoa.Text + "' where MaKhoa='" + txtTenKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString = "delete Khoa where MaKhoa='" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
