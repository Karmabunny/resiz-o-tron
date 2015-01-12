using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


namespace ReallyEasyResize
{
    class Resizer
    {
        protected frmProgress progressForm;
        public List<string> srcPaths;
        public string destDir;
        public int desiredWidth;
        public int desiredHeight;
        public long jpegQty;


        /**
         * Constructor
         */
        public Resizer(frmProgress progressForm)
        {
            this.progressForm = progressForm;
            this.srcPaths = new List<string>();
        }


        /**
         * Resize all the images in the list
         */
        public void run()
        {
            foreach (string path in this.srcPaths) {
                createSmallerImage(path);
                GC.Collect();
                System.Threading.Thread.Sleep(100);
                this.progressForm.Invoke(new frmProgress.ProgressDelegate(this.progressForm.Increment));
            }
        }


        /**
         * Do the resize - in it's own method to help GC
         * TODO: Lots of error handling
         */
        private void createSmallerImage(string path)
        {
            ImageFormat fmt = Resizer.formatFromExt(path);
            if (fmt == null) {
                return;
            }

            Bitmap src = new Bitmap(path);

            // Do the resize
            Rectangle size = Resizer.calcDestSize(src, this.desiredWidth, this.desiredHeight);

            // If original is smaller than desired, do nothing
            if (size.Width > src.Width && size.Height > src.Height) {
                size.Width = src.Width;
                size.Height = src.Height;
            }

            Bitmap dest = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(dest);
            g.DrawImage(src, size);

            // Prepare encoder
            ImageCodecInfo enc = this.getEncoder(fmt);
            EncoderParameters encParams = null;

            // Set compression for JPEG images
            if (fmt == ImageFormat.Jpeg) {
                encParams = new EncoderParameters(1);
                encParams.Param[0] = new EncoderParameter(Encoder.Quality, jpegQty);
            }

            dest.Save(destDir + Path.GetFileNameWithoutExtension(path) + Resizer.extFromFormat(fmt), enc, encParams);

            src.Dispose();
            dest.Dispose();
        }


        /**
         * Determine the image format for a given path
         */
        public static ImageFormat formatFromExt(string path)
        {
            switch (Path.GetExtension(path).ToLower()) {
                case ".jpg":
                case ".jpe":
                case ".jpgp":
                case ".jif":
                case ".jfif":
                case ".jfi":
                    return ImageFormat.Jpeg;
                case ".gif":
                    return ImageFormat.Gif;
                case ".png":
                    return ImageFormat.Png;
            }

            // The returned value is used for SAVING only
            // These extensions will be silently converted to other formats
            // This tool is designed for the web, so I'm using web formats
            switch (Path.GetExtension(path).ToLower()) {
                case ".bmp":
                case ".dib":
                case ".ico":
                    return ImageFormat.Png;
                case ".tif":
                case ".tiff":
                    return ImageFormat.Jpeg;

            }

            return null;
        }


        /**
         * Determine the image format for a given path
         */
        public static string extFromFormat(ImageFormat fmt)
        {
            if (fmt == ImageFormat.Jpeg) return ".jpg";
            if (fmt == ImageFormat.Gif) return ".gif";
            if (fmt == ImageFormat.Png) return ".png";
            return null;
        }


        /**
         * Return the encoder class for a given image format
         */
        private ImageCodecInfo getEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs) {
                if (codec.FormatID == format.Guid) {
                    return codec;
                }
            }

            return null;
        }


        /**
         * Calculate the rectange to use for a resize, with correct aspect ratio
         */
        public static Rectangle calcDestSize(Bitmap src, int desiredWidth, int desiredHeight)
        {
            Rectangle size = new Rectangle();

            if (((double)src.Width / (double)desiredWidth) > ((double)src.Height / (double)desiredHeight)) {
                // Width primary
                size.Width = desiredWidth;
                size.Height = (int)Math.Round((double)src.Height * ((double)desiredWidth / (double)src.Width));

            } else {
                // Height primary
                size.Height = desiredHeight;
                size.Width = (int)Math.Round((double)src.Width * ((double)desiredHeight / (double)src.Height));
            }

            return size;
        }
    }
}
