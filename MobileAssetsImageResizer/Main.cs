using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void BtnCreateAssets_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtImagePath.Text))
            {
                AssetsCreator.Create(txtImagePath.Text);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = "Select Image File";
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg;*.bmp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hassanelsherbiny/AssetsCreator");
        }

        private void Paypal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=33739JHTLBA5W&source=url");
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bitsdevelopments1");
        }

        private void BtnAddToContext_Click(object sender, EventArgs e)
        {
            string KeyPath = @"SOFTWARE\Classes\SystemFileAssociations\image";
            CreateOrOpen(KeyPath);
            KeyPath += @"\shell";
            CreateOrOpen(KeyPath);
            KeyPath += @"\Create Asset";
            var Key = CreateOrOpen(KeyPath);
            Key.SetValue("Icon", $"\"{Application.ExecutablePath}\",0");
            KeyPath += @"\Command";
            Key = CreateOrOpen(KeyPath);
            Key.SetValue("", $"\"{Application.ExecutablePath}\" \"%1\"");

            MessageBox.Show("Application Added To Context Menu Successfully");
        }
         
        RegistryKey CreateOrOpen(string KeyPath)
        {
            var key = Registry.LocalMachine.OpenSubKey(KeyPath, true);
            if (key == null)
            {
                key = Registry.LocalMachine.CreateSubKey(KeyPath);
            }
            return key;
        }
    }
}
