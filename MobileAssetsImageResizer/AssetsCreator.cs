using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 This Application Is Created By Bits Developments / Hasan Elsherbiny
 Feel Free To use Any code here but DON'T Forget To Mention The Author
 Support Us On Paypal
 https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=33739JHTLBA5W&source=url
*/
namespace MobileAssetsImageResizer
{
    public static class AssetsCreator
    {
        static Dictionary<string, Size> AndoridSizes = new Dictionary<string, Size>();
        static AssetsCreator()
        {
            AndoridSizes.Add("drawable-hdpi", new Size(480, 800));
            AndoridSizes.Add("drawable-xhdpi", new Size(720, 1280));
            AndoridSizes.Add("drawable-xxhdpi", new Size(960, 1600));
            AndoridSizes.Add("drawable-xxxhdpi", new Size(1280, 1920));
        }
        static void ResizeImage(string imageFile, string outputFile, Size NewSize)
        {
            using (var srcImage = Image.FromFile(imageFile))
            {
                //Check If Image Is Portait Or Landscape
                if (srcImage.Height < srcImage.Width)
                {
                    //Switch The Size to landscape
                    var height = NewSize.Height;
                    NewSize.Height = NewSize.Width;
                    NewSize.Width = height;
                }

                using (var newImage = new Bitmap(NewSize.Width, NewSize.Height))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, new Rectangle(0, 0, NewSize.Width, NewSize.Height));
                    newImage.Save(outputFile);
                }
            }
        }

        public static void Create(string Source)
        {
            string OutPutDir = Source.Replace(Path.GetExtension(Source), "");
            if (!Directory.Exists(OutPutDir))
            {
                Directory.CreateDirectory(OutPutDir);
            }
            foreach (var androidSize in AndoridSizes.Keys)
            {
                var Output = Path.Combine(OutPutDir, androidSize);
                if (!Directory.Exists(Output))
                    Directory.CreateDirectory(Output);
                Output = Path.Combine(Output, Path.GetFileName(Source));
                if (File.Exists(Output))
                {
                    try
                    {
                        File.Delete(Output);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed To Delete File {Output}");
                    }
                }
                try
                {
                    ResizeImage(Source, Output, AndoridSizes[androidSize]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed To Create File {Output}");
                }

            }
            //Copy The Default Image To drawable Folder
            string drawableOutput = Path.Combine(OutPutDir, "drawable");

            if (!Directory.Exists(drawableOutput))
            {
                Directory.CreateDirectory(drawableOutput);
            }
            string defaultDrawableImage = Path.Combine(drawableOutput, Path.GetFileName(Source));
            if (File.Exists(defaultDrawableImage))
                try
                {
                    File.Delete(defaultDrawableImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed To Delete File {defaultDrawableImage}");
                }
            try
            {
                File.Copy(Source, defaultDrawableImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed To Copy File {defaultDrawableImage}");
            }
            //Show In Explorer
            System.Diagnostics.Process.Start(OutPutDir);
            MessageBox.Show("Assests Created Successfully");
        }
    }
}
