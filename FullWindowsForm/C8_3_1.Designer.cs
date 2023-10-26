namespace FullWindowsForm
{
    partial class C8_3_1
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
            listView1 = new ListView();
            col_MaLop = new ColumnHeader();
            col_HoVaTen = new ColumnHeader();
            btnHienThi = new Button();
            col_MaKhoa = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { col_MaLop, col_HoVaTen, col_MaKhoa });
            listView1.Location = new Point(96, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(449, 240);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;

            // 
            // col_MaLop
            // 
            col_MaLop.Text = "Mã Lớp";
            col_MaLop.Width = 120;
            // 
            // col_HoVaTen
            // 
            col_HoVaTen.Text = "Họ Và Tên";
            col_HoVaTen.TextAlign = HorizontalAlignment.Center;
            col_HoVaTen.Width = 150;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(54, 34);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // col_MaKhoa
            // 
            col_MaKhoa.Text = "Mã Khoa";
            col_MaKhoa.TextAlign = HorizontalAlignment.Center;
            col_MaKhoa.Width = 120;
            // 
            // C8_3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 380);
            Controls.Add(btnHienThi);
            Controls.Add(listView1);
            Name = "C8_3_1";
            Text = "C8_3_1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ListView listView1;
        private ColumnHeader col_MaLop;
        private ColumnHeader col_HoVaTen;
        private Button btnHienThi;
        private ColumnHeader col_MaKhoa;
    }
}