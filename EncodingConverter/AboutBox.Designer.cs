namespace dokas.EncodingConverter
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this._mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this._charDetDecriptionLabel = new System.Windows.Forms.Label();
            this._charDetLicenseLabel = new System.Windows.Forms.LinkLabel();
            this._charDetLabel = new System.Windows.Forms.LinkLabel();
            this._usagesLabel = new System.Windows.Forms.Label();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._logoPicture = new System.Windows.Forms.PictureBox();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._versionLabel = new System.Windows.Forms.Label();
            this._copyrightLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainLayout
            // 
            this._mainLayout.ColumnCount = 2;
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this._mainLayout.Controls.Add(this._charDetDecriptionLabel, 1, 6);
            this._mainLayout.Controls.Add(this._charDetLicenseLabel, 0, 7);
            this._mainLayout.Controls.Add(this._charDetLabel, 0, 5);
            this._mainLayout.Controls.Add(this._usagesLabel, 0, 4);
            this._mainLayout.Controls.Add(this._descriptionLabel, 0, 1);
            this._mainLayout.Controls.Add(this._logoPicture, 0, 0);
            this._mainLayout.Controls.Add(this._productNameLabel, 1, 0);
            this._mainLayout.Controls.Add(this._versionLabel, 1, 2);
            this._mainLayout.Controls.Add(this._copyrightLabel, 1, 3);
            this._mainLayout.Controls.Add(this._okButton, 1, 8);
            this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainLayout.Location = new System.Drawing.Point(9, 9);
            this._mainLayout.Name = "_mainLayout";
            this._mainLayout.RowCount = 10;
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this._mainLayout.Size = new System.Drawing.Size(417, 265);
            this._mainLayout.TabIndex = 0;
            // 
            // _charDetDecriptionLabel
            // 
            this._charDetDecriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._charDetDecriptionLabel.Location = new System.Drawing.Point(143, 147);
            this._charDetDecriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._charDetDecriptionLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._charDetDecriptionLabel.Name = "_charDetDecriptionLabel";
            this._charDetDecriptionLabel.Size = new System.Drawing.Size(271, 14);
            this._charDetDecriptionLabel.TabIndex = 29;
            this._charDetDecriptionLabel.Text = "C# port of the Mozilla CharDet Character Set Detector";
            this._charDetDecriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _charDetLicenseLabel
            // 
            this._charDetLicenseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._charDetLicenseLabel.Location = new System.Drawing.Point(143, 161);
            this._charDetLicenseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._charDetLicenseLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._charDetLicenseLabel.Name = "_charDetLicenseLabel";
            this._charDetLicenseLabel.Size = new System.Drawing.Size(271, 17);
            this._charDetLicenseLabel.TabIndex = 3;
            this._charDetLicenseLabel.TabStop = true;
            this._charDetLicenseLabel.Text = "under Mozilla Public License 1.1";
            this._charDetLicenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._charDetLicenseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._charDetLicenseLabel_LinkClicked);
            // 
            // _charDetLabel
            // 
            this._charDetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._charDetLabel.Location = new System.Drawing.Point(143, 127);
            this._charDetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._charDetLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._charDetLabel.Name = "_charDetLabel";
            this._charDetLabel.Size = new System.Drawing.Size(271, 17);
            this._charDetLabel.TabIndex = 2;
            this._charDetLabel.TabStop = true;
            this._charDetLabel.Text = "CharDetSharp";
            this._charDetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._charDetLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._charDetLabel_LinkClicked);
            // 
            // _usagesLabel
            // 
            this._usagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._usagesLabel.Location = new System.Drawing.Point(143, 107);
            this._usagesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._usagesLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._usagesLabel.Name = "_usagesLabel";
            this._usagesLabel.Size = new System.Drawing.Size(271, 17);
            this._usagesLabel.TabIndex = 26;
            this._usagesLabel.Text = "Third Party Libraries:";
            this._usagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionLabel.Location = new System.Drawing.Point(143, 20);
            this._descriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._descriptionLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(271, 17);
            this._descriptionLabel.TabIndex = 25;
            this._descriptionLabel.Text = "Description";
            this._descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _logoPicture
            // 
            this._logoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("_logoPicture.Image")));
            this._logoPicture.Location = new System.Drawing.Point(3, 3);
            this._logoPicture.Name = "_logoPicture";
            this._mainLayout.SetRowSpan(this._logoPicture, 9);
            this._logoPicture.Size = new System.Drawing.Size(131, 259);
            this._logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._logoPicture.TabIndex = 12;
            this._logoPicture.TabStop = false;
            // 
            // _productNameLabel
            // 
            this._productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productNameLabel.Location = new System.Drawing.Point(143, 0);
            this._productNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._productNameLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Size = new System.Drawing.Size(271, 17);
            this._productNameLabel.TabIndex = 19;
            this._productNameLabel.Text = "Product Name";
            this._productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _versionLabel
            // 
            this._versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._versionLabel.Location = new System.Drawing.Point(143, 40);
            this._versionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._versionLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._versionLabel.Name = "_versionLabel";
            this._versionLabel.Size = new System.Drawing.Size(271, 17);
            this._versionLabel.TabIndex = 0;
            this._versionLabel.Text = "Version";
            this._versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _copyrightLabel
            // 
            this._copyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._copyrightLabel.Location = new System.Drawing.Point(143, 60);
            this._copyrightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this._copyrightLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this._copyrightLabel.Name = "_copyrightLabel";
            this._copyrightLabel.Size = new System.Drawing.Size(271, 17);
            this._copyrightLabel.TabIndex = 21;
            this._copyrightLabel.Text = "Copyright";
            this._copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._okButton.Location = new System.Drawing.Point(339, 239);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "&OK";
            // 
            // AboutBox
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._okButton;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this._mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this._mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainLayout;
        private System.Windows.Forms.PictureBox _logoPicture;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.Label _versionLabel;
        private System.Windows.Forms.Label _copyrightLabel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.Label _usagesLabel;
        private System.Windows.Forms.LinkLabel _charDetLabel;
        private System.Windows.Forms.Label _charDetDecriptionLabel;
        private System.Windows.Forms.LinkLabel _charDetLicenseLabel;
    }
}
