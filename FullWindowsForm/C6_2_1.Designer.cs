namespace FullWindowsForm
{
    partial class C6_2_1
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            txtMaSinhVien = new TextBox();
            ckbAnh = new CheckBox();
            ckbPhap = new CheckBox();
            ckbHoa = new CheckBox();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            cboDanToc = new ComboBox();
            lstvSinhVien = new ListView();
            colHoTen = new ColumnHeader();
            colMaSinhVien = new ColumnHeader();
            colGioiTinh = new ColumnHeader();
            colNgoaiNgu = new ColumnHeader();
            colDanToc = new ColumnHeader();
            errorProvider1 = new ErrorProvider(components);
            ptcbThem = new PictureBox();
            lblThem = new Label();
            lblXoa = new Label();
            pctbXoa = new PictureBox();
            lblSua = new Label();
            pctbSua = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptcbThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbSua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 80);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 121);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngoại ngữ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 166);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Dân tộc";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(221, 8);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(266, 23);
            txtHoTen.TabIndex = 5;
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            txtHoTen.Leave += txtInput_Leave;
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(221, 39);
            txtMaSinhVien.Margin = new Padding(3, 2, 3, 2);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(266, 23);
            txtMaSinhVien.TabIndex = 6;
            txtMaSinhVien.KeyPress += txtMaSinhVien_KeyPress;
            txtMaSinhVien.Leave += txtInput_Leave;
            // 
            // ckbAnh
            // 
            ckbAnh.AutoSize = true;
            ckbAnh.Location = new Point(221, 120);
            ckbAnh.Margin = new Padding(3, 2, 3, 2);
            ckbAnh.Name = "ckbAnh";
            ckbAnh.Size = new Size(48, 19);
            ckbAnh.TabIndex = 7;
            ckbAnh.Text = "Anh";
            ckbAnh.UseVisualStyleBackColor = true;
            // 
            // ckbPhap
            // 
            ckbPhap.AutoSize = true;
            ckbPhap.Location = new Point(324, 120);
            ckbPhap.Margin = new Padding(3, 2, 3, 2);
            ckbPhap.Name = "ckbPhap";
            ckbPhap.Size = new Size(53, 19);
            ckbPhap.TabIndex = 8;
            ckbPhap.Text = "Pháp";
            ckbPhap.UseVisualStyleBackColor = true;
            // 
            // ckbHoa
            // 
            ckbHoa.AutoSize = true;
            ckbHoa.Location = new Point(436, 120);
            ckbHoa.Margin = new Padding(3, 2, 3, 2);
            ckbHoa.Name = "ckbHoa";
            ckbHoa.Size = new Size(48, 19);
            ckbHoa.TabIndex = 9;
            ckbHoa.Text = "Hoa";
            ckbHoa.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(221, 78);
            rdbNam.Margin = new Padding(3, 2, 3, 2);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 10;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(351, 78);
            rdbNu.Margin = new Padding(3, 2, 3, 2);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 11;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // cboDanToc
            // 
            cboDanToc.FormattingEnabled = true;
            cboDanToc.Location = new Point(221, 166);
            cboDanToc.Margin = new Padding(3, 2, 3, 2);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(266, 23);
            cboDanToc.TabIndex = 12;
            // 
            // lstvSinhVien
            // 
            lstvSinhVien.Columns.AddRange(new ColumnHeader[] { colHoTen, colMaSinhVien, colGioiTinh, colNgoaiNgu, colDanToc });
            lstvSinhVien.GridLines = true;
            lstvSinhVien.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lstvSinhVien.Location = new Point(7, 199);
            lstvSinhVien.Margin = new Padding(3, 2, 3, 2);
            lstvSinhVien.Name = "lstvSinhVien";
            lstvSinhVien.Size = new Size(606, 178);
            lstvSinhVien.TabIndex = 13;
            lstvSinhVien.UseCompatibleStateImageBehavior = false;
            lstvSinhVien.View = View.Details;
            // 
            // colHoTen
            // 
            colHoTen.Text = "Họ Tên";
            colHoTen.Width = 150;
            // 
            // colMaSinhVien
            // 
            colMaSinhVien.Text = "Mã Sinh Viên";
            colMaSinhVien.Width = 150;
            // 
            // colGioiTinh
            // 
            colGioiTinh.Text = "Giới Tính";
            colGioiTinh.Width = 80;
            // 
            // colNgoaiNgu
            // 
            colNgoaiNgu.Text = "Ngoại Ngữ";
            colNgoaiNgu.Width = 100;
            // 
            // colDanToc
            // 
            colDanToc.Text = "Dân Tộc";
            colDanToc.Width = 120;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ptcbThem
            // 
            ptcbThem.BackColor = Color.Transparent;
            ptcbThem.BackgroundImage = Properties.Resources.plus;
            ptcbThem.BackgroundImageLayout = ImageLayout.Stretch;
            ptcbThem.Location = new Point(113, 388);
            ptcbThem.Margin = new Padding(3, 2, 3, 2);
            ptcbThem.Name = "ptcbThem";
            ptcbThem.Size = new Size(41, 34);
            ptcbThem.TabIndex = 17;
            ptcbThem.TabStop = false;
            ptcbThem.Click += ptcbThem_Click;
            // 
            // lblThem
            // 
            lblThem.AutoSize = true;
            lblThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblThem.Location = new Point(159, 393);
            lblThem.Name = "lblThem";
            lblThem.Size = new Size(61, 25);
            lblThem.TabIndex = 18;
            lblThem.Text = "Thêm";
            lblThem.Click += lblThem_Click;
            // 
            // lblXoa
            // 
            lblXoa.AutoSize = true;
            lblXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblXoa.Location = new Point(312, 393);
            lblXoa.Name = "lblXoa";
            lblXoa.Size = new Size(46, 25);
            lblXoa.TabIndex = 20;
            lblXoa.Text = "Xoá";
            lblXoa.Click += lblXoa_Click;
            // 
            // pctbXoa
            // 
            pctbXoa.BackColor = Color.Transparent;
            pctbXoa.BackgroundImage = Properties.Resources.remove;
            pctbXoa.BackgroundImageLayout = ImageLayout.Stretch;
            pctbXoa.Location = new Point(266, 388);
            pctbXoa.Margin = new Padding(3, 2, 3, 2);
            pctbXoa.Name = "pctbXoa";
            pctbXoa.Size = new Size(41, 34);
            pctbXoa.TabIndex = 19;
            pctbXoa.TabStop = false;
            pctbXoa.Click += pctbXoa_Click;
            // 
            // lblSua
            // 
            lblSua.AutoSize = true;
            lblSua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSua.Location = new Point(461, 393);
            lblSua.Name = "lblSua";
            lblSua.Size = new Size(46, 25);
            lblSua.TabIndex = 22;
            lblSua.Text = "Sửa";
            lblSua.Click += lblSua_Click;
            // 
            // pctbSua
            // 
            pctbSua.BackColor = Color.Transparent;
            pctbSua.BackgroundImage = Properties.Resources.compose;
            pctbSua.BackgroundImageLayout = ImageLayout.Stretch;
            pctbSua.Location = new Point(415, 388);
            pctbSua.Margin = new Padding(3, 2, 3, 2);
            pctbSua.Name = "pctbSua";
            pctbSua.Size = new Size(41, 34);
            pctbSua.TabIndex = 21;
            pctbSua.TabStop = false;
            pctbSua.Click += pctbSua_Click;
            // 
            // C6_2_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 431);
            Controls.Add(lblSua);
            Controls.Add(pctbSua);
            Controls.Add(lblXoa);
            Controls.Add(pctbXoa);
            Controls.Add(lblThem);
            Controls.Add(ptcbThem);
            Controls.Add(lstvSinhVien);
            Controls.Add(cboDanToc);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(ckbHoa);
            Controls.Add(ckbPhap);
            Controls.Add(ckbAnh);
            Controls.Add(txtMaSinhVien);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "C6_2_1";
            Text = "C6_2_1";
            Load += C6_2_1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptcbThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbSua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHoTen;
        private TextBox txtMaSinhVien;
        private CheckBox ckbAnh;
        private CheckBox ckbPhap;
        private CheckBox ckbHoa;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private ComboBox cboDanToc;
        private ListView lstvSinhVien;
        private ColumnHeader colHoTen;
        private ColumnHeader colMaSinhVien;
        private ColumnHeader colGioiTinh;
        private ColumnHeader colNgoaiNgu;
        private ColumnHeader colDanToc;
        private ErrorProvider errorProvider1;
        private PictureBox ptcbThem;
        private Label lblSua;
        private PictureBox pctbSua;
        private Label lblXoa;
        private PictureBox pctbXoa;
        private Label lblThem;
    }
}