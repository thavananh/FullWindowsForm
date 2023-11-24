namespace FullWindowsForm
{
    partial class C6_3_1_1
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
            txtHoTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLop = new TextBox();
            btnCapNhat = new Button();
            btnTroVe = new Button();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(99, 21);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(236, 27);
            txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "Lớp";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(99, 81);
            txtLop.Margin = new Padding(3, 4, 3, 4);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(236, 27);
            txtLop.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(99, 127);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(86, 31);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(217, 127);
            btnTroVe.Margin = new Padding(3, 4, 3, 4);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(86, 31);
            btnTroVe.TabIndex = 5;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // C6_3_1_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 180);
            Controls.Add(btnTroVe);
            Controls.Add(btnCapNhat);
            Controls.Add(txtLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "C6_3_1_1";
            Text = "C6_3_1_1";
            Load += C6_3_1_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private Label label2;
        private TextBox txtLop;
        private Button btnCapNhat;
        private Button btnTroVe;
    }
}