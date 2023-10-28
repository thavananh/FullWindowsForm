namespace FullWindowsForm
{
    partial class C5_2_2
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
            treeView1 = new TreeView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            txtTenLop = new TextBox();
            label7 = new Label();
            btnThemLop = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(268, 376);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Chọn lớp";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(435, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 28);
            comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(296, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 270);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã SV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 110);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 178);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa Chỉ";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(139, 41);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(314, 27);
            txtMaSV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(139, 107);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(314, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(139, 175);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(314, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(139, 219);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(177, 38);
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(296, 344);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Thêm lớp";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThemLop);
            groupBox2.Controls.Add(txtTenLop);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(296, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 91);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(82, 38);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(245, 27);
            txtTenLop.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 41);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 2;
            label7.Text = "Tên lớp:";
            // 
            // btnThemLop
            // 
            btnThemLop.Location = new Point(361, 38);
            btnThemLop.Name = "btnThemLop";
            btnThemLop.Size = new Size(106, 29);
            btnThemLop.TabIndex = 6;
            btnThemLop.Text = "Thêm lớp";
            btnThemLop.UseVisualStyleBackColor = true;
            // 
            // C5_2_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(groupBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Name = "C5_2_2";
            Text = "C5_2_2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnCapNhat;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private Button btnThemLop;
        private TextBox txtTenLop;
        private Label label7;
    }
}