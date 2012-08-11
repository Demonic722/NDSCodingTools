namespace Number_Converter
{
    partial class frmMain
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows form code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.decimalLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.decimalBox = new System.Windows.Forms.TextBox();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.binaryBox = new System.Windows.Forms.TextBox();
            this.hexCaps = new System.Windows.Forms.CheckBox();
            this.octalLabel = new System.Windows.Forms.Label();
            this.octalBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForStableReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAnyReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // decimalLabel
            // 
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Location = new System.Drawing.Point(11, 36);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(45, 13);
            this.decimalLabel.TabIndex = 0;
            this.decimalLabel.Text = "Decimal";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(11, 62);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(26, 13);
            this.hexLabel.TabIndex = 1;
            this.hexLabel.Text = "Hex";
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.binaryLabel.Location = new System.Drawing.Point(11, 88);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(36, 13);
            this.binaryLabel.TabIndex = 2;
            this.binaryLabel.Text = "Binary";
            // 
            // decimalBox
            // 
            this.decimalBox.Location = new System.Drawing.Point(67, 33);
            this.decimalBox.MaxLength = 23;
            this.decimalBox.Name = "decimalBox";
            this.decimalBox.Size = new System.Drawing.Size(154, 20);
            this.decimalBox.TabIndex = 3;
            this.decimalBox.TextChanged += new System.EventHandler(this.decimalBox_TextChanged);
            this.decimalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalBox_KeyPress);
            this.decimalBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.decimalBox_KeyUp);
            // 
            // hexBox
            // 
            this.hexBox.Location = new System.Drawing.Point(67, 59);
            this.hexBox.MaxLength = 19;
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(133, 20);
            this.hexBox.TabIndex = 4;
            this.hexBox.TextChanged += new System.EventHandler(this.hexBox_TextChanged);
            this.hexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hexBox_KeyPress);
            this.hexBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hexBox_KeyUp);
            // 
            // binaryBox
            // 
            this.binaryBox.Location = new System.Drawing.Point(67, 85);
            this.binaryBox.MaxLength = 23;
            this.binaryBox.Name = "binaryBox";
            this.binaryBox.Size = new System.Drawing.Size(154, 20);
            this.binaryBox.TabIndex = 5;
            this.binaryBox.TextChanged += new System.EventHandler(this.binaryBox_TextChanged);
            this.binaryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.binaryBox_KeyPress);
            this.binaryBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.binaryBox_KeyUp);
            // 
            // hexCaps
            // 
            this.hexCaps.AutoSize = true;
            this.hexCaps.Checked = true;
            this.hexCaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexCaps.Location = new System.Drawing.Point(206, 62);
            this.hexCaps.Name = "hexCaps";
            this.hexCaps.Size = new System.Drawing.Size(15, 14);
            this.hexCaps.TabIndex = 6;
            this.hexCaps.UseVisualStyleBackColor = true;
            this.hexCaps.CheckStateChanged += new System.EventHandler(this.hexCaps_CheckStateChanged);
            // 
            // octalLabel
            // 
            this.octalLabel.AutoSize = true;
            this.octalLabel.Location = new System.Drawing.Point(11, 114);
            this.octalLabel.Name = "octalLabel";
            this.octalLabel.Size = new System.Drawing.Size(32, 13);
            this.octalLabel.TabIndex = 7;
            this.octalLabel.Text = "Octal";
            // 
            // octalBox
            // 
            this.octalBox.Location = new System.Drawing.Point(67, 111);
            this.octalBox.MaxLength = 23;
            this.octalBox.Name = "octalBox";
            this.octalBox.Size = new System.Drawing.Size(154, 20);
            this.octalBox.TabIndex = 8;
            this.octalBox.TextChanged += new System.EventHandler(this.octalBox_TextChanged);
            this.octalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.octalBox_KeyPress);
            this.octalBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.octalBox_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(239, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryEnabledToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // binaryEnabledToolStripMenuItem
            // 
            this.binaryEnabledToolStripMenuItem.Checked = true;
            this.binaryEnabledToolStripMenuItem.CheckOnClick = true;
            this.binaryEnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.binaryEnabledToolStripMenuItem.Name = "binaryEnabledToolStripMenuItem";
            this.binaryEnabledToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.binaryEnabledToolStripMenuItem.Text = "&Binary Enabled";
            this.binaryEnabledToolStripMenuItem.Click += new System.EventHandler(this.binaryEnabledToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changelogToolStripMenuItem.Text = "&Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForStableReleaseToolStripMenuItem,
            this.checkForAnyReleaseToolStripMenuItem});
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            // 
            // checkForStableReleaseToolStripMenuItem
            // 
            this.checkForStableReleaseToolStripMenuItem.Name = "checkForStableReleaseToolStripMenuItem";
            this.checkForStableReleaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.checkForStableReleaseToolStripMenuItem.Text = "Check for &Stable Release";
            this.checkForStableReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForStableReleaseToolStripMenuItem_Click);
            // 
            // checkForAnyReleaseToolStripMenuItem
            // 
            this.checkForAnyReleaseToolStripMenuItem.Name = "checkForAnyReleaseToolStripMenuItem";
            this.checkForAnyReleaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.checkForAnyReleaseToolStripMenuItem.Text = "Check for &Any Release";
            this.checkForAnyReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForAnyReleaseToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 145);
            this.Controls.Add(this.octalBox);
            this.Controls.Add(this.octalLabel);
            this.Controls.Add(this.hexCaps);
            this.Controls.Add(this.binaryBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.decimalBox);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(247, 132);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(247, 179);
            this.MinimumSize = new System.Drawing.Size(247, 179);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Converter";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.TextBox decimalBox;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.TextBox binaryBox;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.CheckBox hexCaps;
        private System.Windows.Forms.Label octalLabel;
        private System.Windows.Forms.TextBox octalBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryEnabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForStableReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAnyReleaseToolStripMenuItem;
    }
}

