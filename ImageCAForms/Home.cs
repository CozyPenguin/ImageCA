using ImageCA.Colors;
using ImageCA.Logging;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageCA.Forms
{
    public partial class Home : Form
    {

        //indicates if the image is loaded
        private bool imageLoaded;

        public Home()
        {
            InitializeComponent();

            Logger.Log("Initialized Logger", LogLevel.Debug);
        }

        // Image() loads an image
        private void Load_Image(object sender, EventArgs e)
        {
            Logger.Log("calling image load method", LogLevel.Debug);
            {
                try { Image(); }
                catch (Exception ex)
                {
                    Logger.Log(ex.ToString(), LogLevel.Error);
                }
            }
        }

        //TODO: reload program instead of restarting
        //Restart Program
        private void ReloadStart_Click(object sender, EventArgs e)
        {
            Logger.EndLog("Application restarting");
            Application.Restart(); // restarts application, currently resulting in stop of the Log
        }

        private void Home_Load(object sender, EventArgs e) { }

        #region Color_Extraction

        private void Cmd_ExtractColors_Click(object sender, EventArgs e)
        {
            Logger.Log("Color extraction started", LogLevel.Debug);

            if (imageLoaded == true) // there has to be a loaded image to extract the colours
            {
                Logger.Log("Image loaded, proceeding", LogLevel.Debug);

                Bitmap probe = new Bitmap(imageBox.Image); // a copy of the loaded image

                int x, y = 0; // the x-value and the y-value the colour will be extracted from

                //simplified way, uses the pixel in the middle of the image
                x = probe.Width / 2;
                y = probe.Height / 2;

                Color inputPixel = probe.GetPixel(x, y);  // get pixel from image middle

                Logger.Log("x is equal to: " + x, LogLevel.Debug);
                Logger.Log("y is equal to: " + y, LogLevel.Debug);
                Logger.Log("Color: " + inputPixel.ToString(), LogLevel.Debug);

                DisplayRGB(inputPixel.R, inputPixel.G, inputPixel.B);
                colorDisplay.BackColor = inputPixel;
            }
            else
            {
                // create and open message box to signalize missing image
                MessageBoxButtons noImage = MessageBoxButtons.OK;
                MessageBox.Show("Please open an image first! (Strg + O)", "No Image", noImage);

                Logger.Log("Colour extraction aborted because no image was loaded. Image() will be called", LogLevel.Warn);
                Image();
            }
        }

        #endregion

        #region Color_Display

        private void DisplayRGB(byte R, byte G, byte B)
        {
            nud_rColor.Value = R;
            nud_gColor.Value = G;
            nud_bColor.Value = B;
        }

        #endregion

        #region Color_Conversion

        private void Cmd_ConvertColors_Click(object sender, EventArgs e)
        {
            ColorHSV hsv = ColConverter.ToHSV(new ColorRGB((byte)nud_rColor.Value, (byte)nud_gColor.Value, (byte)nud_bColor.Value));
            nud_hColor.Value = (decimal)hsv.H;
            nud_sColor.Value = (decimal)hsv.S;
            nud_vColor.Value = (decimal)hsv.V;
        }

        #endregion

        //open an image and load it into the image box
        private void Image()
        {
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {
                imageBox.ImageLocation = OpenImageDialog.FileName;
                imageLoaded = true;
            }
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.EndLog(e.CloseReason.ToString()); //stops the Logger
        }

        private void Nud_rColor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_gColor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_bColor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_hColor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_sColor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_vColor_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
