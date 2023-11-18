namespace FullWindowsForm
{
    partial class C6_3_1
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
            groupBox1 = new GroupBox();
            lstbLopA = new ListBox();
            groupBox2 = new GroupBox();
            lstbLopB = new ListBox();
            menuStrip1 = new MenuStrip();
            mnst_update = new ToolStripMenuItem();
            mnst_InputHocVienMoi = new ToolStripMenuItem();
            mnst_ChuyenSangLopB = new ToolStripMenuItem();
            mnst_ChuyenSangLopA = new ToolStripMenuItem();
            mnst_XoaHocVien = new ToolStripMenuItem();
            mnst_end = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstbLopA);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(56, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstbLopA
            // 
            lstbLopA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstbLopA.FormattingEnabled = true;
            lstbLopA.ItemHeight = 21;
            lstbLopA.Location = new Point(6, 28);
            lstbLopA.Name = "lstbLopA";
            lstbLopA.SelectionMode = SelectionMode.MultiExtended;
            lstbLopA.Size = new Size(194, 130);
            lstbLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstbLopB);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(326, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 164);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstbLopB
            // 
            lstbLopB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstbLopB.FormattingEnabled = true;
            lstbLopB.ItemHeight = 21;
            lstbLopB.Location = new Point(6, 28);
            lstbLopB.Name = "lstbLopB";
            lstbLopB.SelectionMode = SelectionMode.MultiExtended;
            lstbLopB.Size = new Size(194, 130);
            lstbLopB.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnst_update, mnst_end });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(589, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnst_update
            // 
            mnst_update.DropDownItems.AddRange(new ToolStripItem[] { mnst_InputHocVienMoi, mnst_ChuyenSangLopB, mnst_ChuyenSangLopA, mnst_XoaHocVien });
            mnst_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            mnst_update.Name = "mnst_update";
            mnst_update.Size = new Size(83, 24);
            mnst_update.Text = "Cập nhật";
            mnst_update.Click += updateMenuStrip_Click;
            // 
            // mnst_InputHocVienMoi
            // 
            mnst_InputHocVienMoi.Name = "mnst_InputHocVienMoi";
            mnst_InputHocVienMoi.Size = new Size(209, 24);
            mnst_InputHocVienMoi.Text = "Nhập học viên mới";
            mnst_InputHocVienMoi.Click += mnst_InputHocVienMoi_Click;
            // 
            // mnst_ChuyenSangLopB
            // 
            mnst_ChuyenSangLopB.Name = "mnst_ChuyenSangLopB";
            mnst_ChuyenSangLopB.Size = new Size(209, 24);
            mnst_ChuyenSangLopB.Text = "Chuyển sang lớp B";
            mnst_ChuyenSangLopB.Click += mnst_ChuyenSangLopB_Click;
            // 
            // mnst_ChuyenSangLopA
            // 
            mnst_ChuyenSangLopA.Name = "mnst_ChuyenSangLopA";
            mnst_ChuyenSangLopA.Size = new Size(209, 24);
            mnst_ChuyenSangLopA.Text = "Chuyển sang lớp A";
            mnst_ChuyenSangLopA.Click += mnst_ChuyenSangLopA_Click;
            // 
            // mnst_XoaHocVien
            // 
            mnst_XoaHocVien.Name = "mnst_XoaHocVien";
            mnst_XoaHocVien.Size = new Size(209, 24);
            mnst_XoaHocVien.Text = "Xoá học viên";
            mnst_XoaHocVien.Click += mnst_XoaHocVien_Click;
            // 
            // mnst_end
            // 
            mnst_end.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            mnst_end.Name = "mnst_end";
            mnst_end.Size = new Size(80, 24);
            mnst_end.Text = "Kết thúc";
            mnst_end.Click += endMenuStrip_Click;
            // 
            // C6_3_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 276);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "C6_3_1";
            Text = "C6_3_1";
            FormClosing += C6_3_1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstbLopA;
        private GroupBox groupBox2;
        private ListBox lstbLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnst_update;
        private ToolStripMenuItem mnst_end;
        private ToolStripMenuItem mnst_InputHocVienMoi;
        private ToolStripMenuItem mnst_ChuyenSangLopB;
        private ToolStripMenuItem mnst_ChuyenSangLopA;
        private ToolStripMenuItem mnst_XoaHocVien;
    }
}