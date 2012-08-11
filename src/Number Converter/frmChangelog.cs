using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Number_Converter
{
    public partial class frmChangelog : Form
    {
        public bool betaEnabled = false;
        public string releaseNotes, betaNotes;

        public frmChangelog()
        {
            InitializeComponent();
            this.ActiveControl = okButton;
        }

        private void okButton_Click(object sender, EventArgs e) { this.Close(); }

        private void betaNotesToggle_Click(object sender, EventArgs e)
        {
            if (!betaEnabled)
            {
                betaEnabled = true;
                changelogText.Text = betaNotes;
                betaNotesToggle.Text = "Hide Beta Notes";
            }
            else
            {
                betaEnabled = false;
                changelogText.Text = releaseNotes;
                betaNotesToggle.Text = "Show Beta Notes";
            }
        }
    }
}
