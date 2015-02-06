using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ReallyEasyResize
{
    public partial class frmMain : Form
    {
        /**
         * Init stuff
         **/
        public frmMain()
        {
            InitializeComponent();

            // Set the default save path
            txtSaveDest.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtSaveDest.Text.TrimEnd(Path.DirectorySeparatorChar);
            txtSaveDest.Text += Path.DirectorySeparatorChar + "Resize_";
            txtSaveDest.Text += System.DateTime.Now.ToString("dd_MMM_yyyy");
        }


        /**
         * About box button
         **/
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }


        /**
         * Adds a file into the queue
         */
        private void addFileToQueue(string path)
        {
            if (Resizer.formatFromExt(path) == null) {
                throw new Exception("Unsupported file type");
            }

            foreach (ListViewItem it in lstQueue.Items) {
                if (it.Tag.Equals(path)) return;
            }

            ListViewItem item = new ListViewItem();
            item.Text = Path.GetFileName(path);
            item.ToolTipText = path;
            item.Tag = path;
            item.ImageIndex = -1;
            lstQueue.Items.Add(item);

            timThumbnails.Enabled = true;
            //this.Refresh();
        }


        /**
         * Process a single thumbnail per tick
         * If nothing is found to be done, the timer is disabled.
         */
        private void timThumbnails_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem it in lstQueue.Items) {
                if (it.ImageIndex == -1) {
                    Bitmap orig = new Bitmap((string)it.Tag);
                    Bitmap icon = doScale(orig, imgQueue.ImageSize.Width, imgQueue.ImageSize.Height);
                    orig.Dispose();
                    imgQueue.Images.Add(icon);
                    it.ImageIndex = imgQueue.Images.Count - 1;

                    return;
                }
            }

            timThumbnails.Enabled = false;
        }


        /**
         * Recursivly add images in a directory to the queue
         * Returns the number of failures
         **/
        private int addFolderToQueue(string folderPath)
        {
            int failures = 0;
            string[] entries;

            entries = Directory.GetDirectories(folderPath);
            foreach (string path in entries) {
                failures += this.addFolderToQueue(path);
            }

            entries = Directory.GetFiles(folderPath);
            foreach (string path in entries) {
                try {
                    this.addFileToQueue(path);
                } catch {
                    failures++;
                }
            }

            return failures;
        }


        /**
         * Scales images
         */
        private Bitmap doScale(Bitmap src, int desiredWidth, int desiredHeight)
        {
            Rectangle size = Resizer.calcDestSize(src, desiredWidth, desiredHeight);
            Bitmap dest = new Bitmap(desiredWidth, desiredHeight);
            Graphics g = Graphics.FromImage(dest);
            g.DrawImage(src, (desiredWidth - size.Width) / 2, (desiredHeight - size.Height) / 2, size.Width, size.Height);
            return dest;
        }


        /**
         * Dialog UI for adding files to the queue
         */
        private void btnSelFiles_Click(object sender, EventArgs e)
        {
            int failures = 0;

            if (diaSelFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                grpQueue.Enabled = false;
                btnBeginResize.Enabled = false;

                foreach (string path in diaSelFiles.FileNames) {
                    try {
                        this.addFileToQueue(path);
                    } catch {
                        failures++;
                    }
                }

                grpQueue.Enabled = true;
                btnBeginResize.Enabled = true;

                if (failures != 0) {
                    if (diaSelFiles.FileNames.Length == 1) {
                        MessageBox.Show("The file you selected is not an image");
                    } else {
                        MessageBox.Show(failures + " files could not be added because they are not images");
                    }
                }
            }
        }


        /**
         * Dialog UI for adding folders to the queue
         */
        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            if (diaSelFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                grpQueue.Enabled = false;
                btnBeginResize.Enabled = false;

                int failures = this.addFolderToQueue(diaSelFolder.SelectedPath);

                grpQueue.Enabled = true;
                btnBeginResize.Enabled = true;

                if (failures != 0) {
                    MessageBox.Show(failures + " files within your folder could not be added because they are not images");
                }
            }
        }


        /**
         * Set drag-drop icon but only when dropping files
         */
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }


        /**
         * Do the drag-drop
         */
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            int failures = 0;

            grpQueue.Enabled = false;
            btnBeginResize.Enabled = false;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in files) {
                if (Directory.Exists(path)) {
                    this.addFolderToQueue(path);
                } else {
                    try {
                        this.addFileToQueue(path);
                    } catch {
                        failures++;
                    }
                }
            }

            if (failures != 0) {
                MessageBox.Show(failures + " file(s) could not be added because they are not images");
            }

            grpQueue.Enabled = true;
            btnBeginResize.Enabled = true;
        }


        /**
         * Dialog UI for selecting save destination
         */
        private void btnSaveDest_Click(object sender, EventArgs e)
        {
            if (diaSaveDest.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtSaveDest.Text = diaSaveDest.SelectedPath;
            }
        }

        private void btnBeginResize_Click(object sender, EventArgs e)
        {
            if (lstQueue.Items.Count == 0) {
                MessageBox.Show("No images have been selected for resizing");
                return;
            }

            frmProgress prog = new frmProgress(this);
            Resizer r = new Resizer(prog);

            if (!int.TryParse(txtWidth.Text, out r.desiredWidth)) {
                MessageBox.Show("Unable to parse 'width' field as a number");
                return;
            }

            if (!int.TryParse(txtHeight.Text, out r.desiredHeight)) {
                MessageBox.Show("Unable to parse 'height' field as a number");
                return;
            }

            if (!long.TryParse(txtJpegQty.Text, out r.jpegQty)) {
                MessageBox.Show("Unable to parse 'jpg qty' field as a number");
                return;
            }

            prog.Setup(lstQueue.Items.Count);
            prog.Show();

            grpQueue.Enabled = false;
            grpSettings.Enabled = false;
            grpSave.Enabled = false;
            btnBeginResize.Enabled = false;

            r.destDir = txtSaveDest.Text;
            if (!r.destDir.EndsWith(Path.DirectorySeparatorChar.ToString())) {
                r.destDir += Path.DirectorySeparatorChar;
            }
            
            if (!Directory.Exists(r.destDir)) {
                Directory.CreateDirectory(r.destDir);
            }

            foreach (ListViewItem it in lstQueue.Items) {
                r.srcPaths.Add((string)it.Tag);
            }

            Thread t = new Thread(new ThreadStart(r.run));
            t.IsBackground = true;
            t.Start();
        }

        public void Complete()
        {
            grpQueue.Enabled = true;
            grpSettings.Enabled = true;
            grpSave.Enabled = true;
            btnBeginResize.Enabled = true;
            MessageBox.Show("Image resizing complete");
        }
    }
}
