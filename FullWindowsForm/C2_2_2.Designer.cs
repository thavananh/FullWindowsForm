namespace FullWindowsForm
{
    partial class C2_2_2
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
            txtDangNhap = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            btnDangKy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 34);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 67);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 98);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 125);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(153, 31);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(194, 23);
            txtDangNhap.TabIndex = 5;
            txtDangNhap.Leave += txt_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 6;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(153, 96);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(194, 23);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.Leave += txt_Leave;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(153, 125);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(194, 23);
            txtXacNhanMatKhau.TabIndex = 8;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.Leave += txt_Leave;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(153, 164);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(149, 45);
            btnDangKy.TabIndex = 9;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // C2_2_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 221);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtDangNhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "C2_2_2";
            Text = "C2_2_2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDangNhap;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Button btnDangKy;
        private ErrorProvider errorProvider1;
    }
}