namespace FullWindowsForm
{
    partial class C6_2_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSoTaiKhoan = new TextBox();
            txtTenKhachHang = new TextBox();
            txtDiaChiKhachHang = new TextBox();
            txtSoTienTaiKhoan = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lstvKhachHang = new ListView();
            colSTT = new ColumnHeader();
            colSoTaiKhoan = new ColumnHeader();
            colTenKhachHang = new ColumnHeader();
            colDiaChi = new ColumnHeader();
            colSoTien = new ColumnHeader();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(121, 9);
            label1.Name = "label1";
            label1.Size = new Size(479, 40);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 92);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 128);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 3;
            label4.Text = "Địch chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 164);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(213, 57);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(466, 23);
            txtSoTaiKhoan.TabIndex = 5;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(213, 91);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(466, 23);
            txtTenKhachHang.TabIndex = 6;
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Location = new Point(213, 127);
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(466, 23);
            txtDiaChiKhachHang.TabIndex = 7;
            // 
            // txtSoTienTaiKhoan
            // 
            txtSoTienTaiKhoan.Location = new Point(213, 167);
            txtSoTienTaiKhoan.Name = "txtSoTienTaiKhoan";
            txtSoTienTaiKhoan.Size = new Size(466, 23);
            txtSoTienTaiKhoan.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(342, 196);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 26);
            btnThem.TabIndex = 9;
            btnThem.Tag = "1";
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(429, 196);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 26);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(516, 196);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(603, 196);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 26);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstvKhachHang
            // 
            lstvKhachHang.Columns.AddRange(new ColumnHeader[] { colSTT, colSoTaiKhoan, colTenKhachHang, colDiaChi, colSoTien });
            lstvKhachHang.GridLines = true;
            lstvKhachHang.Location = new Point(12, 228);
            lstvKhachHang.Name = "lstvKhachHang";
            lstvKhachHang.Size = new Size(697, 210);
            lstvKhachHang.TabIndex = 13;
            lstvKhachHang.UseCompatibleStateImageBehavior = false;
            lstvKhachHang.View = View.Details;
            lstvKhachHang.SelectedIndexChanged += lstvKhachHang_SelectedIndexChanged;
            // 
            // colSTT
            // 
            colSTT.Text = "STT";
            // 
            // colSoTaiKhoan
            // 
            colSoTaiKhoan.Text = "Số tài khoản";
            colSoTaiKhoan.Width = 120;
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.Text = "Tên khách hàng";
            colTenKhachHang.Width = 180;
            // 
            // colDiaChi
            // 
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 150;
            // 
            // colSoTien
            // 
            colSoTien.Text = "Số tiền";
            colSoTien.Width = 180;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C6_2_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(lstvKhachHang);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(txtSoTienTaiKhoan);
            Controls.Add(txtDiaChiKhachHang);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "C6_2_2";
            Text = "C6_2_2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChiKhachHang;
        private TextBox txtSoTienTaiKhoan;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lstvKhachHang;
        private ColumnHeader colSTT;
        private ColumnHeader colSoTaiKhoan;
        private ColumnHeader colTenKhachHang;
        private ColumnHeader colDiaChi;
        private ColumnHeader colSoTien;
        private ErrorProvider errorProvider1;
    }
}