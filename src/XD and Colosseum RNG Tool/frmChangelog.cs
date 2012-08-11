using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XD_and_Colosseum_RNG_Tool
{
    public partial class frmChangelog : Form
    {
        public frmChangelog()
        {
            InitializeComponent();
            this.ActiveControl = okButton;
        }

        private void okButton_Click(object sender, EventArgs e) { this.Close(); }
    }
}
