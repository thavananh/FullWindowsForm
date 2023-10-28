namespace FullWindowsForm
{
    partial class C5_1_1
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
            lstbTrai = new ListBox();
            lstbPhai = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lstbTrai
            // 
            lstbTrai.FormattingEnabled = true;
            lstbTrai.ItemHeight = 20;
            lstbTrai.Location = new Point(103, 63);
            lstbTrai.Name = "lstbTrai";
            lstbTrai.Size = new Size(243, 284);
            lstbTrai.TabIndex = 0;
            // 
            // lstbPhai
            // 
            lstbPhai.FormattingEnabled = true;
            lstbPhai.ItemHeight = 20;
            lstbPhai.Location = new Point(461, 63);
            lstbPhai.Name = "lstbPhai";
            lstbPhai.Size = new Size(236, 284);
            lstbPhai.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(373, 63);
            button1.Name = "button1";
            button1.Size = new Size(56, 48);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(373, 145);
            button2.Name = "button2";
            button2.Size = new Size(56, 48);
            button2.TabIndex = 3;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(373, 224);
            button3.Name = "button3";
            button3.Size = new Size(56, 48);
            button3.TabIndex = 4;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(373, 299);
            button4.Name = "button4";
            button4.Size = new Size(56, 48);
            button4.TabIndex = 5;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            // 
            // C5_1_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstbPhai);
            Controls.Add(lstbTrai);
            Name = "C5_1_1";
            Text = "C5_1_1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbTrai;
        private ListBox lstbPhai;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}