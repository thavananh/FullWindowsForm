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
    public partial class C5_3_1 : Form
    {
        public C5_3_1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> Ho;
        Dictionary<int, string> Lot;
        Dictionary<int, string> Dem;
        Dictionary<int, string> Ten;

        private void dictionaryLoad()
        {
            Ho = new Dictionary<int, string>()
            {
                {1, "Nguyễn"},
                {2, "Lê"},
                {3, "Tăng"},
                {4, "Lê"},
                {5, "Lê"}
            };
            Lot = new Dictionary<int, string>()
            {
                {1, "Võ"},
                {2, "Thuỳ"},
                {3, "Đỗ"},
                {4, "Hồng"},
                {5, "Huỳnh"}
            };
            Dem = new Dictionary<int, string>()
            {
                {1, "Bửu"},
                {2, "Bảo"},
                {3, "Gia"},
                {4, "Như"},
                {5, "Minh"}
            };
            Ten = new Dictionary<int, string>()
            {
                {1, "Sơn"},
                {2, "Sơn"},
                {3, "Duyên"},
                {4, "Sơn"},
                {5, "Châu"}

            };
        }
        private void btnNhapTenNgauNhien_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6); //random từ 1 đến 5
            string s = "";
            string tmp = "";
            Ho.TryGetValue(randomNumber, out tmp);
            s += tmp + " ";
            int randomBool = random.Next(0, 2);
            if (randomBool == 1)
            {
                Lot.TryGetValue(randomNumber, out tmp);
                s += tmp + " ";
            }
            randomNumber = random.Next(1, 6);
            Dem.TryGetValue(randomNumber, out tmp);
            s += tmp + " ";
            randomNumber = random.Next(1, 6);
            Ten.TryGetValue(randomNumber, out tmp);
            s += tmp;
            listBox1.Items.Add(s);
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show("Vui lòng chọn tên để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnXoaPhanTuTenLaSon_Click(Object sender, EventArgs e)
        {
            for (int a = listBox1.Items.Count - 1; a >= 0; a--)
            {
                string[] tmp = listBox1.Items[a].ToString().Split(' ');
                if (tmp[tmp.Length - 1] == "Sơn")
                {
                    listBox1.Items.RemoveAt(a);
                }
            }
        }

        private void C5_3_1_Load(object sender, EventArgs e)
        {
            btnNhapTenNgauNhien.Click += btnNhapTenNgauNhien_Click;
            btnXoaPhanTuDangChon.Click += btnXoaPhanTuDangChon_Click;
            btnXoaPhanTuCoTenLaSon.Click += btnXoaPhanTuTenLaSon_Click;
            btnXoaPhanTuCoHoLaLe.Click += btnXoaPhanTuCoHoLaLe_Click;
            btnChuyenPTDangChonThanhChuThuong.Click += btnChuyenPTDangChonThanhChuThuong_Click;
            btnChuyenPTDangChonLaChuHoa.Click += btnChuyenPTDangChonThanhChuHoa_Click;
            btnChuyenPTDangChonThanhVietHoaDauMoiTu.Click += btnChuyenPhanTuDangChonThanhChuHoaMoiTu_Click;
            dictionaryLoad();
        }

        private void btnXoaPhanTuCoHoLaLe_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string[] tmp = listBox1.Items[i].ToString().Split(' ');
                if (tmp[0] == "Lê")
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
        }

        private void btnChuyenPTDangChonThanhChuHoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // 1. Lấy danh sách hiện tại từ ListBox.
                List<string> items = listBox1.Items.Cast<string>().ToList();

                // 2. Cập nhật item đã chọn.
                items[listBox1.SelectedIndex] = items[listBox1.SelectedIndex].ToUpper();

                // 3. Cập nhật lại DataSource.
                listBox1.DataSource = null; // Thiết lập DataSource thành null trước để đảm bảo việc cập nhật.
                listBox1.DataSource = items;
            }
        }

        private void btnChuyenPTDangChonThanhChuThuong_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // 1. Lấy danh sách hiện tại từ ListBox.
                List<string> items = listBox1.Items.Cast<string>().ToList();

                // 2. Cập nhật item đã chọn.
                items[listBox1.SelectedIndex] = items[listBox1.SelectedIndex].ToLower();

                // 3. Cập nhật lại DataSource.
                listBox1.DataSource = null; // Thiết lập DataSource thành null trước để đảm bảo việc cập nhật.
                listBox1.DataSource = items;
            }
        }
        private void btnChuyenPhanTuDangChonThanhChuHoaMoiTu_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // 1. Lấy danh sách hiện tại từ ListBox.
                List<string> items = listBox1.Items.Cast<string>().ToList();

                string[] tmp = items[listBox1.SelectedIndex].ToString().Split(' ');
                for (int i = 0; i < tmp.Length; i++)
                {
                    tmp[i] = char.ToUpper(tmp[i][0]) + tmp[i].Substring(1).ToLower();
                }
                // 2. Cập nhật item đã chọn.
                items[listBox1.SelectedIndex] = string.Join(" ", tmp);

                // 3. Cập nhật lại DataSource.
                listBox1.DataSource = null; // Thiết lập DataSource thành null trước để đảm bảo việc cập nhật.
                listBox1.DataSource = items;
            }
        }
    }
}