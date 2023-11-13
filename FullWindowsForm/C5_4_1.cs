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
            searchIndex = 0;
            

            string val = "";
            wordListDictionary.TryGetValue(cboTiengAnh.SelectedItem.ToString(), out val);
            txtTiengViet.Text = val;
            isFirst = true;
        }

        private List<string> wordFind = new List<string>();

        private int searchIndex = 0;

        private void txtCboTiengAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\b')
            {
                if (searchIndex > 0)
                {
                    searchIndex--;
                }
                else
                {
                    wordFind = new List<string>();
                    isFirst = true;
                }

            }
            if (e.KeyChar == '\r' && wordFind.Count > 0)
            {
                string val = "";
                wordListDictionary.TryGetValue(wordFind[0], out val);
                txtTiengViet.Text = val;
            }
            
        }

        private bool isFirst = true;

        private void txtCboTiengAnh_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            if (!isFirst)
            {
                for (int i = 0; i < wordFind.Count; i++)
                {
                    if (cboTiengAnh.Text[cboTiengAnh.Text.Length - 1] == wordFind[i].ToString()[searchIndex])
                    {
                        wordFind.Add(wordFind[i]);
                        wordFind = wordFind.Distinct().ToList();
                        
                    }
                }
                searchIndex++;
            }
            else
            {
                foreach (var VARIABLE in cboTiengAnh.Items)
                {
                    if (cboTiengAnh.Text.Length > 0)
                    {
                        if (cboTiengAnh.Text[cboTiengAnh.Text.Length - 1] == VARIABLE.ToString()[searchIndex])
                        {
                            wordFind.Add(VARIABLE.ToString());
                            wordFind = wordFind.Distinct().ToList();
                        }
                    }
                    else
                    {
                        isFirst = true;
                        break;
                    }
                }
                if (wordFind.Count != 0)
                {
                    isFirst = false;
                }
                else
                {
                    isFirst = true;
                }
                
            }
            
        }
    }
}
