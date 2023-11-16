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
    public partial class C6_1_3 : Form
    {
        public C6_1_3()
        {
            InitializeComponent();
        }

        private void C6_1_3_Load(object sender, EventArgs e)
        {

        }

        private void saveChat_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveChatDialog = new SaveFileDialog();
            saveChatDialog.Filter = "Text files | *.txt";
            if (saveChatDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = saveChatDialog.FileName;
                StreamWriter sw = new StreamWriter(fileName);
                sw.Write(rtxtChat.Text);
                MessageBox.Show($"File được lưu trong {fileName}");
                sw.Close();
            }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            openFile.Filter = "All text file (*.txt)|*.txt|All Document (*.pdf)|*.pdf";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFile.FileName;
                StreamReader f = new StreamReader(txtFilePath.Text);
                rtxtChat.Text = f.ReadToEnd();
                f.Close();
            }
        }
    }
}
