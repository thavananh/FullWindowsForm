namespace FullWindowsForm
{
    partial class C2_2_1
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
            txtB.Location = new Point(291, 19);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 0;
            txtB.Leave += txt_Leave;
            // 
            // txtA
            // 
            txtA.Location = new Point(122, 19);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            txtA.Leave += txt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "a = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 22);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 75);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(122, 72);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(269, 23);
            txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(48, 122);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(187, 122);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(316, 122);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(432, 122);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_ClicK;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C2_2_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 168);
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
            FormClosing += C2_2_1_FormClosing;
            Name = "C2_2_1";
            Text = "C2_2_1";
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