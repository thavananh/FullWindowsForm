namespace FullWindowsForm
{
    partial class C6_4_2
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
            menuStrip1 = new MenuStrip();
            c612ToolStripMenuItem = new ToolStripMenuItem();
            c613ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { c612ToolStripMenuItem, c613ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // c612ToolStripMenuItem
            // 
            c612ToolStripMenuItem.Name = "c612ToolStripMenuItem";
            c612ToolStripMenuItem.Size = new Size(68, 24);
            c612ToolStripMenuItem.Text = "C6_1_2";
            c612ToolStripMenuItem.Click += c612ToolStripMenuItem_Click;
            // 
            // c613ToolStripMenuItem
            // 
            c613ToolStripMenuItem.Name = "c613ToolStripMenuItem";
            c613ToolStripMenuItem.Size = new Size(68, 24);
            c613ToolStripMenuItem.Text = "C6_1_3";
            c613ToolStripMenuItem.Click += c613ToolStripMenuItem_Click;
            // 
            // C6_4_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "C6_4_2";
            Text = "C6_4_2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem c612ToolStripMenuItem;
        private ToolStripMenuItem c613ToolStripMenuItem;
    }
}