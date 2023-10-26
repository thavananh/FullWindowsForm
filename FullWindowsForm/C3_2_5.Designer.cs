namespace FullWindowsForm
{
    partial class C3_2_5
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
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            txtNhap = new TextBox();
            btnThucHien = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtKetQua = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Đọc số thành chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập dãy số từ 1 đến 999";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(235, 38);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(182, 27);
            txtNhap.TabIndex = 2;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(12, 81);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(94, 29);
            btnThucHien.TabIndex = 3;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(166, 81);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(323, 81);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(12, 128);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(405, 27);
            txtKetQua.TabIndex = 6;
            // 
            // C3_2_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 185);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThucHien);
            Controls.Add(txtNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "C3_2_5";
            Text = "C3_2_5";
            FormClosing += C3_2_5_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnThucHien;
        private TextBox txtNhap;
        private Label label2;
        private Label label1;
        private TextBox txtKetQua;
    }
}