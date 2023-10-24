namespace FullWindowsForm
{
    partial class C2_2_4
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumber = new TextBox();
            txtDaySo = new TextBox();
            txtTongCacPhanTu = new TextBox();
            txtTongChan = new TextBox();
            txtTongLe = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 167);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Tổng chẵn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 82);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Dãy vừa nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 125);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng các phần tử trong dãy:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 172);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 5;
            label6.Text = "Tổng lẻ";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(122, 36);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 6;
            txtNumber.Leave += txt_Leave;
            txtNumber.KeyPress += txt_KeyPress;
            // 
            // txtDaySo
            // 
            txtDaySo.Location = new Point(140, 79);
            txtDaySo.Name = "txtDaySo";
            txtDaySo.Size = new Size(174, 23);
            txtDaySo.TabIndex = 7;
            // 
            // txtTongCacPhanTu
            // 
            txtTongCacPhanTu.Location = new Point(214, 122);
            txtTongCacPhanTu.Name = "txtTongCacPhanTu";
            txtTongCacPhanTu.Size = new Size(191, 23);
            txtTongCacPhanTu.TabIndex = 8;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(124, 164);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(100, 23);
            txtTongChan.TabIndex = 9;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(293, 167);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(112, 23);
            txtTongLe.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(108, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Tiếp Tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += TiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(262, 207);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += Thoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(262, 35);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += Nhap_Click;
            // 
            // C2_2_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 243);
            Controls.Add(btnNhap);
            Controls.Add(btnThoat);
            Controls.Add(button1);
            Controls.Add(txtTongLe);
            Controls.Add(txtTongChan);
            Controls.Add(txtTongCacPhanTu);
            Controls.Add(txtDaySo);
            Controls.Add(txtNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "C2_2_4";
            Text = "C2_2_4";
            FormClosing += C2_2_4_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumber;
        private TextBox txtDaySo;
        private TextBox txtTongCacPhanTu;
        private TextBox txtTongChan;
        private TextBox txtTongLe;
        private ErrorProvider errorProvider1;
        private Button btnThoat;
        private Button button1;
        private Button btnNhap;
    }
}