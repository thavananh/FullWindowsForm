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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(46, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(179, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(236, 160);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(351, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 83);
            textBox2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(392, 160);
            button3.Name = "button3";
            button3.Size = new Size(221, 29);
            button3.TabIndex = 3;
            button3.Text = "Tổng các ước số";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(392, 195);
            button4.Name = "button4";
            button4.Size = new Size(221, 29);
            button4.TabIndex = 4;
            button4.Text = "Số lượng các ước số chẵn";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(392, 230);
            button5.Name = "button5";
            button5.Size = new Size(221, 29);
            button5.TabIndex = 5;
            button5.Text = "Số lượng các ước số nguyên tố";
            button5.UseVisualStyleBackColor = true;
            // 
            // C5_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 280);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "C5_2_1";
            Text = "C5_2_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}