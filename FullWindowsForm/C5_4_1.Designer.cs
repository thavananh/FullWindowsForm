namespace FullWindowsForm
{
    partial class C5_4_1
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
            panel1 = new Panel();
            txtTiengViet = new TextBox();
            cboTiengAnh = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnAnhViet = new Button();
            btnVietAnh = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(txtTiengViet);
            panel1.Controls.Add(cboTiengAnh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(133, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 297);
            panel1.TabIndex = 0;
            // 
            // txtTiengViet
            // 
            txtTiengViet.Location = new Point(315, 35);
            txtTiengViet.Multiline = true;
            txtTiengViet.Name = "txtTiengViet";
            txtTiengViet.Size = new Size(204, 243);
            txtTiengViet.TabIndex = 5;
            // 
            // cboTiengAnh
            // 
            cboTiengAnh.FormattingEnabled = true;
            cboTiengAnh.Location = new Point(33, 35);
            cboTiengAnh.Name = "cboTiengAnh";
            cboTiengAnh.Size = new Size(183, 28);
            cboTiengAnh.TabIndex = 4;
            cboTiengAnh.SelectedIndexChanged += cboTiengAnh_SelectedIndexChanged;
            cboTiengAnh.TextChanged += txtCboTiengAnh_TextChanged;
            cboTiengAnh.KeyPress += txtCboTiengAnh_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 12);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Tiếng Việt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Tiếng Anh";
            // 
            // btnAnhViet
            // 
            btnAnhViet.Location = new Point(133, 36);
            btnAnhViet.Name = "btnAnhViet";
            btnAnhViet.Size = new Size(94, 29);
            btnAnhViet.TabIndex = 1;
            btnAnhViet.Text = "Anh-Việt";
            btnAnhViet.UseVisualStyleBackColor = true;
            btnAnhViet.Click += btnAnhViet_Click;
            // 
            // btnVietAnh
            // 
            btnVietAnh.Location = new Point(224, 36);
            btnVietAnh.Name = "btnVietAnh";
            btnVietAnh.Size = new Size(94, 29);
            btnVietAnh.TabIndex = 2;
            btnVietAnh.Text = "Việt-Anh";
            btnVietAnh.UseVisualStyleBackColor = true;
            btnVietAnh.Click += btnVietAnh_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(45, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 6;
            // 
            // C5_4_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVietAnh);
            Controls.Add(btnAnhViet);
            Controls.Add(panel1);
            Name = "C5_4_1";
            Text = "C5_4_1";
            Load += C5_4_1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAnhViet;
        private Button btnVietAnh;
        private Label label2;
        private Label label1;
        private ComboBox cboTiengAnh;
        private TextBox txtTiengViet;
        private ListBox listBox1;
    }
}