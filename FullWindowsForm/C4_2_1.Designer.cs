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
            label1.Location = new Point(183, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPtrinhBac2);
            groupBox1.Controls.Add(rdbPtrinhBacNhat);
            groupBox1.Location = new Point(43, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rdbPtrinhBac2
            // 
            rdbPtrinhBac2.AutoSize = true;
            rdbPtrinhBac2.Location = new Point(8, 59);
            rdbPtrinhBac2.Name = "rdbPtrinhBac2";
            rdbPtrinhBac2.Size = new Size(136, 19);
            rdbPtrinhBac2.TabIndex = 1;
            rdbPtrinhBac2.TabStop = true;
            rdbPtrinhBac2.Text = "Phương trình bậc hai";
            rdbPtrinhBac2.UseVisualStyleBackColor = true;
            // 
            // rdbPtrinhBacNhat
            // 
            rdbPtrinhBacNhat.AutoSize = true;
            rdbPtrinhBacNhat.Location = new Point(8, 25);
            rdbPtrinhBacNhat.Name = "rdbPtrinhBacNhat";
            rdbPtrinhBacNhat.Size = new Size(144, 19);
            rdbPtrinhBacNhat.TabIndex = 0;
            rdbPtrinhBacNhat.TabStop = true;
            rdbPtrinhBacNhat.Text = "Phương trình bậc nhất";
            rdbPtrinhBacNhat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 173);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhập a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 218);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Nhập b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 265);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Nhập c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 309);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(102, 170);
            txtA.Name = "txtA";
            txtA.Size = new Size(165, 23);
            txtA.TabIndex = 6;
            txtA.Leave += txt_Leave;
            txtA.KeyPress += txt_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(103, 215);
            txtB.Name = "txtB";
            txtB.Size = new Size(164, 23);
            txtB.TabIndex = 7;
            txtB.Leave += txt_Leave;
            txtB.KeyPress += txt_KeyPress;
            // 
            // txtC
            // 
            txtC.Location = new Point(103, 262);
            txtC.Name = "txtC";
            txtC.Size = new Size(164, 23);
            txtC.TabIndex = 8;
            txtC.Leave += txt_Leave;
            txtC.KeyPress += txt_KeyPress;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(104, 306);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(251, 57);
            txtKetQua.TabIndex = 9;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(273, 169);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(75, 49);
            btnGiai.TabIndex = 10;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            btnGiai.Enabled = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(273, 234);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 54);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
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