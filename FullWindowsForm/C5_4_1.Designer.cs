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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTiengViet);
            panel1.Controls.Add(cboTiengAnh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(116, 53);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 223);
            panel1.TabIndex = 0;
            // 
            // txtTiengViet
            // 
            txtTiengViet.Location = new Point(276, 26);
            txtTiengViet.Margin = new Padding(3, 2, 3, 2);
            txtTiengViet.Multiline = true;
            txtTiengViet.Name = "txtTiengViet";
            txtTiengViet.Size = new Size(179, 183);
            txtTiengViet.TabIndex = 5;
            // 
            // cboTiengAnh
            // 
            cboTiengAnh.FormattingEnabled = true;
            cboTiengAnh.Location = new Point(29, 26);
            cboTiengAnh.Margin = new Padding(3, 2, 3, 2);
            cboTiengAnh.Name = "cboTiengAnh";
            cboTiengAnh.Size = new Size(161, 23);
            cboTiengAnh.TabIndex = 4;
            cboTiengAnh.SelectedIndexChanged += cboTiengAnh_SelectedIndexChanged;
            cboTiengAnh.TextChanged += txtCboTiengAnh_TextChanged;
            cboTiengAnh.KeyPress += txtCboTiengAnh_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Tiếng Việt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Tiếng Anh";
            // 
            // btnAnhViet
            // 
            btnAnhViet.Location = new Point(116, 27);
            btnAnhViet.Margin = new Padding(3, 2, 3, 2);
            btnAnhViet.Name = "btnAnhViet";
            btnAnhViet.Size = new Size(82, 22);
            btnAnhViet.TabIndex = 1;
            btnAnhViet.Text = "Anh-Việt";
            btnAnhViet.UseVisualStyleBackColor = true;
            btnAnhViet.Click += btnAnhViet_Click;
            // 
            // btnVietAnh
            // 
            btnVietAnh.Location = new Point(196, 27);
            btnVietAnh.Margin = new Padding(3, 2, 3, 2);
            btnVietAnh.Name = "btnVietAnh";
            btnVietAnh.Size = new Size(82, 22);
            btnVietAnh.TabIndex = 2;
            btnVietAnh.Text = "Việt-Anh";
            btnVietAnh.UseVisualStyleBackColor = true;
            btnVietAnh.Click += btnVietAnh_Click;
            // 
            // C5_4_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnVietAnh);
            Controls.Add(btnAnhViet);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}