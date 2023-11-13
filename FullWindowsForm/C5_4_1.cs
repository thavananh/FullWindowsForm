using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FullWindowsForm
{
    public partial class C5_4_1 : Form
    {
        public C5_4_1()
        {
            InitializeComponent();
        }

        private void btnVietAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnAnhViet_Click(object sender, EventArgs e)
        {
        }

        private void C5_4_1_Load(object sender, EventArgs e)
        {
            loadTuVung();
        }

        private Dictionary<string, string> wordListDictionary = new Dictionary<string, string>()
        {
            {"student", "Sinh viên, học sinh"},
            {"teacher", "Giáo viên, giảng viên"},
            {"worker", "Công nhân, nhân viên"},
            {"dog", "chó"},
            {"puppy", "cún"},
            {"cat", "mèo"},
            {"snake", "rắn"},
            {"women", "phụ nữ"},
            {"man", "đàn ông"},
            {"sheep", "con cừu"},
        };

        void loadTuVung()
        {
            foreach (var VARIABLE in wordListDictionary)
            {
                cboTiengAnh.Items.Add(VARIABLE.Key);
            }
        }

        private void cboTiengAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTiengViet.Text = wordListDictionary[cboTiengAnh.SelectedItem.ToString()];
        }

        private List<string> wordFind = new List<string>();

        private void txtCboTiengAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
                if (cboTiengAnh.Text.Length == 0)
                {
                    MessageBox.Show("Bạn nhập từ không tồn tại");
                }
                else
                {
                    if (wordFind.Count == 0)
                    {
                        MessageBox.Show("Bạn nhập từ không tồn tại");
                    }
                    else
                    {
                        txtTiengViet.Text = wordListDictionary[wordFind[0]];
                    }
                    
                }
            }
        }

        private void txtCboTiengAnh_TextChanged(object sender, EventArgs e)
        {
            if (cboTiengAnh.Text.Length != 0)
            {
                List<string> tmp = new List<string>();
                tmp = wordFind;
                wordFind = new List<string>();
                if (tmp.Count > 0 && cboTiengAnh.Text.Length > 1)
                {
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        bool b1 = false;
                        for (int j = 0; j < cboTiengAnh.Text.Length; j++)
                        {
                            if (tmp[i].Length >= cboTiengAnh.Text.Length)
                            {
                                if (tmp[i][j] != cboTiengAnh.Text[j])
                                {
                                    b1 = true;
                                    break;
                                }
                            }
                            else
                            {
                                b1 = true;
                                break;
                            }
                        }
                        if (!b1)
                        {
                            wordFind.Add(tmp[i]);
                        }
                    }
                }
                else
                {
                    foreach (var VARIABLE in cboTiengAnh.Items)
                    {
                        if (VARIABLE.ToString()[0] == cboTiengAnh.Text[0])
                        {
                            wordFind.Add(VARIABLE.ToString());
                        }
                    }
                }
            }
            else
            {
                wordFind = new List<string>();
            }
        }
    }
}
