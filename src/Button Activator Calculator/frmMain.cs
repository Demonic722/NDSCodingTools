using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Button_Activator_Calculator
{
    public partial class frmMain : Form
    {
        public int value = 0;

        public void updateOutput()
        {
            /* Updates outputDisplay to show the activator */

            if (value != 0) outputDisplay.Text = "#0x" + value.ToString("X");
            else outputDisplay.Text = "#0x0";

            if (xSelect.Checked || ySelect.Checked) valueLabel.Text = "tst the value in 0x027FFFA8 to";
            else valueLabel.Text = "tst the value in 0x04000130 to";
        }

        public void clearAll(object sender, EventArgs e)
        {
            /* Clear all checkboxes and clear value */

            aSelect.Checked = bSelect.Checked =
            xSelect.Checked = ySelect.Checked =
            lSelect.Checked = rSelect.Checked =
            startSelect.Checked = selectSelect.Checked =
            upSelect.Checked = downSelect.Checked =
            leftSelect.Checked = rightSelect.Checked = false;

            value = 0;
        }

        private void copyOutput(object sender, EventArgs e)
        {
            /* Copies output to clipboard */

            Clipboard.SetText(outputDisplay.Text);
            MessageBox.Show("The following has been copied to the clipboard:\n\n" + outputDisplay.Text, "Success");
        }

        public frmMain()
        {
            InitializeComponent();
            this.ActiveControl = copyButton; // Set focus away from outputDisplay
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            // Check for updates in background
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(0);
            update = null; // Free up memory, we don't need this any more
        }

        /** Adds or subtracts proper values for the buttons:
         *    A: 1
         *    B: 2
         *    Start: 4
         *    Select: 8
         *    R: 256
         *    L: 512
         *    X: 1024
         *    Y: 2048
        **/
        private void aSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (aSelect.Checked) value++;
            else value--;

            updateOutput();
        }
        private void bSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (bSelect.Checked) value += 2;
            else value -= 2;

            updateOutput();
        }
        private void selectSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (selectSelect.Checked) value += 4;
            else value -= 4;

            updateOutput();
        }
        private void startSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (startSelect.Checked) value += 8;
            else value -= 8;

            updateOutput();
        }
        private void rSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rSelect.Checked) value += 256;
            else value -= 256;

            updateOutput();
        }
        private void lSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (lSelect.Checked) value += 512;
            else value -= 512;

            updateOutput();
        }
        private void xSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (xSelect.Checked) value += 1024;
            else value -= 4;

            updateOutput();
        }
        private void ySelect_CheckedChanged(object sender, EventArgs e)
        {
            if (ySelect.Checked) value += 2048;
            else value -= 8;

            updateOutput();
        }

        // The D-Pad labels aren't part of the checkboxes, this makes them act as if they are
        private void upLabel_Click(object sender, EventArgs e)
        {
            if (!upSelect.Checked) upSelect.Checked = true;
            else upSelect.Checked = false;
        }
        private void rightLabel_Click(object sender, EventArgs e)
        {
            if (!rightSelect.Checked) rightSelect.Checked = true;
            else rightSelect.Checked = false;
        }
        private void downLabel_Click(object sender, EventArgs e)
        {
            if (!downSelect.Checked) downSelect.Checked = true;
            else downSelect.Checked = false;
        }
        private void leftLabel_Click(object sender, EventArgs e)
        {
            if (!leftSelect.Checked) leftSelect.Checked = true;
            else leftSelect.Checked = false;
        }

        /** Adds or subtracts proper values for the D-Pad:
         *    Up: 64
         *    Right: 16
         *    Down: 128
         *    Left: 32
         *  Also makes checkboxes act as a radio button group
        **/
        private void upSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (upSelect.Checked)
            {
                value += 64;

                if (leftSelect.Checked) leftSelect.Checked = false;
                if (rightSelect.Checked) rightSelect.Checked = false;
                if (downSelect.Checked) downSelect.Checked = false;
            }
            else value -= 64;

            updateOutput();
        }
        private void rightSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rightSelect.Checked)
            {
                value += 16;

                if (upSelect.Checked) upSelect.Checked = false;
                if (leftSelect.Checked) leftSelect.Checked = false;
                if (downSelect.Checked) downSelect.Checked = false;
            }
            else value -= 16;

            updateOutput();
        }
        private void downSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (downSelect.Checked)
            {
                value += 128;

                if (upSelect.Checked) upSelect.Checked = false;
                if (leftSelect.Checked) leftSelect.Checked = false;
                if (rightSelect.Checked) rightSelect.Checked = false;
            }
            else value -= 128;

            updateOutput();
        }
        private void leftSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (leftSelect.Checked)
            {
                value += 32;

                if (upSelect.Checked) upSelect.Checked = false;
                if (rightSelect.Checked) rightSelect.Checked = false;
                if (downSelect.Checked) downSelect.Checked = false;
            }
            else value -= 32;

            updateOutput();
        }

        /** Our DS-specific actions:
         *    DS Close: 32768
         *    Debug Button: 8192
         *  They will set the output directly to 0x8000 and 0x2000 respectively
         *  and they will not modify value expect for clearing it.
        **/
        private void dsCloseSelect_Click(object sender, EventArgs e)
        {
            clearAll(sender, e);
            outputDisplay.Text = "#0x8000";
            valueLabel.Text = "tst the value in 0x027FFFA8 to";
        }
        private void debugButtonSelect_Click(object sender, EventArgs e)
        {
            clearAll(sender, e);
            outputDisplay.Text = "#0x2000";
            valueLabel.Text = "tst the value in 0x027FFFA8 to";
        }

        /* Menu Bar Items */

        /// File
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        // Edit uses methods from above

        /// View
        //
        private void nintendoDSToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (nintendoDSToolStripMenuItem.Checked)
            {
                gameboyAdvancedToolStripMenuItem.Checked = false;

                dsCloseSelect.Enabled = debugButtonSelect.Enabled =
                xSelect.Enabled = ySelect.Enabled = true;
            }
        }
        private void gameboyAdvancedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (gameboyAdvancedToolStripMenuItem.Checked)
            {
                nintendoDSToolStripMenuItem.Checked = false;

                dsCloseSelect.Enabled = debugButtonSelect.Enabled =
                xSelect.Enabled = ySelect.Enabled = false;

                xSelect.Checked = ySelect.Checked = false;
                updateOutput();
            }
        }

        /// Help
        //
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutWindow = new frmAbout();
            aboutWindow.Show();
        }
        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangelog changelogWindow = new frmChangelog();
            changelogWindow.Show();
        }
        private void checkForStableReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(2);
            update = null; // Free up memory, unless the user keeps clicking this, it's better
        }
        private void checkForAnyReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(1);
            update = null; // Free up memory, same deal as above
        }
    }
}
