namespace FullWindowsForm
{
    partial class C4_3_1
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
            label1 = new Label();
            txtTenKhachHang = new TextBox();
            txtSoKhachHang = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ckbSinhVien = new CheckBox();
            groupBox1 = new GroupBox();
            rdbCaPheKem = new RadioButton();
            rdbCaPheDa = new RadioButton();
            rdbCaPheSuaDa = new RadioButton();
            rdbCaPheSua = new RadioButton();
            rdbCaPheDen = new RadioButton();
            groupBox2 = new GroupBox();
            ckbMyCay = new CheckBox();
            ckbMyXaoBo = new CheckBox();
            ckbMyTomTrung = new CheckBox();
            ckbBanhMyCa = new CheckBox();
            ckbBanhMyTrung = new CheckBox();
            btnTinhTien = new Button();
            btnNhapLai = new Button();
            btnThanhToan = new Button();
            btnThoat = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTongKhachHang = new TextBox();
            txtTongTienThanhToan = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Cà Phê Sinh Viên";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(195, 42);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(401, 27);
            txtTenKhachHang.TabIndex = 1;
            // 
            // txtSoKhachHang
            // 
            txtSoKhachHang.Location = new Point(195, 94);
            txtSoKhachHang.Name = "txtSoKhachHang";
            txtSoKhachHang.Size = new Size(401, 27);
            txtSoKhachHang.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 94);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Số khách hàng";
            // 
            // ckbSinhVien
            // 
            ckbSinhVien.AutoSize = true;
            ckbSinhVien.Location = new Point(195, 136);
            ckbSinhVien.Name = "ckbSinhVien";
            ckbSinhVien.Size = new Size(101, 24);
            ckbSinhVien.TabIndex = 5;
            ckbSinhVien.Text = "Sinh viên ?";
            ckbSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbCaPheKem);
            groupBox1.Controls.Add(rdbCaPheDa);
            groupBox1.Controls.Add(rdbCaPheSuaDa);
            groupBox1.Controls.Add(rdbCaPheSua);
            groupBox1.Controls.Add(rdbCaPheDen);
            groupBox1.Location = new Point(62, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nước uống";
            // 
            // rdbCaPheKem
            // 
            rdbCaPheKem.AutoSize = true;
            rdbCaPheKem.Location = new Point(115, 56);
            rdbCaPheKem.Name = "rdbCaPheKem";
            rdbCaPheKem.Size = new Size(92, 24);
            rdbCaPheKem.TabIndex = 4;
            rdbCaPheKem.TabStop = true;
            rdbCaPheKem.Text = "Cafe kem";
            rdbCaPheKem.UseVisualStyleBackColor = true;
            // 
            // rdbCaPheDa
            // 
            rdbCaPheDa.AutoSize = true;
            rdbCaPheDa.Location = new Point(115, 26);
            rdbCaPheDa.Name = "rdbCaPheDa";
            rdbCaPheDa.Size = new Size(81, 24);
            rdbCaPheDa.TabIndex = 3;
            rdbCaPheDa.TabStop = true;
            rdbCaPheDa.Text = "Cafe đá";
            rdbCaPheDa.UseVisualStyleBackColor = true;
            // 
            // rdbCaPheSuaDa
            // 
            rdbCaPheSuaDa.AutoSize = true;
            rdbCaPheSuaDa.Location = new Point(6, 86);
            rdbCaPheSuaDa.Name = "rdbCaPheSuaDa";
            rdbCaPheSuaDa.Size = new Size(108, 24);
            rdbCaPheSuaDa.TabIndex = 2;
            rdbCaPheSuaDa.TabStop = true;
            rdbCaPheSuaDa.Text = "Cafe sữa đá";
            rdbCaPheSuaDa.UseVisualStyleBackColor = true;
            // 
            // rdbCaPheSua
            // 
            rdbCaPheSua.AutoSize = true;
            rdbCaPheSua.Location = new Point(6, 56);
            rdbCaPheSua.Name = "rdbCaPheSua";
            rdbCaPheSua.Size = new Size(87, 24);
            rdbCaPheSua.TabIndex = 1;
            rdbCaPheSua.TabStop = true;
            rdbCaPheSua.Text = "Cafe sữa";
            rdbCaPheSua.UseVisualStyleBackColor = true;
            // 
            // rdbCaPheDen
            // 
            rdbCaPheDen.AutoSize = true;
            rdbCaPheDen.Location = new Point(6, 26);
            rdbCaPheDen.Name = "rdbCaPheDen";
            rdbCaPheDen.Size = new Size(89, 24);
            rdbCaPheDen.TabIndex = 0;
            rdbCaPheDen.TabStop = true;
            rdbCaPheDen.Text = "Cafe đen";
            rdbCaPheDen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckbMyCay);
            groupBox2.Controls.Add(ckbMyXaoBo);
            groupBox2.Controls.Add(ckbMyTomTrung);
            groupBox2.Controls.Add(ckbBanhMyCa);
            groupBox2.Controls.Add(ckbBanhMyTrung);
            groupBox2.Location = new Point(434, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thức ăn";
            // 
            // ckbMyCay
            // 
            ckbMyCay.AutoSize = true;
            ckbMyCay.Location = new Point(140, 56);
            ckbMyCay.Name = "ckbMyCay";
            ckbMyCay.Size = new Size(77, 24);
            ckbMyCay.TabIndex = 4;
            ckbMyCay.Text = "Mỳ cay";
            ckbMyCay.UseVisualStyleBackColor = true;
            // 
            // ckbMyXaoBo
            // 
            ckbMyXaoBo.AutoSize = true;
            ckbMyXaoBo.Location = new Point(140, 26);
            ckbMyXaoBo.Name = "ckbMyXaoBo";
            ckbMyXaoBo.Size = new Size(101, 24);
            ckbMyXaoBo.TabIndex = 3;
            ckbMyXaoBo.Text = "Mỳ xào bò";
            ckbMyXaoBo.UseVisualStyleBackColor = true;
            // 
            // ckbMyTomTrung
            // 
            ckbMyTomTrung.AutoSize = true;
            ckbMyTomTrung.Location = new Point(6, 87);
            ckbMyTomTrung.Name = "ckbMyTomTrung";
            ckbMyTomTrung.Size = new Size(122, 24);
            ckbMyTomTrung.TabIndex = 2;
            ckbMyTomTrung.Text = "Mỳ tôm trứng";
            ckbMyTomTrung.UseVisualStyleBackColor = true;
            // 
            // ckbBanhMyCa
            // 
            ckbBanhMyCa.AutoSize = true;
            ckbBanhMyCa.Location = new Point(6, 57);
            ckbBanhMyCa.Name = "ckbBanhMyCa";
            ckbBanhMyCa.Size = new Size(107, 24);
            ckbBanhMyCa.TabIndex = 1;
            ckbBanhMyCa.Text = "Bánh mỳ cá";
            ckbBanhMyCa.UseVisualStyleBackColor = true;
            // 
            // ckbBanhMyTrung
            // 
            ckbBanhMyTrung.AutoSize = true;
            ckbBanhMyTrung.Location = new Point(6, 26);
            ckbBanhMyTrung.Name = "ckbBanhMyTrung";
            ckbBanhMyTrung.Size = new Size(128, 24);
            ckbBanhMyTrung.TabIndex = 0;
            ckbBanhMyTrung.Text = "Bánh mỳ trứng";
            ckbBanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(107, 311);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 8;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(272, 311);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(94, 29);
            btnNhapLai.TabIndex = 9;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(453, 311);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(626, 311);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 365);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 12;
            label4.Text = "Tổng khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 403);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 13;
            label5.Text = "Tổng tiền thanh toán";
            // 
            // txtTongKhachHang
            // 
            txtTongKhachHang.Location = new Point(203, 362);
            txtTongKhachHang.Name = "txtTongKhachHang";
            txtTongKhachHang.Size = new Size(401, 27);
            txtTongKhachHang.TabIndex = 14;
            // 
            // txtTongTienThanhToan
            // 
            txtTongTienThanhToan.Location = new Point(203, 400);
            txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            txtTongTienThanhToan.Size = new Size(401, 27);
            txtTongTienThanhToan.TabIndex = 15;
            // 
            // C4_3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(txtTongTienThanhToan);
            Controls.Add(txtTongKhachHang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnThoat);
            Controls.Add(btnThanhToan);
            Controls.Add(btnNhapLai);
            Controls.Add(btnTinhTien);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ckbSinhVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoKhachHang);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label1);
            Name = "C4_3_1";
            Text = "C4_3_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenKhachHang;
        private TextBox txtSoKhachHang;
        private Label label2;
        private Label label3;
        private CheckBox ckbSinhVien;
        private GroupBox groupBox1;
        private RadioButton rdbCaPheKem;
        private RadioButton rdbCaPheDa;
        private RadioButton rdbCaPheSuaDa;
        private RadioButton rdbCaPheSua;
        private RadioButton rdbCaPheDen;
        private GroupBox groupBox2;
        private CheckBox ckbMyCay;
        private CheckBox ckbMyXaoBo;
        private CheckBox ckbMyTomTrung;
        private CheckBox ckbBanhMyCa;
        private CheckBox ckbBanhMyTrung;
        private Button btnTinhTien;
        private Button btnNhapLai;
        private Button btnThanhToan;
        private Button btnThoat;
        private Label label4;
        private Label label5;
        private TextBox txtTongKhachHang;
        private TextBox txtTongTienThanhToan;
    }
}