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
            btnQuaPhai = new Button();
            btnQuaPhai_All = new Button();
            btnQuaTrai = new Button();
            btnQuaTraiAll = new Button();
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
            // btnQuaPhai
            // 
            btnQuaPhai.Location = new Point(373, 63);
            btnQuaPhai.Name = "btnQuaPhai";
            btnQuaPhai.Size = new Size(56, 48);
            btnQuaPhai.TabIndex = 2;
            btnQuaPhai.Text = ">";
            btnQuaPhai.UseVisualStyleBackColor = true;
            btnQuaPhai.Click += btnQuaPhai_Click;
            // 
            // btnQuaPhai_All
            // 
            btnQuaPhai_All.Location = new Point(373, 145);
            btnQuaPhai_All.Name = "btnQuaPhai_All";
            btnQuaPhai_All.Size = new Size(56, 48);
            btnQuaPhai_All.TabIndex = 3;
            btnQuaPhai_All.Text = ">>";
            btnQuaPhai_All.UseVisualStyleBackColor = true;
            btnQuaPhai_All.Click += btnQuaPhai_All_Click;
            // 
            // btnQuaTrai
            // 
            btnQuaTrai.Location = new Point(373, 224);
            btnQuaTrai.Name = "btnQuaTrai";
            btnQuaTrai.Size = new Size(56, 48);
            btnQuaTrai.TabIndex = 4;
            btnQuaTrai.Text = "<";
            btnQuaTrai.UseVisualStyleBackColor = true;
            btnQuaTrai.Click += btnQuaTrai_Click;
            // 
            // btnQuaTraiAll
            // 
            btnQuaTraiAll.Location = new Point(373, 299);
            btnQuaTraiAll.Name = "btnQuaTraiAll";
            btnQuaTraiAll.Size = new Size(56, 48);
            btnQuaTraiAll.TabIndex = 5;
            btnQuaTraiAll.Text = "<<";
            btnQuaTraiAll.UseVisualStyleBackColor = true;
            btnQuaTraiAll.Click += btnQuaTraiAll_Click;
            // 
            // C5_1_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuaTraiAll);
            Controls.Add(btnQuaTrai);
            Controls.Add(btnQuaPhai_All);
            Controls.Add(btnQuaPhai);
            Controls.Add(lstbPhai);
            Controls.Add(lstbTrai);
            Name = "C5_1_1";
            Text = "C5_1_1";
            Load += C5_1_1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbTrai;
        private ListBox lstbPhai;
        private Button btnQuaPhai;
        private Button btnQuaPhai_All;
        private Button btnQuaTrai;
        private Button btnQuaTraiAll;
    }
}