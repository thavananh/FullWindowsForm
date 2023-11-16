namespace FullWindowsForm
{
    partial class C6_1_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMaSinhVien = new TextBox();
            txtHoTen = new TextBox();
            listView1 = new ListView();
            colMsv = new ColumnHeader();
            colHoTen = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(93, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 60);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Họ tên";
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(81, 57);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(194, 23);
            txtMaSinhVien.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(81, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(194, 23);
            txtHoTen.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colMsv, colHoTen, columnHeader1 });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(479, 172);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colMsv
            // 
            colMsv.Text = "Mã số SV";
            colMsv.Width = 150;
            // 
            // colHoTen
            // 
            colHoTen.Text = "Họ và Tên";
            colHoTen.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 130;
            // 
            // C6_1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 318);
            Controls.Add(listView1);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSinhVien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "C6_1_2";
            Text = "C6_1_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label1;
        private Label label2;
        private TextBox txtMaSinhVien;
        private TextBox txtHoTen;
        private ListView listView1;
        private ColumnHeader colMsv;
        private ColumnHeader colHoTen;
        private ColumnHeader columnHeader1;
    }
}