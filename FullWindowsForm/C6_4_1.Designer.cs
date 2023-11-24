namespace FullWindowsForm
{
    partial class C6_4_1
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
            btnBatDau = new Button();
            lblDongHo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(205, 174);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(135, 61);
            btnBatDau.TabIndex = 0;
            btnBatDau.Text = "bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // lblDongHo
            // 
            lblDongHo.AutoSize = true;
            lblDongHo.Location = new Point(225, 88);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(96, 38);
            lblDongHo.TabIndex = 1;
            lblDongHo.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // C6_4_1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 270);
            Controls.Add(lblDongHo);
            Controls.Add(btnBatDau);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "C6_4_1";
            Text = "C6_4_1";
            Load += C6_4_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatDau;
        private Label lblDongHo;
        private System.Windows.Forms.Timer timer1;
    }
}