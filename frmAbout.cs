using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReallyEasyResize
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void clickLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lab = (LinkLabel)sender;
            System.Diagnostics.Process.Start(lab.Text);
        }
    }
}
