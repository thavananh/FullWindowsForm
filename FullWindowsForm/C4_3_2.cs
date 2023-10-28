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
    public partial class C4_3_2 : Form
    {
        public C4_3_2()
        {
            InitializeComponent();
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
            txtHoTen.TextChanged += txt_TextChanged;
            txtDiaChi.TextChanged += txt_TextChanged;
            txtSoNgayO.TextChanged += txt_TextChanged;
            foreach (Control c in groupBoxLoaiPhong.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)c;
                    radiobutton.CheckedChanged += CkbAndRdb_CheckChanged;
                }
            }
            foreach (Control c in groupBoxTienNghi1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)c;
                    checkbox.CheckedChanged += CkbAndRdb_CheckChanged;
                }
            }
            foreach (Control c in groupBoxTienNghi2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)c;
                    checkbox.CheckedChanged += CkbAndRdb_CheckChanged;
                }
            }
        }
        Dictionary<RadioButton, decimal> LoaiPhong;
        Dictionary<CheckBox, decimal> TienNghi1;
        Dictionary<CheckBox, decimal> TienNghi2;
        int soluotNguoi = 0;
        decimal tongSoTien = 0;
        private void C4_3_2_Load(object sender, EventArgs e)
        {
            
            LoaiPhong = new Dictionary<RadioButton, decimal>()
            {
                {rdbPhongDon, 300000},
                {rdbPhongDoi, 350000},
                {rdbPhongBa, 400000}
            };
            TienNghi1 = new Dictionary<CheckBox, decimal>()
            {
                {ckbTivi, 10000},
                {ckbInternet, 10000},
                {ckbMayNuocNong, 10000}
            };
            TienNghi2 = new Dictionary<CheckBox, decimal>()
            {
                {ckbKaraoke, 50000},
                {ckbAnSang, 15000}
            };
        }
        private void updateBtnAndCkbState()
        {
            bool b1 = false, b2 = false, b3 = false;
            foreach (Control c in groupBoxLoaiPhong.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)c;
                    if (radiobutton.Checked)
                    {
                        b1 = true;
                    }
                }
            }
            foreach (Control c in groupBoxTienNghi1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    if (ckb.Checked)
                    {
                        b2 = true;
                    }
                }
            }
            foreach (Control c in groupBoxTienNghi2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    if (ckb.Checked)
                    {
                        b3 = true;
                    }
                }
            }
            btnThanhToan.Enabled = !String.IsNullOrWhiteSpace(txtHoTen.Text) && !String.IsNullOrWhiteSpace(txtDiaChi.Text) && !String.IsNullOrWhiteSpace(txtSoNgayO.Text) && b1 && b2 && b3;
            btnNhapMoi.Enabled = btnThanhToan.Enabled;
            btnTongKet.Enabled = btnThanhToan.Enabled;
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            updateBtnAndCkbState();
        }
        private void CkbAndRdb_CheckChanged(object sender, EventArgs e)
        {
            updateBtnAndCkbState();
        }
        decimal thanhTien = 0;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<RadioButton, decimal> item in LoaiPhong)
            {
                if (item.Key.Checked)
                {
                    thanhTien += item.Value;
                }
            }
            foreach (KeyValuePair<CheckBox, decimal> item in TienNghi1)
            {
                if (item.Key.Checked)
                {
                    thanhTien += item.Value;
                }
            }
            foreach (KeyValuePair<CheckBox, decimal> item in TienNghi2)
            {
                if (item.Key.Checked)
                {
                    if (item.Key.Name == "ckbAnSang")
                    {
                        thanhTien += item.Value * int.Parse(txtSoNgayO.Text);
                    }
                    else
                    {
                        thanhTien += item.Value;
                    }
                }
            }
            soluotNguoi++;
            txtThanhTien.Clear();
            txtThanhTien.Text += thanhTien;
            tongSoTien += thanhTien;
            thanhTien = 0;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtThanhTien.Clear();
            txtSoNgayO.Clear();
            txtDiaChi.Clear();
            txtHoTen.Clear();
            foreach (Control c in groupBoxLoaiPhong.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)c;
                    radiobutton.Checked = false;
                }
            }
            foreach (Control c in groupBoxTienNghi1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)c;
                    checkbox.Checked = false;
                }
            }
            foreach (Control c in groupBoxTienNghi2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)c;
                    checkbox.Checked = false;
                }
            }
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuotNguoi.Clear();
            txtSoLuotNguoi.Text += soluotNguoi;
            txtTongSoTien.Clear();
            txtTongSoTien.Text += tongSoTien;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
