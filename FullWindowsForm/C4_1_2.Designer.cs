namespace FullWindowsForm
{
    partial class C4_1_2
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
            labelHeader = new Label();
            groupBox1 = new GroupBox();
            ckbFontBoldAndItalic = new CheckBox();
            ckbFontItalic = new CheckBox();
            ckbFontBold = new CheckBox();
            ckbFontRegular = new CheckBox();
            groupBox2 = new GroupBox();
            rdbFontBlue = new RadioButton();
            rdbFontGreen = new RadioButton();
            rdbFontRed = new RadioButton();
            rdbFontAutoColor = new RadioButton();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.Red;
            labelHeader.Location = new Point(31, 27);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(387, 19);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Trường Đại Học Sư Phạm TPHCM Khoa Công Nghệ Thông Tin";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbFontBoldAndItalic);
            groupBox1.Controls.Add(ckbFontItalic);
            groupBox1.Controls.Add(ckbFontBold);
            groupBox1.Controls.Add(ckbFontRegular);
            groupBox1.Location = new Point(31, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font Style";
            // 
            // ckbFontBoldAndItalic
            // 
            ckbFontBoldAndItalic.AutoSize = true;
            ckbFontBoldAndItalic.Location = new Point(10, 117);
            ckbFontBoldAndItalic.Name = "ckbFontBoldAndItalic";
            ckbFontBoldAndItalic.Size = new Size(101, 19);
            ckbFontBoldAndItalic.TabIndex = 3;
            ckbFontBoldAndItalic.Text = "Bold and Italic";
            ckbFontBoldAndItalic.UseVisualStyleBackColor = true;
            ckbFontBoldAndItalic.CheckedChanged += ckbFontBoldAndItalic_CheckedChanged;
            // 
            // ckbFontItalic
            // 
            ckbFontItalic.AutoSize = true;
            ckbFontItalic.Location = new Point(10, 85);
            ckbFontItalic.Name = "ckbFontItalic";
            ckbFontItalic.Size = new Size(51, 19);
            ckbFontItalic.TabIndex = 2;
            ckbFontItalic.Text = "Italic";
            ckbFontItalic.UseVisualStyleBackColor = true;
            ckbFontItalic.CheckedChanged += ckbFontItalic_CheckedChanged;
            // 
            // ckbFontBold
            // 
            ckbFontBold.AutoSize = true;
            ckbFontBold.Location = new Point(10, 51);
            ckbFontBold.Name = "ckbFontBold";
            ckbFontBold.Size = new Size(50, 19);
            ckbFontBold.TabIndex = 1;
            ckbFontBold.Text = "Bold";
            ckbFontBold.UseVisualStyleBackColor = true;
            ckbFontBold.CheckedChanged += ckbFontBold_CheckedChanged;
            // 
            // ckbFontRegular
            // 
            ckbFontRegular.AutoSize = true;
            ckbFontRegular.Location = new Point(10, 16);
            ckbFontRegular.Name = "ckbFontRegular";
            ckbFontRegular.Size = new Size(66, 19);
            ckbFontRegular.TabIndex = 0;
            ckbFontRegular.Text = "Regular";
            ckbFontRegular.UseVisualStyleBackColor = true;
            ckbFontRegular.CheckedChanged += ckbFontRegular_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbFontBlue);
            groupBox2.Controls.Add(rdbFontGreen);
            groupBox2.Controls.Add(rdbFontRed);
            groupBox2.Controls.Add(rdbFontAutoColor);
            groupBox2.Location = new Point(261, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(122, 142);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // rdbFontBlue
            // 
            rdbFontBlue.AutoSize = true;
            rdbFontBlue.Location = new Point(6, 117);
            rdbFontBlue.Name = "rdbFontBlue";
            rdbFontBlue.Size = new Size(48, 19);
            rdbFontBlue.TabIndex = 3;
            rdbFontBlue.Text = "Blue";
            rdbFontBlue.UseVisualStyleBackColor = true;
            rdbFontBlue.CheckedChanged += rdbFontBlue_CheckedChanged;
            // 
            // rdbFontGreen
            // 
            rdbFontGreen.AutoSize = true;
            rdbFontGreen.Location = new Point(6, 85);
            rdbFontGreen.Name = "rdbFontGreen";
            rdbFontGreen.Size = new Size(56, 19);
            rdbFontGreen.TabIndex = 2;
            rdbFontGreen.Text = "Green";
            rdbFontGreen.UseVisualStyleBackColor = true;
            rdbFontGreen.CheckedChanged += rdbFontGreen_CheckedChanged;
            // 
            // rdbFontRed
            // 
            rdbFontRed.AutoSize = true;
            rdbFontRed.Location = new Point(6, 50);
            rdbFontRed.Name = "rdbFontRed";
            rdbFontRed.Size = new Size(45, 19);
            rdbFontRed.TabIndex = 1;
            rdbFontRed.Text = "Red";
            rdbFontRed.UseVisualStyleBackColor = true;
            rdbFontRed.CheckedChanged += rdbFontRed_CheckedChanged;
            // 
            // rdbFontAutoColor
            // 
            rdbFontAutoColor.AutoSize = true;
            rdbFontAutoColor.Location = new Point(6, 15);
            rdbFontAutoColor.Name = "rdbFontAutoColor";
            rdbFontAutoColor.Size = new Size(80, 19);
            rdbFontAutoColor.TabIndex = 0;
            rdbFontAutoColor.Text = "AutoColor";
            rdbFontAutoColor.UseVisualStyleBackColor = true;
            rdbFontAutoColor.CheckedChanged += rdbFontAutoColor_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(248, 256);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // C4_1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 324);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelHeader);
            Name = "C4_1_2";
            Text = "C4_1_2";
            FormClosing += C4_1_2_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private GroupBox groupBox1;
        private CheckBox ckbFontBoldAndItalic;
        private CheckBox ckbFontItalic;
        private CheckBox ckbFontBold;
        private CheckBox ckbFontRegular;
        private GroupBox groupBox2;
        private RadioButton rdbFontBlue;
        private RadioButton rdbFontGreen;
        private RadioButton rdbFontRed;
        private RadioButton rdbFontAutoColor;
        private Button btnExit;
    }
}