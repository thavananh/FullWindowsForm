namespace FullWindowsForm
{
    partial class C5_1_2
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
            btnLoadDuLieuComboBox = new Button();
            btnHienThi = new Button();
            label1 = new Label();
            combbDanToc = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLoadDuLieuComboBox
            // 
            btnLoadDuLieuComboBox.Location = new Point(41, 25);
            btnLoadDuLieuComboBox.Name = "btnLoadDuLieuComboBox";
            btnLoadDuLieuComboBox.Size = new Size(240, 41);
            btnLoadDuLieuComboBox.TabIndex = 0;
            btnLoadDuLieuComboBox.Text = "Load dữ liệu Combobox";
            btnLoadDuLieuComboBox.UseVisualStyleBackColor = true;
            btnLoadDuLieuComboBox.Click += btnLoadDuLieuComboBox_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(173, 135);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(133, 41);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Dân tộc";
            // 
            // combbDanToc
            // 
            combbDanToc.FormattingEnabled = true;
            combbDanToc.Location = new Point(173, 83);
            combbDanToc.Name = "combbDanToc";
            combbDanToc.Size = new Size(283, 28);
            combbDanToc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 184);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // C5_1_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 228);
            Controls.Add(label2);
            Controls.Add(combbDanToc);
            Controls.Add(label1);
            Controls.Add(btnHienThi);
            Controls.Add(btnLoadDuLieuComboBox);
            Name = "C5_1_2";
            Text = "C5_1_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadDuLieuComboBox;
        private Button btnHienThi;
        private Label label1;
        private ComboBox combbDanToc;
        private Label label2;
    }
}