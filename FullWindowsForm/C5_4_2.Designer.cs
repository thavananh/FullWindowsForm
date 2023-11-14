namespace FullWindowsForm
{
    partial class C5_4_2
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
            groupBox1 = new GroupBox();
            lstNhap = new ListBox();
            btnNhap = new Button();
            txtNhap = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            btnChonSoLe = new Button();
            btnChonSoChan = new Button();
            btnThayBangBinhPhuong = new Button();
            btnTangMoiPhanTuLenHai = new Button();
            btnXoaPhanTuDangChon = new Button();
            btnXoaPhanTuDauVaCuoi = new Button();
            btnTongCacPhanTuTrongList = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 40);
            label1.TabIndex = 0;
            label1.Text = "List Box";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstNhap);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtNhap);
            groupBox1.Location = new Point(33, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(191, 235);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listbox";
            // 
            // lstNhap
            // 
            lstNhap.FormattingEnabled = true;
            lstNhap.ItemHeight = 15;
            lstNhap.Location = new Point(6, 81);
            lstNhap.Name = "lstNhap";
            lstNhap.Size = new Size(179, 139);
            lstNhap.TabIndex = 2;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(6, 52);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(179, 23);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "&Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(6, 22);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(179, 23);
            txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonSoLe);
            groupBox2.Controls.Add(btnChonSoChan);
            groupBox2.Controls.Add(btnThayBangBinhPhuong);
            groupBox2.Controls.Add(btnTangMoiPhanTuLenHai);
            groupBox2.Controls.Add(btnXoaPhanTuDangChon);
            groupBox2.Controls.Add(btnXoaPhanTuDauVaCuoi);
            groupBox2.Controls.Add(btnTongCacPhanTuTrongList);
            groupBox2.Location = new Point(279, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 235);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "xử lý Listbox";
            // 
            // btnChonSoLe
            // 
            btnChonSoLe.Location = new Point(7, 197);
            btnChonSoLe.Name = "btnChonSoLe";
            btnChonSoLe.Size = new Size(246, 23);
            btnChonSoLe.TabIndex = 6;
            btnChonSoLe.Text = "Chọn số lẻ";
            btnChonSoLe.UseVisualStyleBackColor = true;
            btnChonSoLe.Click += btnChonSoLe_Click;
            // 
            // btnChonSoChan
            // 
            btnChonSoChan.Location = new Point(7, 168);
            btnChonSoChan.Name = "btnChonSoChan";
            btnChonSoChan.Size = new Size(246, 23);
            btnChonSoChan.TabIndex = 5;
            btnChonSoChan.Text = "Chọn số chẵn";
            btnChonSoChan.UseVisualStyleBackColor = true;
            btnChonSoChan.Click += btnChonSoChan_Click;
            // 
            // btnThayBangBinhPhuong
            // 
            btnThayBangBinhPhuong.Location = new Point(7, 139);
            btnThayBangBinhPhuong.Name = "btnThayBangBinhPhuong";
            btnThayBangBinhPhuong.Size = new Size(246, 23);
            btnThayBangBinhPhuong.TabIndex = 4;
            btnThayBangBinhPhuong.Text = "Thay bằng bình phương";
            btnThayBangBinhPhuong.UseVisualStyleBackColor = true;
            btnThayBangBinhPhuong.Click += btnThayBangBinhPhuong_Click;
            // 
            // btnTangMoiPhanTuLenHai
            // 
            btnTangMoiPhanTuLenHai.Location = new Point(7, 110);
            btnTangMoiPhanTuLenHai.Name = "btnTangMoiPhanTuLenHai";
            btnTangMoiPhanTuLenHai.Size = new Size(246, 23);
            btnTangMoiPhanTuLenHai.TabIndex = 3;
            btnTangMoiPhanTuLenHai.Text = "Tăng mỗi phần tử lên 2";
            btnTangMoiPhanTuLenHai.UseVisualStyleBackColor = true;
            btnTangMoiPhanTuLenHai.Click += btnTangMoiPhanTuLenHai_Click;
            // 
            // btnXoaPhanTuDangChon
            // 
            btnXoaPhanTuDangChon.Location = new Point(7, 81);
            btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            btnXoaPhanTuDangChon.Size = new Size(246, 23);
            btnXoaPhanTuDangChon.TabIndex = 2;
            btnXoaPhanTuDangChon.Text = "Xoá phần tử đang chọn";
            btnXoaPhanTuDangChon.UseVisualStyleBackColor = true;
            btnXoaPhanTuDangChon.Click += btnXoaPhanTuDangChon_Click;
            // 
            // btnXoaPhanTuDauVaCuoi
            // 
            btnXoaPhanTuDauVaCuoi.Location = new Point(7, 52);
            btnXoaPhanTuDauVaCuoi.Name = "btnXoaPhanTuDauVaCuoi";
            btnXoaPhanTuDauVaCuoi.Size = new Size(246, 23);
            btnXoaPhanTuDauVaCuoi.TabIndex = 1;
            btnXoaPhanTuDauVaCuoi.Text = "Xoá phần tử ở đầu và cuối";
            btnXoaPhanTuDauVaCuoi.UseVisualStyleBackColor = true;
            btnXoaPhanTuDauVaCuoi.Click += btnXoaPhanTuDauVaCuoi_Click;
            // 
            // btnTongCacPhanTuTrongList
            // 
            btnTongCacPhanTuTrongList.Location = new Point(6, 22);
            btnTongCacPhanTuTrongList.Name = "btnTongCacPhanTuTrongList";
            btnTongCacPhanTuTrongList.Size = new Size(246, 23);
            btnTongCacPhanTuTrongList.TabIndex = 0;
            btnTongCacPhanTuTrongList.Text = "Tổng các phần tử trong List";
            btnTongCacPhanTuTrongList.UseVisualStyleBackColor = true;
            btnTongCacPhanTuTrongList.Click += btnTongCacPhanTuTrongList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 315);
            button1.Name = "button1";
            button1.Size = new Size(492, 23);
            button1.TabIndex = 3;
            button1.Text = "&KẾT THÚC";
            button1.UseVisualStyleBackColor = true;
            // 
            // C5_4_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 345);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "C5_4_2";
            Text = "C5_4_2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnNhap;
        private TextBox txtNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lstNhap;
        private GroupBox groupBox2;
        private Button btnThayBangBinhPhuong;
        private Button btnTangMoiPhanTuLenHai;
        private Button btnXoaPhanTuDangChon;
        private Button btnXoaPhanTuDauVaCuoi;
        private Button btnTongCacPhanTuTrongList;
        private Button btnChonSoLe;
        private Button btnChonSoChan;
        private Button button1;
    }
}