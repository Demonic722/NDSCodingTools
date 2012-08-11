using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Button_Activator_Calculator
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
