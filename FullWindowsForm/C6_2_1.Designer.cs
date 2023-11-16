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
            comboBox1 = new ComboBox();
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
            label1.Location = new Point(97, 13);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 55);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 106);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 161);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngoại ngữ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Dân tộc";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(197, 10);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(304, 27);
            txtHoTen.TabIndex = 5;
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            txtHoTen.Leave += txtInput_Leave;
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(197, 52);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(304, 27);
            txtMaSinhVien.TabIndex = 6;
            txtMaSinhVien.KeyPress += txtMaSinhVien_KeyPress;
            txtMaSinhVien.Leave += txtInput_Leave;
            // 
            // ckbAnh
            // 
            ckbAnh.AutoSize = true;
            ckbAnh.Location = new Point(197, 160);
            ckbAnh.Name = "ckbAnh";
            ckbAnh.Size = new Size(57, 24);
            ckbAnh.TabIndex = 7;
            ckbAnh.Text = "Anh";
            ckbAnh.UseVisualStyleBackColor = true;
            // 
            // ckbPhap
            // 
            ckbPhap.AutoSize = true;
            ckbPhap.Location = new Point(314, 160);
            ckbPhap.Name = "ckbPhap";
            ckbPhap.Size = new Size(64, 24);
            ckbPhap.TabIndex = 8;
            ckbPhap.Text = "Pháp";
            ckbPhap.UseVisualStyleBackColor = true;
            // 
            // ckbHoa
            // 
            ckbHoa.AutoSize = true;
            ckbHoa.Location = new Point(442, 160);
            ckbHoa.Name = "ckbHoa";
            ckbHoa.Size = new Size(59, 24);
            ckbHoa.TabIndex = 9;
            ckbHoa.Text = "Hoa";
            ckbHoa.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(197, 104);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 10;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(345, 104);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 11;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 28);
            comboBox1.TabIndex = 12;
            // 
            // lstvSinhVien
            // 
            lstvSinhVien.Columns.AddRange(new ColumnHeader[] { colHoTen, colMaSinhVien, colGioiTinh, colNgoaiNgu, colDanToc });
            lstvSinhVien.GridLines = true;
            lstvSinhVien.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lstvSinhVien.Location = new Point(12, 265);
            lstvSinhVien.Name = "lstvSinhVien";
            lstvSinhVien.Size = new Size(614, 236);
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
            ptcbThem.Location = new Point(97, 517);
            ptcbThem.Name = "ptcbThem";
            ptcbThem.Size = new Size(47, 46);
            ptcbThem.TabIndex = 17;
            ptcbThem.TabStop = false;
            ptcbThem.Click += ptcbThem_Click;
            // 
            // lblThem
            // 
            lblThem.AutoSize = true;
            lblThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblThem.Location = new Point(150, 524);
            lblThem.Name = "lblThem";
            lblThem.Size = new Size(74, 31);
            lblThem.TabIndex = 18;
            lblThem.Text = "Thêm";
            lblThem.Click += lblThem_Click;
            // 
            // lblXoa
            // 
            lblXoa.AutoSize = true;
            lblXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblXoa.Location = new Point(325, 524);
            lblXoa.Name = "lblXoa";
            lblXoa.Size = new Size(55, 31);
            lblXoa.TabIndex = 20;
            lblXoa.Text = "Xoá";
            lblXoa.Click += lblXoa_Click;
            // 
            // pctbXoa
            // 
            pctbXoa.BackColor = Color.Transparent;
            pctbXoa.BackgroundImage = Properties.Resources.remove;
            pctbXoa.BackgroundImageLayout = ImageLayout.Stretch;
            pctbXoa.Location = new Point(272, 517);
            pctbXoa.Name = "pctbXoa";
            pctbXoa.Size = new Size(47, 46);
            pctbXoa.TabIndex = 19;
            pctbXoa.TabStop = false;
            pctbXoa.Click += pctbXoa_Click;
            // 
            // lblSua
            // 
            lblSua.AutoSize = true;
            lblSua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSua.Location = new Point(495, 524);
            lblSua.Name = "lblSua";
            lblSua.Size = new Size(54, 31);
            lblSua.TabIndex = 22;
            lblSua.Text = "Sửa";
            lblSua.Click += lblSua_Click;
            // 
            // pctbSua
            // 
            pctbSua.BackColor = Color.Transparent;
            pctbSua.BackgroundImage = Properties.Resources.compose;
            pctbSua.BackgroundImageLayout = ImageLayout.Stretch;
            pctbSua.Location = new Point(442, 517);
            pctbSua.Name = "pctbSua";
            pctbSua.Size = new Size(47, 46);
            pctbSua.TabIndex = 21;
            pctbSua.TabStop = false;
            pctbSua.Click += pctbSua_Click;
            // 
            // C6_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 575);
            Controls.Add(lblSua);
            Controls.Add(pctbSua);
            Controls.Add(lblXoa);
            Controls.Add(pctbXoa);
            Controls.Add(lblThem);
            Controls.Add(ptcbThem);
            Controls.Add(lstvSinhVien);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
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