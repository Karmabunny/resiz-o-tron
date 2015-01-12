using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReallyEasyResize
{
    public partial class frmProgress : Form
    {
        public delegate void ProgressDelegate();
        private frmMain main;

        public frmProgress(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }


        /**
         * Setup progress bar
         */
        public void Setup(int max)
        {
            progress.Value = 0;
            progress.Maximum = max;
        }


        /**
         * Increment progress bar
         */
        public void Increment()
        {
            progress.Value++;

            if (progress.Value == progress.Maximum) {
                timClose.Start();
            }
        }


        /**
         * Closing is delayed a little so the user sees 100% progress
         */
        private void timClose_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.main.Complete();
        }
    }
}
