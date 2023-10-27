namespace FullWindowsForm
{
    partial class C4_2_1
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
            groupBox1 = new GroupBox();
            rdbPtrinhBac2 = new RadioButton();
            rdbPtrinhBacNhat = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtKetQua = new TextBox();
            btnGiai = new Button();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPtrinhBac2);
            groupBox1.Controls.Add(rdbPtrinhBacNhat);
            groupBox1.Location = new Point(49, 71);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rdbPtrinhBac2
            // 
            rdbPtrinhBac2.AutoSize = true;
            rdbPtrinhBac2.Location = new Point(9, 79);
            rdbPtrinhBac2.Margin = new Padding(3, 4, 3, 4);
            rdbPtrinhBac2.Name = "rdbPtrinhBac2";
            rdbPtrinhBac2.Size = new Size(167, 24);
            rdbPtrinhBac2.TabIndex = 1;
            rdbPtrinhBac2.Text = "Phương trình bậc hai";
            rdbPtrinhBac2.UseVisualStyleBackColor = true;
            rdbPtrinhBac2.CheckedChanged += rdbPtrinhBac2_CheckedChanged;
            // 
            // rdbPtrinhBacNhat
            // 
            rdbPtrinhBacNhat.AutoSize = true;
            rdbPtrinhBacNhat.Location = new Point(9, 33);
            rdbPtrinhBacNhat.Margin = new Padding(3, 4, 3, 4);
            rdbPtrinhBacNhat.Name = "rdbPtrinhBacNhat";
            rdbPtrinhBacNhat.Size = new Size(176, 24);
            rdbPtrinhBacNhat.TabIndex = 0;
            rdbPtrinhBacNhat.Text = "Phương trình bậc nhất";
            rdbPtrinhBacNhat.UseVisualStyleBackColor = true;
            rdbPtrinhBacNhat.CheckedChanged += rdbPtrinhBacNhat_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 231);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 291);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 353);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 412);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(117, 227);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(188, 27);
            txtA.TabIndex = 6;
            txtA.TextChanged += txt_TextChanged;
            txtA.KeyPress += txt_KeyPress;
            txtA.Leave += txt_Leave;
            // 
            // txtB
            // 
            txtB.Location = new Point(118, 287);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(187, 27);
            txtB.TabIndex = 7;
            txtB.TextChanged += txt_TextChanged;
            txtB.KeyPress += txt_KeyPress;
            txtB.Leave += txt_Leave;
            // 
            // txtC
            // 
            txtC.Location = new Point(118, 349);
            txtC.Margin = new Padding(3, 4, 3, 4);
            txtC.Name = "txtC";
            txtC.Size = new Size(187, 27);
            txtC.TabIndex = 8;
            txtC.TextChanged += txt_TextChanged;
            txtC.KeyPress += txt_KeyPress;
            txtC.Leave += txt_Leave;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(119, 408);
            txtKetQua.Margin = new Padding(3, 4, 3, 4);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(286, 75);
            txtKetQua.TabIndex = 9;
            // 
            // btnGiai
            // 
            btnGiai.Enabled = false;
            btnGiai.Location = new Point(312, 225);
            btnGiai.Margin = new Padding(3, 4, 3, 4);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(86, 65);
            btnGiai.TabIndex = 10;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(312, 312);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 72);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C4_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 600);
            Controls.Add(btnThoat);
            Controls.Add(btnGiai);
            Controls.Add(txtKetQua);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "C4_2_1";
            Text = "C4_2_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdbPtrinhBac2;
        private RadioButton rdbPtrinhBacNhat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKetQua;
        private Button btnGiai;
        private Button btnThoat;
        private ErrorProvider errorProvider1;
    }
}