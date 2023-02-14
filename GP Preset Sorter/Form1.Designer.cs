namespace GP_Preset_Sorter
{
    partial class Form1
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
            this.presets_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPresetsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filePath_label1 = new System.Windows.Forms.Label();
            this.filePath_label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // presets_listBox
            // 
            this.presets_listBox.FormattingEnabled = true;
            this.presets_listBox.Location = new System.Drawing.Point(44, 101);
            this.presets_listBox.Name = "presets_listBox";
            this.presets_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.presets_listBox.Size = new System.Drawing.Size(381, 277);
            this.presets_listBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "List";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetsFileToolStripMenuItem,
            this.exportPresetsFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPresetsFileToolStripMenuItem
            // 
            this.loadPresetsFileToolStripMenuItem.Name = "loadPresetsFileToolStripMenuItem";
            this.loadPresetsFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadPresetsFileToolStripMenuItem.Text = "Import presets file";
            this.loadPresetsFileToolStripMenuItem.Click += new System.EventHandler(this.loadPresetsFileToolStripMenuItem_Click);
            // 
            // exportPresetsFileToolStripMenuItem
            // 
            this.exportPresetsFileToolStripMenuItem.Enabled = false;
            this.exportPresetsFileToolStripMenuItem.Name = "exportPresetsFileToolStripMenuItem";
            this.exportPresetsFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exportPresetsFileToolStripMenuItem.Text = "Export presets file";
            this.exportPresetsFileToolStripMenuItem.Click += new System.EventHandler(this.exportPresetsFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // filePath_label1
            // 
            this.filePath_label1.AutoSize = true;
            this.filePath_label1.Location = new System.Drawing.Point(42, 43);
            this.filePath_label1.Name = "filePath_label1";
            this.filePath_label1.Size = new System.Drawing.Size(64, 13);
            this.filePath_label1.TabIndex = 11;
            this.filePath_label1.Text = "Presets file: ";
            this.filePath_label1.Visible = false;
            // 
            // filePath_label2
            // 
            this.filePath_label2.AutoSize = true;
            this.filePath_label2.Location = new System.Drawing.Point(103, 43);
            this.filePath_label2.Name = "filePath_label2";
            this.filePath_label2.Size = new System.Drawing.Size(35, 13);
            this.filePath_label2.TabIndex = 12;
            this.filePath_label2.Text = "label3";
            this.filePath_label2.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = global::GP_Preset_Sorter.Properties.Resources.down_arrow;
            this.button2.Location = new System.Drawing.Point(450, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::GP_Preset_Sorter.Properties.Resources.up_arrow1;
            this.button1.Location = new System.Drawing.Point(450, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filePath_label2);
            this.Controls.Add(this.filePath_label1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presets_listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Valeton GP-100 Preset sorter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox presets_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPresetsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPresetsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label filePath_label1;
        private System.Windows.Forms.Label filePath_label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

