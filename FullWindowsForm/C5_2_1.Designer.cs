namespace FullWindowsForm
{
    partial class C5_2_1
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
            groupBox1 = new GroupBox();
            cboDanhSachSo = new ComboBox();
            btnCapNhat = new Button();
            txtNhapSo = new TextBox();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            btnTongCacUocSo = new Button();
            btnSoLuongCacUocSoChan = new Button();
            btnSoLuongCacUocSoNguyenTo = new Button();
            errorProvider1 = new ErrorProvider(components);
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboDanhSachSo);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtNhapSo);
            groupBox1.Location = new Point(46, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // cboDanhSachSo
            // 
            cboDanhSachSo.FormattingEnabled = true;
            cboDanhSachSo.Location = new Point(15, 72);
            cboDanhSachSo.Name = "cboDanhSachSo";
            cboDanhSachSo.Size = new Size(258, 28);
            cboDanhSachSo.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(179, 24);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(15, 26);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(149, 27);
            txtNhapSo.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(236, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(351, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // btnTongCacUocSo
            // 
            btnTongCacUocSo.Location = new Point(392, 160);
            btnTongCacUocSo.Name = "btnTongCacUocSo";
            btnTongCacUocSo.Size = new Size(221, 29);
            btnTongCacUocSo.TabIndex = 3;
            btnTongCacUocSo.Text = "Tổng các ước số";
            btnTongCacUocSo.UseVisualStyleBackColor = true;
            btnTongCacUocSo.Click += btnTongCacUocSo_Click;
            // 
            // btnSoLuongCacUocSoChan
            // 
            btnSoLuongCacUocSoChan.Location = new Point(392, 195);
            btnSoLuongCacUocSoChan.Name = "btnSoLuongCacUocSoChan";
            btnSoLuongCacUocSoChan.Size = new Size(221, 29);
            btnSoLuongCacUocSoChan.TabIndex = 4;
            btnSoLuongCacUocSoChan.Text = "Số lượng các ước số chẵn";
            btnSoLuongCacUocSoChan.UseVisualStyleBackColor = true;
            btnSoLuongCacUocSoChan.Click += btnSoLuongCacUocSoChan_Click;
            // 
            // btnSoLuongCacUocSoNguyenTo
            // 
            btnSoLuongCacUocSoNguyenTo.Location = new Point(392, 230);
            btnSoLuongCacUocSoNguyenTo.Name = "btnSoLuongCacUocSoNguyenTo";
            btnSoLuongCacUocSoNguyenTo.Size = new Size(221, 29);
            btnSoLuongCacUocSoNguyenTo.TabIndex = 5;
            btnSoLuongCacUocSoNguyenTo.Text = "Số lượng các ước số nguyên tố";
            btnSoLuongCacUocSoNguyenTo.UseVisualStyleBackColor = true;
            btnSoLuongCacUocSoNguyenTo.Click += btnSoLuongCacUocSoNguyenTo_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(41, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 104);
            listBox1.TabIndex = 0;
            // 
            // C5_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 280);
            Controls.Add(btnSoLuongCacUocSoNguyenTo);
            Controls.Add(btnSoLuongCacUocSoChan);
            Controls.Add(btnTongCacUocSo);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Name = "C5_2_1";
            Text = "C5_2_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNhapSo;
        private ComboBox cboDanhSachSo;
        private Button btnCapNhat;
        private Button btnThoat;
        private GroupBox groupBox2;
        private Button btnTongCacUocSo;
        private Button btnSoLuongCacUocSoChan;
        private Button btnSoLuongCacUocSoNguyenTo;
        private ErrorProvider errorProvider1;
        private ListBox listBox1;
    }
}