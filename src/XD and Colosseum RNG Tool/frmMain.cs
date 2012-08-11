using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace XD_and_Colosseum_RNG_Tool
{
    public partial class frmMain : Form
    {
        public frmMain() { InitializeComponent(); }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            // At this point, statusLabel.Text == "Loading..."

            this.ActiveControl = pidIvLabel; // Set active control away from a textbox

            statusLabel.Text = "Checking for updates...";
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(0);
            update = null; // Free up memory, we don't need this any more

            statusLabel.Text = "Ready"; // Done loading, display "Ready"
        }

        // Limit inputs to valid decimal and hexadecimal values
        // Keeps decimal values under 4294967295
        // Also a method to keep IV values under 31
        private void checkDec_KeyPress(object sender, KeyPressEventArgs e) 
        {
            TextBox txt = sender as TextBox;
            if ( (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)   ||
                 (txt.TextLength == 0 && e.KeyChar == '0') )               ||
               (((txt.TextLength == 9 && (int.Parse(txt.Text) > 429496729  ||
                   (int.Parse(txt.Text) == 429496729 && e.KeyChar > '5'))) ||
                   txt.TextLength > 9 ) && !char.IsControl(e.KeyChar) )     )
                       e.Handled = true;
        }
        private void checkHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if ((!char.IsDigit(e.KeyChar) && (e.KeyChar < 'a' || e.KeyChar > 'f') &&
                (e.KeyChar < 'A' || e.KeyChar > 'F')) && !char.IsControl(e.KeyChar) ||
                (txt.TextLength == 0 && e.KeyChar == '0'))
                    e.Handled = true;
        }
        private void checkIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (( (txt.TextLength == 1 && (int.Parse(txt.Text) > 3   ||
                   (int.Parse(txt.Text) == 3 && e.KeyChar > '1'))  ) ||
                   txt.TextLength > 1 ) && !char.IsControl(e.KeyChar) )
                       e.Handled = true;
        }

        private Boolean runSearch(UInt32 ivseed1, UInt32 ivseed2, UInt32 upid, UInt32 lpid)
        {
            xdRNG xd;
            uint seed;

            for (int i = 0; i < 65536; i++)
            {
                seed = (uint)((ivseed1 << 16) + i);
                xd = new xdRNG(seed);

                if ( (xd.previewHalfAdvance(seed, 1) == ivseed2) &&
                     (xd.previewHalfAdvance(seed, 3) == upid)    &&
                     (xd.previewHalfAdvance(seed, 4) == lpid)     )
                        return true;
            }

            return false;
        } 

        private void checkButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Checking legality...";
            progressBar.Visible = true;
            
            byte hp, atk, def, spa, spd, spe;
            uint ivseed1, ivseed2, upid, lpid, pid;

            statusLabel.Text = "Parsing data...";
            progressBar.Value = 25;

            byte.TryParse(hpText.Text, System.Globalization.NumberStyles.Number, null, out hp);
            byte.TryParse(atkText.Text, System.Globalization.NumberStyles.Number, null, out atk);
            byte.TryParse(defText.Text, System.Globalization.NumberStyles.Number, null, out def);
            byte.TryParse(spaText.Text, System.Globalization.NumberStyles.Number, null, out spa);
            byte.TryParse(spdText.Text, System.Globalization.NumberStyles.Number, null, out spd);
            byte.TryParse(speText.Text, System.Globalization.NumberStyles.Number, null, out spe);
            uint.TryParse(pidText.Text, System.Globalization.NumberStyles.Number, null, out pid);

            ivseed1 = (uint)(hp + (atk << 5) + (def << 10));
            ivseed2 = (uint)(spe + (spa << 5) + (spd << 10));
            upid = (ushort)(pid >> 16);
            lpid = (ushort)(pid & 0xffff);

            statusLabel.Text = "Configuring output...";
            progressBar.Value = 50;

            pidOutput.BackgroundColor = Color.White;
            pidOutput.Rows.Clear();
            pidOutput.Columns.Clear();
            pidOutput.Columns.Add("", "");
            pidOutput.Columns[0].Width = 207;

            statusLabel.Text = "Running IV search...";
            progressBar.Value = 75;

            // 4 possibilities
            if ( runSearch(ivseed1, ivseed2, upid, lpid)                  ||
                 runSearch(ivseed1 + 0x8000, ivseed2, upid, lpid)         ||
                 runSearch(ivseed1, ivseed2 + 0x8000, upid, lpid)         ||
                 runSearch(ivseed1 + 0x8000, ivseed2 + 0x8000, upid, lpid) )
            {
                string leg = "Legal";
                pidOutput.Rows.Add(leg.ToString());
            }
            else
            {
                string ileg = "Illegal";
                pidOutput.Rows.Add(ileg.ToString());
            }

            statusLabel.Text = "Legality checking complete.";
            progressBar.Value = 100;
            Thread.Sleep(50); // Flash the full status bar
            progressBar.Visible = false;
        }   
  
        private void pidStart_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Finding desired PID...";
            progressBar.Visible = true;
            
            byte hp, atk, def, spa, spd, spe;
            uint seed, pid, ivseed1, ivseed2;

            statusLabel.Text = "Parsing data...";
            progressBar.Value = 25;

            byte.TryParse(dhpText.Text, System.Globalization.NumberStyles.Number, null, out hp);
            byte.TryParse(datkText.Text, System.Globalization.NumberStyles.Number, null, out atk);
            byte.TryParse(ddefText.Text, System.Globalization.NumberStyles.Number, null, out def);
            byte.TryParse(dspaText.Text, System.Globalization.NumberStyles.Number, null, out spa);
            byte.TryParse(dspdText.Text, System.Globalization.NumberStyles.Number, null, out spd);
            byte.TryParse(dspeText.Text, System.Globalization.NumberStyles.Number, null, out spe);

            ivseed1 = (uint)(hp + (atk << 5) + (def << 10));
            ivseed2 = (uint)(spe + (spa << 5) + (spd << 10));

            statusLabel.Text = "Configuring output...";
            progressBar.Value = 50;

            pidOutput.BackgroundColor = Color.White;
            pidOutput.Rows.Clear();
            pidOutput.Columns.Clear();
            pidOutput.Columns.Add("Seed", "Seed");
            pidOutput.Columns[0].Width = 70;
            pidOutput.Columns.Add("PID", "PID");
            pidOutput.Columns[1].Width = 70;
            pidOutput.Columns.Add("Nature", "Nature");
            pidOutput.Columns[2].Width = 67;

            statusLabel.Text = "Running PID search...";
            progressBar.Value = 75;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 65536; j++)
                {
                    seed = (uint)(((ivseed1 + (i << 15)) << 16) + j);
                    xdRNG xd = new xdRNG(seed);

                    if ((xd.previewHalfAdvance(seed, 1) & 0x7FFF) == ivseed2)
                    {
                        pid = xd.getPID();
                        pidOutput.Rows.Add(seed.ToString("X"), pid.ToString("X"), xd.getNature(pid).ToString());
                    }
                }

            statusLabel.Text = "PID search complete.";
            progressBar.Value = 100;
            Thread.Sleep(50); // Flash the full status bar
            progressBar.Visible = false;
        }

        private void rngStart_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Running RNG...";
            progressBar.Visible = true;

            uint frame = 0;
            uint startSeed = 0;
            xdRNG xd;

            statusLabel.Text = "Parsing data...";
            progressBar.Value = 25;

            // If the value of the dropdown is invalid, set it to "Advance XD RNG"
            if (rngDirectionChoice.SelectedIndex != 0 && rngDirectionChoice.SelectedIndex != 1)
                rngDirectionChoice.SelectedIndex = 0;

            uint.TryParse(frameText.Text, System.Globalization.NumberStyles.Number, null, out frame);
            uint.TryParse(seedStartText.Text, System.Globalization.NumberStyles.HexNumber, null, out startSeed);

            statusLabel.Text = "Configuring output...";
            progressBar.Value = 50;

            rngOutput.BackgroundColor = Color.White;
            rngOutput.Rows.Clear();
            rngOutput.Columns.Clear();
            rngOutput.Columns.Add("Frame", "Frame");
            rngOutput.Columns[0].Width = 48;
            rngOutput.Columns.Add("Seed", "Seed");
            rngOutput.Columns[1].Width = 145;

            statusLabel.Text = "Running RNG...";
            progressBar.Value = 75;

            xd = new xdRNG(startSeed);

            switch (rngDirectionChoice.SelectedIndex)
            {
                case 0: // Advance the RNG
                    for (int i = 0; i <= frame; i++)
                    {
                        rngOutput.Rows.Add((i).ToString(), xd.getSeed().ToString("X8"));
                        xd.advanceXD();
                    }
                    break;
                case 1: // Reverse the RNG
                    for (int i = 0; i <= frame; i++)
                    {
                        rngOutput.Rows.Add((i).ToString(), xd.getSeed().ToString("X8"));
                        xd.reverseXD();
                    }
                    break;
                default: break;
            }

            statusLabel.Text = "RNG run complete.";
            progressBar.Value = 100;
            Thread.Sleep(50); // Flash the full status bar
            progressBar.Visible = false;
        }

        /* Menu bar methods */

        // File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        // View
        private void statusBarToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            // Toggles status bar visibility
            if (!statusBarToolStripMenuItem.Checked)
            {
                statusStrip.Visible = false; // Hides status bar

                // Makes window 24 pixels smaller in height
                this.MaximumSize = new Size(this.MaximumSize.Width, this.MaximumSize.Height - 24);
                this.MinimumSize = new Size(this.MinimumSize.Width, this.MinimumSize.Height - 24);
                this.Size = new Size(this.Size.Width, this.Size.Height - 24);

                // Adds 24 pixels height to the groupboxes
                rngGroup.Size = new System.Drawing.Size(rngGroup.Size.Width, rngGroup.Size.Height + 24);
                pidGroup.Size = new System.Drawing.Size(pidGroup.Size.Width, pidGroup.Size.Height + 24);
            }
            else
            {
                // Reduce groupboxes by 24 pixels
                rngGroup.Size = new System.Drawing.Size(rngGroup.Size.Width, rngGroup.Size.Height - 24);
                pidGroup.Size = new System.Drawing.Size(pidGroup.Size.Width, pidGroup.Size.Height - 24);

                // Add 24 pixels to window height, make room for status bar
                this.MaximumSize = new Size(this.MaximumSize.Width, this.MaximumSize.Height + 24);
                this.MinimumSize = new Size(this.MinimumSize.Width, this.MinimumSize.Height + 24);
                this.Size = new Size(this.Size.Width, this.Size.Height + 24);

                statusStrip.Visible = true; // Show status bar
            }
        }

        // Help
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
            statusLabel.Text = "Checking for updates...";
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(2);
            update = null; // Free up memory, unless the user keeps clicking this, it's better
        }
        private void checkForAnyReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Checking for updates...";
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(1);
            update = null; // Free up memory, same deal as above
        }

        /* Status strip methods */

        // Sets to "Ready", for leave methods
        private void setReady_Leave(object sender, EventArgs e) { statusLabel.Text = "Ready"; }
        private void setReady_MouseLeave(object sender, EventArgs e) { statusLabel.Text = "Ready"; }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!btn.Focused) statusLabel.Text = "Ready";
        }
        private void rngDirectionChoice_MouseLeave(object sender, EventArgs e)
        {
            if (!rngDirectionChoice.Focused)
                statusLabel.Text = "Ready";
        }

        // PID input
        private void pidText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter PID"; }

        // IV inputs
        private void hpText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter HP"; }
        private void atkText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter Attack"; }
        private void defText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter Defense"; }
        private void spaText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter Special Attack"; }
        private void spdText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter Special Defense"; }
        private void speText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter Speed"; }

        // Desired IV inputs
        private void dhpText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired HP"; }
        private void datkText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired Attack"; }
        private void ddefText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired Defense"; }
        private void dspaText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired Special Attack"; }
        private void dspdText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired Special Defense"; }
        private void dspeText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter desired Speed"; }

        // RNG settings
        private void frameText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter frame count"; }
        private void seedStartText_Enter(object sender, EventArgs e) { statusLabel.Text = "Enter starting seed"; }

        // Menu bar hovers
        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e) { statusLabel.Text = "File"; }
        //
        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Exit the application"; }

        private void viewToolStripMenuItem_MouseHover(object sender, EventArgs e) { statusLabel.Text = "View"; }
        //
        private void statusBarToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Toggle status strip visibility"; }

        private void runToolStripMenuItem_MouseHover(object sender, EventArgs e) { statusLabel.Text = "Run"; }
        //
        private void checkLegality_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Check IV legality"; }
        private void getPID_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Find PID"; }
        private void runRNG_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Run RNG"; }

        private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e) { statusLabel.Text = "Help"; }
        //
        private void aboutToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Information about this application"; }
        private void changelogToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "View changes between versions of this application"; }
        private void checkForUpdatesToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Check online for updates to this application"; }
        private void checkForStableReleaseToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Check only for stable releases"; }
        private void checkForAnyReleaseToolStripMenuItem_MouseHover(object sender, EventArgs e)
            { statusLabel.Text = "Check for any updates, stable or unstable"; }

        // The direction choice box
        private void rngDirectionChoice_MouseHover(object sender, EventArgs e)
        {
            if(!rngDirectionChoice.Focused)
                statusLabel.Text = "Choose for the RNG to move forward or backward";
        }
        
        private void rngDirectionChoice_Enter(object sender, EventArgs e)
            { statusLabel.Text = "Choose for the RNG to move forward or backward"; }
        private void rngDirectionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rngDirectionChoice.SelectedIndex == 0) statusLabel.Text = "RNG will move forward.";
            else statusLabel.Text = "RNG will move backward.";
        }
    }   
}


