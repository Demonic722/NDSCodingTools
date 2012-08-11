namespace XD_and_Colosseum_RNG_Tool
{
    partial class frmChangelog
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

        #region InitializeComponent()

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangelog));
            this.changelogText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.currentVersion = new System.Windows.Forms.Label();
            this.betaNotesToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changelogText
            // 
            this.changelogText.BackColor = System.Drawing.SystemColors.Control;
            this.changelogText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changelogText.Location = new System.Drawing.Point(12, 12);
            this.changelogText.Multiline = true;
            this.changelogText.Name = "changelogText";
            this.changelogText.ReadOnly = true;
            this.changelogText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.changelogText.Size = new System.Drawing.Size(351, 178);
            this.changelogText.TabIndex = 0;
            this.changelogText.Text = resources.GetString("changelogText.Text");
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(288, 196);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // currentVersion
            // 
            this.currentVersion.AutoSize = true;
            this.currentVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersion.Location = new System.Drawing.Point(9, 199);
            this.currentVersion.Name = "currentVersion";
            this.currentVersion.Size = new System.Drawing.Size(124, 15);
            this.currentVersion.TabIndex = 2;
            this.currentVersion.Text = "Current Version: 2.5.5";
            // 
            // betaNotesToggle
            // 
            this.betaNotesToggle.Location = new System.Drawing.Point(182, 196);
            this.betaNotesToggle.Name = "betaNotesToggle";
            this.betaNotesToggle.Size = new System.Drawing.Size(100, 23);
            this.betaNotesToggle.TabIndex = 3;
            this.betaNotesToggle.Text = "Show &Beta Notes";
            this.betaNotesToggle.UseVisualStyleBackColor = true;
            this.betaNotesToggle.Visible = false;
            // 
            // frmChangelog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 222);
            this.Controls.Add(this.betaNotesToggle);
            this.Controls.Add(this.currentVersion);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changelogText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(383, 256);
            this.MinimumSize = new System.Drawing.Size(383, 256);
            this.Name = "frmChangelog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " Changelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox changelogText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label currentVersion;
        private System.Windows.Forms.Button betaNotesToggle;
    }
}