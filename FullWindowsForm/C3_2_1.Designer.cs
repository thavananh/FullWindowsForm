namespace FullWindowsForm
{
    partial class C3_2_1
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
            txtB = new TextBox();
            txtA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtB
            // 
            txtB.Location = new Point(333, 25);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(114, 27);
            txtB.TabIndex = 0;
            txtB.Leave += txt_Leave;
            // 
            // txtA
            // 
            txtA.Location = new Point(139, 25);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(114, 27);
            txtA.TabIndex = 1;
            txtA.Leave += txt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 29);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "a = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 29);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(139, 96);
            txtKetQua.Margin = new Padding(3, 4, 3, 4);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(307, 27);
            txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(55, 163);
            btnCong.Margin = new Padding(3, 4, 3, 4);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(86, 31);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(214, 163);
            btnTru.Margin = new Padding(3, 4, 3, 4);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(86, 31);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(361, 163);
            btnNhan.Margin = new Padding(3, 4, 3, 4);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(86, 31);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(494, 163);
            btnChia.Margin = new Padding(3, 4, 3, 4);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(86, 31);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_ClicK;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C3_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 224);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Margin = new Padding(3, 4, 3, 4);
            Name = "C3_2_1";
            Text = "C3_2_1";
            FormClosing += C3_2_1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtB;
        private TextBox txtA;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKetQua;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private ErrorProvider errorProvider1;
    }
}