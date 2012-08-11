using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Number_Converter
{
    public partial class frmMain : Form
    {
        public int parsed;

        public frmMain()
        {
            InitializeComponent();
            hexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            // Check for updates in background
            UpdateApplication update = new UpdateApplication();
            update.InstallUpdateSyncWithInfo(0);
            update = null; // Free up memory, we don't need this any more
        }

        private void decimalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' ||
                ((decimalBox.TextLength > 22 || hexBox.TextLength > 18 ||
                  binaryBox.TextLength > 22 || octalBox.TextLength > 22)
                  && !char.IsControl(e.KeyChar)) ||
                 (decimalBox.TextLength == 0 && e.KeyChar == '0') ||
                 (e.KeyChar == '-' && decimalBox.TextLength != 0) )
            {
                e.Handled = true;
                decimalLabel.ForeColor = Color.Red;
            }
        }
        private void hexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && (e.KeyChar < 'a' || e.KeyChar > 'f')
                && (e.KeyChar < 'A' || e.KeyChar > 'F')) && !char.IsControl(e.KeyChar) ||
                ((decimalBox.TextLength > 22 || hexBox.TextLength > 18 ||
                  binaryBox.TextLength > 22  || octalBox.TextLength > 22)
                  && !char.IsControl(e.KeyChar)) ||
                 (hexBox.TextLength == 0 && e.KeyChar == '0'))
            {
                e.Handled = true;
                hexLabel.ForeColor = Color.Red;
            }
        }
        private void binaryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '0' && !char.IsControl(e.KeyChar) ||
                ((decimalBox.TextLength > 22 || hexBox.TextLength > 18 ||
                  binaryBox.TextLength > 22  || octalBox.TextLength > 22)
                  && !char.IsControl(e.KeyChar)) ||
                 (binaryBox.TextLength == 0 && e.KeyChar == '0'))
            {
                e.Handled = true;
                binaryLabel.ForeColor = Color.Red;
            }
        }
        private void octalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                ((decimalBox.TextLength > 22 || hexBox.TextLength > 18 ||
                  binaryBox.TextLength > 22  || octalBox.TextLength > 22)
                  && !char.IsControl(e.KeyChar)) ||
                 (octalBox.TextLength == 0 && e.KeyChar == '0') ||
                  e.KeyChar == '8' || e.KeyChar == '9')
            {
                e.Handled = true;
                octalLabel.ForeColor = Color.Red;
            }
        }

        private void decimalBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (decimalLabel.ForeColor != Color.Black)
                decimalLabel.ForeColor = Color.Black;
        }
        private void hexBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (hexLabel.ForeColor != Color.Black)
                hexLabel.ForeColor = Color.Black;
        }
        private void binaryBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (binaryLabel.ForeColor != Color.Black)
                binaryLabel.ForeColor = Color.Black;
        }
        private void octalBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (octalLabel.ForeColor != Color.Black)
                octalLabel.ForeColor = Color.Black;
        }

        private void decimalBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(decimalBox.Text, out parsed))
            {
                hexBox.Text = hexCaps.Checked ? parsed.ToString("X") : parsed.ToString("x");
                if (binaryBox.Enabled) binaryBox.Text = Convert.ToString(parsed, 2);
                octalBox.Text = Convert.ToString(parsed, 8);
            }
            else if (decimalBox.Text == "-") { }
            else
            {
                hexBox.Text = "";
                if (binaryBox.Enabled) binaryBox.Text = "";
                octalBox.Text = "";
            }
        }
        private void hexBox_TextChanged(object sender, EventArgs e)
        {
            if (hexBox.Text == "") decimalBox.Text = "";
            else decimalBox.Text = int.Parse(hexBox.Text, NumberStyles.HexNumber).ToString();
        }
        private void binaryBox_TextChanged(object sender, EventArgs e)
        {
            if (binaryBox.Enabled)
            {
                if (binaryBox.Text == "") decimalBox.Text = "";
                else decimalBox.Text = Convert.ToInt32(binaryBox.Text, 2).ToString();
            }
        }
        private void octalBox_TextChanged(object sender, EventArgs e)
        {
            if (octalBox.Text == "") decimalBox.Text = "";
            else decimalBox.Text = Convert.ToInt32(octalBox.Text, 8).ToString();
        }

        private void hexCaps_CheckStateChanged(object sender, EventArgs e)
        {
            if (hexCaps.Checked)
            {
                if (hexBox.Text != "")
                    hexBox.Text = int.Parse(hexBox.Text, NumberStyles.HexNumber).ToString("X");
                hexBox.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                if (hexBox.Text != "")
                    hexBox.Text = int.Parse(hexBox.Text, NumberStyles.HexNumber).ToString("x");
                hexBox.CharacterCasing = CharacterCasing.Lower;
            }
        }

        /* Menu Bar Items */

        // File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        // View
        private void binaryEnabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!binaryEnabledToolStripMenuItem.Checked)
            {
                binaryBox.Enabled = false;
                binaryLabel.ForeColor = SystemColors.ControlDark;
                binaryBox.Text = "";
            }
            else
            {
                binaryBox.Enabled = true;
                binaryLabel.ForeColor = SystemColors.ControlText;
                // If there is text in the decimal box and it wouldn't overflow the binary box, give it to us
                if (decimalBox.Text != "" && Convert.ToString(int.Parse(decimalBox.Text), 2).Length < 24)
                    binaryBox.Text = Convert.ToString(int.Parse(decimalBox.Text), 2);
                else MessageBox.Show("The resulting binary number is too long to display.\n" +
                                     "To re-activate the binary box, shorten the other values accordingly.");
            }
        }

        // Help
        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangelog changelogBox = new frmChangelog();
            changelogBox.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutBox = new frmAbout();
            aboutBox.Show();
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
