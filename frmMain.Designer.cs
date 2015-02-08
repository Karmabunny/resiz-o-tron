namespace ReallyEasyResize
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelFiles = new System.Windows.Forms.Button();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.lstQueue = new System.Windows.Forms.ListView();
            this.imgQueue = new System.Windows.Forms.ImageList(this.components);
            this.grpQueue = new System.Windows.Forms.GroupBox();
            this.diaSelFiles = new System.Windows.Forms.OpenFileDialog();
            this.diaSaveDest = new System.Windows.Forms.FolderBrowserDialog();
            this.diaSelFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJpegQty = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.txtSaveDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveDest = new System.Windows.Forms.Button();
            this.btnBeginResize = new System.Windows.Forms.Button();
            this.timThumbnails = new System.Windows.Forms.Timer(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpQueue.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.grpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelFiles
            // 
            this.btnSelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelFiles.Location = new System.Drawing.Point(516, 19);
            this.btnSelFiles.Name = "btnSelFiles";
            this.btnSelFiles.Size = new System.Drawing.Size(128, 23);
            this.btnSelFiles.TabIndex = 2;
            this.btnSelFiles.Text = "Add &files...";
            this.btnSelFiles.UseVisualStyleBackColor = true;
            this.btnSelFiles.Click += new System.EventHandler(this.btnSelFiles_Click);
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelFolder.Location = new System.Drawing.Point(516, 48);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(128, 23);
            this.btnSelFolder.TabIndex = 3;
            this.btnSelFolder.Text = "Add fo&lder...";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // lstQueue
            // 
            this.lstQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstQueue.LargeImageList = this.imgQueue;
            this.lstQueue.Location = new System.Drawing.Point(8, 21);
            this.lstQueue.Margin = new System.Windows.Forms.Padding(5);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(500, 229);
            this.lstQueue.SmallImageList = this.imgQueue;
            this.lstQueue.TabIndex = 1;
            this.lstQueue.UseCompatibleStateImageBehavior = false;
            this.lstQueue.View = System.Windows.Forms.View.Tile;
            // 
            // imgQueue
            // 
            this.imgQueue.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgQueue.ImageSize = new System.Drawing.Size(64, 64);
            this.imgQueue.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grpQueue
            // 
            this.grpQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQueue.Controls.Add(this.btnSelFiles);
            this.grpQueue.Controls.Add(this.lstQueue);
            this.grpQueue.Controls.Add(this.btnSelFolder);
            this.grpQueue.Location = new System.Drawing.Point(12, 12);
            this.grpQueue.Name = "grpQueue";
            this.grpQueue.Size = new System.Drawing.Size(650, 258);
            this.grpQueue.TabIndex = 0;
            this.grpQueue.TabStop = false;
            this.grpQueue.Text = "&Images to resize";
            // 
            // diaSelFiles
            // 
            this.diaSelFiles.Multiselect = true;
            // 
            // diaSelFolder
            // 
            this.diaSelFolder.ShowNewFolderButton = false;
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.txtJpegQty);
            this.grpSettings.Controls.Add(this.txtHeight);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.txtWidth);
            this.grpSettings.Location = new System.Drawing.Point(12, 276);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(650, 81);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "&Resize settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&JPEG image quality:";
            // 
            // txtJpegQty
            // 
            this.txtJpegQty.Location = new System.Drawing.Point(271, 47);
            this.txtJpegQty.Name = "txtJpegQty";
            this.txtJpegQty.Size = new System.Drawing.Size(86, 20);
            this.txtJpegQty.TabIndex = 4;
            this.txtJpegQty.Text = "80";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(138, 47);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(87, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "1800";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max image &height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max image &width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(9, 47);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(87, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "1800";
            // 
            // grpSave
            // 
            this.grpSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSave.Controls.Add(this.txtSaveDest);
            this.grpSave.Controls.Add(this.label1);
            this.grpSave.Controls.Add(this.btnSaveDest);
            this.grpSave.Location = new System.Drawing.Point(12, 363);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(650, 74);
            this.grpSave.TabIndex = 5;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "&Save resized images";
            // 
            // txtSaveDest
            // 
            this.txtSaveDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveDest.Location = new System.Drawing.Point(9, 42);
            this.txtSaveDest.Name = "txtSaveDest";
            this.txtSaveDest.Size = new System.Drawing.Size(499, 20);
            this.txtSaveDest.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resized images will be saved in this folder:";
            // 
            // btnSaveDest
            // 
            this.btnSaveDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDest.Location = new System.Drawing.Point(514, 39);
            this.btnSaveDest.Name = "btnSaveDest";
            this.btnSaveDest.Size = new System.Drawing.Size(130, 24);
            this.btnSaveDest.TabIndex = 8;
            this.btnSaveDest.Text = "S&elect folder...";
            this.btnSaveDest.UseVisualStyleBackColor = true;
            this.btnSaveDest.Click += new System.EventHandler(this.btnSaveDest_Click);
            // 
            // btnBeginResize
            // 
            this.btnBeginResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginResize.Location = new System.Drawing.Point(526, 467);
            this.btnBeginResize.Name = "btnBeginResize";
            this.btnBeginResize.Size = new System.Drawing.Size(136, 34);
            this.btnBeginResize.TabIndex = 9;
            this.btnBeginResize.Text = "&Begin resize";
            this.btnBeginResize.UseVisualStyleBackColor = true;
            this.btnBeginResize.Click += new System.EventHandler(this.btnBeginResize_Click);
            // 
            // timThumbnails
            // 
            this.timThumbnails.Tick += new System.EventHandler(this.timThumbnails_Tick);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(12, 477);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(95, 24);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "&About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 513);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBeginResize);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpQueue);
            this.MinimumSize = new System.Drawing.Size(483, 393);
            this.Name = "frmMain";
            this.Text = "Resiz-o-Tron 5000";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.grpQueue.ResumeLayout(false);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Button btnSelFiles;
        private System.Windows.Forms.ListView lstQueue;
        private System.Windows.Forms.GroupBox grpQueue;
        private System.Windows.Forms.OpenFileDialog diaSelFiles;
        private System.Windows.Forms.FolderBrowserDialog diaSaveDest;
        private System.Windows.Forms.FolderBrowserDialog diaSelFolder;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.Button btnSaveDest;
        private System.Windows.Forms.TextBox txtSaveDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBeginResize;
        private System.Windows.Forms.ImageList imgQueue;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJpegQty;
        private System.Windows.Forms.Timer timThumbnails;
        private System.Windows.Forms.Button btnAbout;
    }
}

