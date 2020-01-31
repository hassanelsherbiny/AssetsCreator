using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
/*
 This Application Is Created By Bits Developments / Hasan Elsherbiny
 Feel Free To use Any code here but DON'T Forget To Mention The Author
 Support Us On Paypal
 https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=33739JHTLBA5W&source=url
*/
namespace MobileAssetsImageResizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Any())
            { 
                //Opend From Windows Context Menu
                AssetsCreator.Create(args[0]);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }

        }
    }
}
