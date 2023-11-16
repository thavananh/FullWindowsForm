namespace FullWindowsForm
{
    partial class C6_1_3
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
            rtxtChat = new RichTextBox();
            label1 = new Label();
            btnLuuFile = new Button();
            saveChat = new SaveFileDialog();
            btnMoFile = new Button();
            openFile = new OpenFileDialog();
            txtFilePath = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // rtxtChat
            // 
            rtxtChat.Location = new Point(51, 44);
            rtxtChat.Name = "rtxtChat";
            rtxtChat.Size = new Size(399, 184);
            rtxtChat.TabIndex = 0;
            rtxtChat.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập đoạn chat";
            // 
            // btnLuuFile
            // 
            btnLuuFile.Location = new Point(356, 234);
            btnLuuFile.Name = "btnLuuFile";
            btnLuuFile.Size = new Size(94, 29);
            btnLuuFile.TabIndex = 2;
            btnLuuFile.Text = "Lưu file";
            btnLuuFile.UseVisualStyleBackColor = true;
            btnLuuFile.Click += btnLuuFile_Click;
            // 
            // saveChat
            // 
            saveChat.FileOk += saveChat_FileOk;
            // 
            // btnMoFile
            // 
            btnMoFile.Location = new Point(256, 234);
            btnMoFile.Name = "btnMoFile";
            btnMoFile.Size = new Size(94, 29);
            btnMoFile.TabIndex = 3;
            btnMoFile.Text = "Mở file";
            btnMoFile.UseVisualStyleBackColor = true;
            btnMoFile.Click += btnMoFile_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(166, 273);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(284, 27);
            txtFilePath.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 276);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Đường dẫn file";
            // 
            // C6_1_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 337);
            Controls.Add(label2);
            Controls.Add(txtFilePath);
            Controls.Add(btnMoFile);
            Controls.Add(btnLuuFile);
            Controls.Add(label1);
            Controls.Add(rtxtChat);
            Name = "C6_1_3";
            Text = "C6_1_3";
            Load += C6_1_3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtChat;
        private Label label1;
        private Button btnLuuFile;
        private SaveFileDialog saveChat;
        private Button btnMoFile;
        private OpenFileDialog openFile;
        private TextBox txtFilePath;
        private Label label2;
    }
}