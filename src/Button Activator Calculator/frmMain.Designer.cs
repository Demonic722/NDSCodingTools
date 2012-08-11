namespace Button_Activator_Calculator
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region InitializeComponent()

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.upSelect = new System.Windows.Forms.CheckBox();
            this.leftSelect = new System.Windows.Forms.CheckBox();
            this.rightSelect = new System.Windows.Forms.CheckBox();
            this.downSelect = new System.Windows.Forms.CheckBox();
            this.upLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.outputDisplay = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.dPadGroup = new System.Windows.Forms.GroupBox();
            this.debugButtonSelect = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nintendoDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameboyAdvancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForStableReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAnyReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSelect = new System.Windows.Forms.CheckBox();
            this.aSelect = new System.Windows.Forms.CheckBox();
            this.startSelect = new System.Windows.Forms.CheckBox();
            this.selectSelect = new System.Windows.Forms.CheckBox();
            this.lSelect = new System.Windows.Forms.CheckBox();
            this.rSelect = new System.Windows.Forms.CheckBox();
            this.xSelect = new System.Windows.Forms.CheckBox();
            this.ySelect = new System.Windows.Forms.CheckBox();
            this.buttonsGroup = new System.Windows.Forms.GroupBox();
            this.dsCloseSelect = new System.Windows.Forms.Button();
            this.dPadGroup.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.buttonsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // upSelect
            // 
            this.upSelect.AutoSize = true;
            this.upSelect.Location = new System.Drawing.Point(55, 30);
            this.upSelect.Name = "upSelect";
            this.upSelect.Size = new System.Drawing.Size(15, 14);
            this.upSelect.TabIndex = 6;
            this.upSelect.UseVisualStyleBackColor = true;
            this.upSelect.CheckedChanged += new System.EventHandler(this.upSelect_CheckedChanged);
            // 
            // leftSelect
            // 
            this.leftSelect.AutoSize = true;
            this.leftSelect.Location = new System.Drawing.Point(34, 50);
            this.leftSelect.Name = "leftSelect";
            this.leftSelect.Size = new System.Drawing.Size(15, 14);
            this.leftSelect.TabIndex = 7;
            this.leftSelect.UseVisualStyleBackColor = true;
            this.leftSelect.CheckedChanged += new System.EventHandler(this.leftSelect_CheckedChanged);
            // 
            // rightSelect
            // 
            this.rightSelect.AutoSize = true;
            this.rightSelect.Location = new System.Drawing.Point(74, 50);
            this.rightSelect.Name = "rightSelect";
            this.rightSelect.Size = new System.Drawing.Size(15, 14);
            this.rightSelect.TabIndex = 8;
            this.rightSelect.UseVisualStyleBackColor = true;
            this.rightSelect.CheckedChanged += new System.EventHandler(this.rightSelect_CheckedChanged);
            // 
            // downSelect
            // 
            this.downSelect.AutoSize = true;
            this.downSelect.Location = new System.Drawing.Point(55, 70);
            this.downSelect.Name = "downSelect";
            this.downSelect.Size = new System.Drawing.Size(15, 14);
            this.downSelect.TabIndex = 9;
            this.downSelect.UseVisualStyleBackColor = true;
            this.downSelect.CheckedChanged += new System.EventHandler(this.downSelect_CheckedChanged);
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upLabel.Location = new System.Drawing.Point(52, 12);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(21, 13);
            this.upLabel.TabIndex = 10;
            this.upLabel.Text = "Up";
            this.upLabel.Click += new System.EventHandler(this.upLabel_Click);
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leftLabel.Location = new System.Drawing.Point(2, 50);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(25, 13);
            this.leftLabel.TabIndex = 11;
            this.leftLabel.Text = "Left";
            this.leftLabel.Click += new System.EventHandler(this.leftLabel_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rightLabel.Location = new System.Drawing.Point(95, 50);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(32, 13);
            this.rightLabel.TabIndex = 12;
            this.rightLabel.Text = "Right";
            this.rightLabel.Click += new System.EventHandler(this.rightLabel_Click);
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.downLabel.Location = new System.Drawing.Point(45, 87);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(35, 13);
            this.downLabel.TabIndex = 13;
            this.downLabel.Text = "Down";
            this.downLabel.Click += new System.EventHandler(this.downLabel_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(4, 146);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(150, 13);
            this.valueLabel.TabIndex = 14;
            this.valueLabel.Text = "tst the value in 0x04000130 to";
            // 
            // outputDisplay
            // 
            this.outputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputDisplay.Location = new System.Drawing.Point(160, 143);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.ReadOnly = true;
            this.outputDisplay.Size = new System.Drawing.Size(145, 20);
            this.outputDisplay.TabIndex = 15;
            this.outputDisplay.Text = "#0x0";
            this.outputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(7, 169);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(298, 23);
            this.copyButton.TabIndex = 16;
            this.copyButton.Text = "&Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyOutput);
            // 
            // dPadGroup
            // 
            this.dPadGroup.Controls.Add(this.rightSelect);
            this.dPadGroup.Controls.Add(this.upSelect);
            this.dPadGroup.Controls.Add(this.leftSelect);
            this.dPadGroup.Controls.Add(this.downSelect);
            this.dPadGroup.Controls.Add(this.downLabel);
            this.dPadGroup.Controls.Add(this.upLabel);
            this.dPadGroup.Controls.Add(this.rightLabel);
            this.dPadGroup.Controls.Add(this.leftLabel);
            this.dPadGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dPadGroup.Location = new System.Drawing.Point(7, 29);
            this.dPadGroup.Name = "dPadGroup";
            this.dPadGroup.Size = new System.Drawing.Size(129, 108);
            this.dPadGroup.TabIndex = 19;
            this.dPadGroup.TabStop = false;
            this.dPadGroup.Text = "D-Pad";
            // 
            // debugButtonSelect
            // 
            this.debugButtonSelect.AutoSize = true;
            this.debugButtonSelect.Location = new System.Drawing.Point(225, 114);
            this.debugButtonSelect.Name = "debugButtonSelect";
            this.debugButtonSelect.Size = new System.Drawing.Size(80, 23);
            this.debugButtonSelect.TabIndex = 22;
            this.debugButtonSelect.Text = "D&ebug";
            this.debugButtonSelect.UseVisualStyleBackColor = true;
            this.debugButtonSelect.Click += new System.EventHandler(this.debugButtonSelect_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuBar.Size = new System.Drawing.Size(312, 24);
            this.menuBar.TabIndex = 23;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyValueToolStripMenuItem,
            this.clearSelectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyValueToolStripMenuItem
            // 
            this.copyValueToolStripMenuItem.Name = "copyValueToolStripMenuItem";
            this.copyValueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyValueToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyValueToolStripMenuItem.Text = "&Copy Value";
            this.copyValueToolStripMenuItem.Click += new System.EventHandler(this.copyOutput);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clearSelectionToolStripMenuItem.Text = "Clear &Selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearAll);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDeviceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // selectDeviceToolStripMenuItem
            // 
            this.selectDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nintendoDSToolStripMenuItem,
            this.gameboyAdvancedToolStripMenuItem});
            this.selectDeviceToolStripMenuItem.Name = "selectDeviceToolStripMenuItem";
            this.selectDeviceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.selectDeviceToolStripMenuItem.Text = "Select &Device";
            // 
            // nintendoDSToolStripMenuItem
            // 
            this.nintendoDSToolStripMenuItem.Checked = true;
            this.nintendoDSToolStripMenuItem.CheckOnClick = true;
            this.nintendoDSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nintendoDSToolStripMenuItem.Name = "nintendoDSToolStripMenuItem";
            this.nintendoDSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.nintendoDSToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.nintendoDSToolStripMenuItem.Text = "Nintendo &DS";
            this.nintendoDSToolStripMenuItem.CheckedChanged += new System.EventHandler(this.nintendoDSToolStripMenuItem_CheckedChanged);
            // 
            // gameboyAdvancedToolStripMenuItem
            // 
            this.gameboyAdvancedToolStripMenuItem.CheckOnClick = true;
            this.gameboyAdvancedToolStripMenuItem.Name = "gameboyAdvancedToolStripMenuItem";
            this.gameboyAdvancedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.G)));
            this.gameboyAdvancedToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.gameboyAdvancedToolStripMenuItem.Text = "&Gameboy Advanced";
            this.gameboyAdvancedToolStripMenuItem.CheckedChanged += new System.EventHandler(this.gameboyAdvancedToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changelogToolStripMenuItem.Text = "&Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForStableReleaseToolStripMenuItem,
            this.checkForAnyReleaseToolStripMenuItem});
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            // 
            // checkForStableReleaseToolStripMenuItem
            // 
            this.checkForStableReleaseToolStripMenuItem.Name = "checkForStableReleaseToolStripMenuItem";
            this.checkForStableReleaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkForStableReleaseToolStripMenuItem.Text = "Check for &Stable Release";
            this.checkForStableReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForStableReleaseToolStripMenuItem_Click);
            // 
            // checkForAnyReleaseToolStripMenuItem
            // 
            this.checkForAnyReleaseToolStripMenuItem.Name = "checkForAnyReleaseToolStripMenuItem";
            this.checkForAnyReleaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkForAnyReleaseToolStripMenuItem.Text = "Check for &Any Release";
            this.checkForAnyReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForAnyReleaseToolStripMenuItem_Click);
            // 
            // bSelect
            // 
            this.bSelect.AutoSize = true;
            this.bSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSelect.Location = new System.Drawing.Point(49, 38);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(33, 17);
            this.bSelect.TabIndex = 1;
            this.bSelect.Text = "&B";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.CheckedChanged += new System.EventHandler(this.bSelect_CheckedChanged);
            // 
            // aSelect
            // 
            this.aSelect.AutoSize = true;
            this.aSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aSelect.Location = new System.Drawing.Point(10, 38);
            this.aSelect.Name = "aSelect";
            this.aSelect.Size = new System.Drawing.Size(33, 17);
            this.aSelect.TabIndex = 0;
            this.aSelect.Text = "&A";
            this.aSelect.UseVisualStyleBackColor = true;
            this.aSelect.CheckedChanged += new System.EventHandler(this.aSelect_CheckedChanged);
            // 
            // startSelect
            // 
            this.startSelect.AutoSize = true;
            this.startSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startSelect.Location = new System.Drawing.Point(10, 61);
            this.startSelect.Name = "startSelect";
            this.startSelect.Size = new System.Drawing.Size(48, 17);
            this.startSelect.TabIndex = 4;
            this.startSelect.Text = "S&tart";
            this.startSelect.UseVisualStyleBackColor = true;
            this.startSelect.CheckedChanged += new System.EventHandler(this.startSelect_CheckedChanged);
            // 
            // selectSelect
            // 
            this.selectSelect.AutoSize = true;
            this.selectSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectSelect.Location = new System.Drawing.Point(93, 61);
            this.selectSelect.Name = "selectSelect";
            this.selectSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.selectSelect.Size = new System.Drawing.Size(56, 17);
            this.selectSelect.TabIndex = 5;
            this.selectSelect.Text = "&Select";
            this.selectSelect.UseVisualStyleBackColor = true;
            this.selectSelect.CheckedChanged += new System.EventHandler(this.selectSelect_CheckedChanged);
            // 
            // lSelect
            // 
            this.lSelect.AutoSize = true;
            this.lSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lSelect.Location = new System.Drawing.Point(10, 15);
            this.lSelect.Name = "lSelect";
            this.lSelect.Size = new System.Drawing.Size(32, 17);
            this.lSelect.TabIndex = 3;
            this.lSelect.Text = "&L";
            this.lSelect.UseVisualStyleBackColor = true;
            this.lSelect.CheckedChanged += new System.EventHandler(this.lSelect_CheckedChanged);
            // 
            // rSelect
            // 
            this.rSelect.AutoSize = true;
            this.rSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rSelect.Location = new System.Drawing.Point(115, 15);
            this.rSelect.Name = "rSelect";
            this.rSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rSelect.Size = new System.Drawing.Size(34, 17);
            this.rSelect.TabIndex = 2;
            this.rSelect.Text = "&R";
            this.rSelect.UseVisualStyleBackColor = true;
            this.rSelect.CheckedChanged += new System.EventHandler(this.rSelect_CheckedChanged);
            // 
            // xSelect
            // 
            this.xSelect.AutoSize = true;
            this.xSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xSelect.Location = new System.Drawing.Point(83, 38);
            this.xSelect.Name = "xSelect";
            this.xSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xSelect.Size = new System.Drawing.Size(33, 17);
            this.xSelect.TabIndex = 6;
            this.xSelect.Text = "&X";
            this.xSelect.UseVisualStyleBackColor = true;
            this.xSelect.CheckedChanged += new System.EventHandler(this.xSelect_CheckedChanged);
            // 
            // ySelect
            // 
            this.ySelect.AutoSize = true;
            this.ySelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ySelect.Location = new System.Drawing.Point(116, 38);
            this.ySelect.Name = "ySelect";
            this.ySelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ySelect.Size = new System.Drawing.Size(33, 17);
            this.ySelect.TabIndex = 7;
            this.ySelect.Text = "&Y";
            this.ySelect.UseVisualStyleBackColor = true;
            this.ySelect.CheckedChanged += new System.EventHandler(this.ySelect_CheckedChanged);
            // 
            // buttonsGroup
            // 
            this.buttonsGroup.Controls.Add(this.ySelect);
            this.buttonsGroup.Controls.Add(this.xSelect);
            this.buttonsGroup.Controls.Add(this.rSelect);
            this.buttonsGroup.Controls.Add(this.lSelect);
            this.buttonsGroup.Controls.Add(this.selectSelect);
            this.buttonsGroup.Controls.Add(this.startSelect);
            this.buttonsGroup.Controls.Add(this.aSelect);
            this.buttonsGroup.Controls.Add(this.bSelect);
            this.buttonsGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonsGroup.Location = new System.Drawing.Point(142, 29);
            this.buttonsGroup.Name = "buttonsGroup";
            this.buttonsGroup.Size = new System.Drawing.Size(163, 82);
            this.buttonsGroup.TabIndex = 18;
            this.buttonsGroup.TabStop = false;
            this.buttonsGroup.Text = "Buttons";
            // 
            // dsCloseSelect
            // 
            this.dsCloseSelect.AutoSize = true;
            this.dsCloseSelect.Location = new System.Drawing.Point(142, 114);
            this.dsCloseSelect.Name = "dsCloseSelect";
            this.dsCloseSelect.Size = new System.Drawing.Size(80, 23);
            this.dsCloseSelect.TabIndex = 21;
            this.dsCloseSelect.Text = "D&S Close";
            this.dsCloseSelect.UseVisualStyleBackColor = true;
            this.dsCloseSelect.Click += new System.EventHandler(this.dsCloseSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 198);
            this.Controls.Add(this.debugButtonSelect);
            this.Controls.Add(this.dsCloseSelect);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.buttonsGroup);
            this.Controls.Add(this.dPadGroup);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 236);
            this.MinimumSize = new System.Drawing.Size(328, 236);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Button Activator Calculator";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.dPadGroup.ResumeLayout(false);
            this.dPadGroup.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.buttonsGroup.ResumeLayout(false);
            this.buttonsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox upSelect;
        private System.Windows.Forms.CheckBox leftSelect;
        private System.Windows.Forms.CheckBox rightSelect;
        private System.Windows.Forms.CheckBox downSelect;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox outputDisplay;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.GroupBox dPadGroup;
        private System.Windows.Forms.Button debugButtonSelect;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForStableReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAnyReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nintendoDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameboyAdvancedToolStripMenuItem;
        private System.Windows.Forms.CheckBox bSelect;
        private System.Windows.Forms.CheckBox aSelect;
        private System.Windows.Forms.CheckBox startSelect;
        private System.Windows.Forms.CheckBox selectSelect;
        private System.Windows.Forms.CheckBox lSelect;
        private System.Windows.Forms.CheckBox rSelect;
        private System.Windows.Forms.CheckBox xSelect;
        private System.Windows.Forms.CheckBox ySelect;
        private System.Windows.Forms.GroupBox buttonsGroup;
        private System.Windows.Forms.Button dsCloseSelect;
    }
}

