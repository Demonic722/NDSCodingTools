using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace XD_and_Colosseum_RNG_Tool
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.ActiveControl = okButton;
        }

        private void okButton_Click(object sender, EventArgs e) { this.Close(); }
    }
}
