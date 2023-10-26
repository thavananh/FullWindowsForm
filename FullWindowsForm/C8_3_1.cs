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
    public partial class C8_3_1 : Form
    {
        string s = "Data Source=DUYHCMUE;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlConnection conn;
        public C8_3_1()
        {
            conn = new SqlConnection(s);
            InitializeComponent();
        }

        private void btnHienThiDuLieu_Click(object sender, EventArgs e)
        {
            
        }
            
    }
}
