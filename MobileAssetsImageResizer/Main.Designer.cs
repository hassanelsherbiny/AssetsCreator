namespace MobileAssetsImageResizer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnCreateAssets = new System.Windows.Forms.Button();
            this.BtnAddToContext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFb = new System.Windows.Forms.PictureBox();
            this.Paypal = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Path";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(15, 166);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(233, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBrowse.Location = new System.Drawing.Point(254, 166);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(35, 20);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnCreateAssets
            // 
            this.BtnCreateAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAssets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreateAssets.Location = new System.Drawing.Point(15, 192);
            this.BtnCreateAssets.Name = "BtnCreateAssets";
            this.BtnCreateAssets.Size = new System.Drawing.Size(111, 20);
            this.BtnCreateAssets.TabIndex = 2;
            this.BtnCreateAssets.Text = "Create Assets";
            this.BtnCreateAssets.UseVisualStyleBackColor = true;
            this.BtnCreateAssets.Click += new System.EventHandler(this.BtnCreateAssets_Click);
            // 
            // BtnAddToContext
            // 
            this.BtnAddToContext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddToContext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddToContext.Location = new System.Drawing.Point(132, 192);
            this.BtnAddToContext.Name = "BtnAddToContext";
            this.BtnAddToContext.Size = new System.Drawing.Size(157, 20);
            this.BtnAddToContext.TabIndex = 2;
            this.BtnAddToContext.Text = "Add To Context Menu";
            this.BtnAddToContext.UseVisualStyleBackColor = true;
            this.BtnAddToContext.Click += new System.EventHandler(this.BtnAddToContext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Support Us On Paypal";
            // 
            // btnFb
            // 
            this.btnFb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFb.Image = global::MobileAssetsImageResizer.Properties.Resources.Facebook_icon1;
            this.btnFb.Location = new System.Drawing.Point(268, 264);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(30, 30);
            this.btnFb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFb.TabIndex = 3;
            this.btnFb.TabStop = false;
            this.btnFb.Click += new System.EventHandler(this.btnFb_Click);
            // 
            // Paypal
            // 
            this.Paypal.BackColor = System.Drawing.Color.Transparent;
            this.Paypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paypal.Image = global::MobileAssetsImageResizer.Properties.Resources.Paypal;
            this.Paypal.Location = new System.Drawing.Point(110, 241);
            this.Paypal.Name = "Paypal";
            this.Paypal.Size = new System.Drawing.Size(152, 54);
            this.Paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paypal.TabIndex = 3;
            this.Paypal.TabStop = false;
            this.Paypal.Click += new System.EventHandler(this.Paypal_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 231);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(103, 66);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MobileAssetsImageResizer.Properties.Resources.extractor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 309);
            this.Controls.Add(this.btnFb);
            this.Controls.Add(this.Paypal);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.BtnAddToContext);
            this.Controls.Add(this.BtnCreateAssets);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Assets Creator By Bits Developments";
            ((System.ComponentModel.ISupportInitialize)(this.btnFb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnCreateAssets;
        private System.Windows.Forms.Button BtnAddToContext;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Paypal;
        private System.Windows.Forms.PictureBox btnFb;
    }
}

