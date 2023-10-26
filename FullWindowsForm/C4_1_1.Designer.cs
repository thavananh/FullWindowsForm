namespace FullWindowsForm
{
    partial class C4_1_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            rdbPlus = new RadioButton();
            rdbMinus = new RadioButton();
            rdbMultiple = new RadioButton();
            rdbDivision = new RadioButton();
            btnCalculate = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "a =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 23);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(66, 17);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 3;
            txtA.Leave += txt_Leave;
            txtA.KeyPress += txt_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(251, 20);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 4;
            txtA.Leave += txt_Leave;
            txtB.KeyPress += txt_KeyPress;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(66, 68);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(285, 23);
            txtKetQua.TabIndex = 5;
            // 
            // rdbPlus
            // 
            rdbPlus.AutoSize = true;
            rdbPlus.Location = new Point(35, 104);
            rdbPlus.Name = "rdbPlus";
            rdbPlus.Size = new Size(33, 19);
            rdbPlus.TabIndex = 6;
            rdbPlus.TabStop = true;
            rdbPlus.Text = "+";
            rdbPlus.UseVisualStyleBackColor = true;
            // 
            // rdbMinus
            // 
            rdbMinus.AutoSize = true;
            rdbMinus.Location = new Point(119, 104);
            rdbMinus.Name = "rdbMinus";
            rdbMinus.Size = new Size(30, 19);
            rdbMinus.TabIndex = 7;
            rdbMinus.TabStop = true;
            rdbMinus.Text = "-";
            rdbMinus.UseVisualStyleBackColor = true;
            // 
            // rdbMultiple
            // 
            rdbMultiple.AutoSize = true;
            rdbMultiple.Location = new Point(202, 104);
            rdbMultiple.Name = "rdbMultiple";
            rdbMultiple.Size = new Size(30, 19);
            rdbMultiple.TabIndex = 8;
            rdbMultiple.TabStop = true;
            rdbMultiple.Text = "*";
            rdbMultiple.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(292, 104);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(30, 19);
            rdbDivision.TabIndex = 10;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "/";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(146, 129);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Tính";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C4_1_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 160);
            Controls.Add(btnCalculate);
            Controls.Add(rdbDivision);
            Controls.Add(rdbMultiple);
            Controls.Add(rdbMinus);
            Controls.Add(rdbPlus);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "C4_1_1";
            Text = "C4_1_1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private RadioButton rdbPlus;
        private RadioButton rdbMinus;
        private RadioButton rdbMultiple;
        private RadioButton rdbDivision;
        private Button btnCalculate;
        private ErrorProvider errorProvider1;
    }
}