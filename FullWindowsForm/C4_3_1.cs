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
    public partial class C4_3_1 : Form
    {
        public C4_3_1()
        {
            InitializeComponent();
        }
        Dictionary<RadioButton, decimal> NuocUong;
        Dictionary<CheckBox, decimal> DoAn;
        private void C4_3_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void C4_3_1_Load(object sender, EventArgs e)
        {
            NuocUong = new Dictionary<RadioButton, decimal>()
            {
                {rdbCaPheDen, 20000},
                {rdbCaPheDa, 25000},
                {rdbCaPheSua, 25000},
                {rdbCaPheSuaDa, 30000},
                {rdbCaPheKem, 35000}
            };
            DoAn = new Dictionary<CheckBox, decimal>()
            {
                {ckbBanhMyTrung, 15000},
                {ckbBanhMyCa, 15000},
                {ckbMyTomTrung, 20000},
                {ckbMyXaoBo, 30000},
                {ckbMyCay, 50000}
            };
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            decimal tongKhachHang = 0;
            foreach (KeyValuePair<RadioButton, decimal> item in NuocUong)
            {
                if (item.Key.Checked)
                {
                    tongKhachHang += item.Value;
                }
            }
            foreach (KeyValuePair<CheckBox, decimal> item in DoAn)
            {
                if (item.Key.Checked)
                {
                    tongKhachHang += item.Value;
                }
            }
            txtTongKhachHang.Clear();
            txtTongKhachHang.Text += tongKhachHang;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Clear();
            txtTongKhachHang.Clear();
            txtTongTienThanhToan.Clear();
            txtSoKhachHang.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal tongThanhToan = 0;
            tongThanhToan = decimal.Parse(txtTongKhachHang.Text);
            if (ckbSinhVien.Checked)
            {
                tongThanhToan = tongThanhToan - tongThanhToan * 20 / 100;
            }
            txtTongTienThanhToan.Clear();
            txtTongTienThanhToan.Text += tongThanhToan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
