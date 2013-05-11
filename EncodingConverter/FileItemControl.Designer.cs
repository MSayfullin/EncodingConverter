namespace dokas.EncodingConverter
{
    partial class FileItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._fileNameLink = new System.Windows.Forms.LinkLabel();
            this._fromLabel = new System.Windows.Forms.Label();
            this._fromLink = new System.Windows.Forms.LinkLabel();
            this._convertButton = new System.Windows.Forms.Button();
            this._toLabel = new System.Windows.Forms.Label();
            this._toLink = new System.Windows.Forms.LinkLabel();
            this._encodingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._excludeButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._encodingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _fileNameLink
            // 
            this._fileNameLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileNameLink.AutoEllipsis = true;
            this._fileNameLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._fileNameLink.Location = new System.Drawing.Point(3, 3);
            this._fileNameLink.Name = "_fileNameLink";
            this._fileNameLink.Size = new System.Drawing.Size(291, 16);
            this._fileNameLink.TabIndex = 0;
            this._fileNameLink.TabStop = true;
            this._fileNameLink.Text = "FILE_NAME";
            this._fileNameLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._fileNameLink_LinkClicked);
            // 
            // _fromLabel
            // 
            this._fromLabel.Location = new System.Drawing.Point(0, 0);
            this._fromLabel.Margin = new System.Windows.Forms.Padding(0);
            this._fromLabel.Name = "_fromLabel";
            this._fromLabel.Size = new System.Drawing.Size(27, 13);
            this._fromLabel.TabIndex = 1;
            this._fromLabel.Text = "from";
            // 
            // _fromLink
            // 
            this._fromLink.AutoSize = true;
            this._fromLink.Location = new System.Drawing.Point(27, 0);
            this._fromLink.Margin = new System.Windows.Forms.Padding(0);
            this._fromLink.Name = "_fromLink";
            this._fromLink.Size = new System.Drawing.Size(16, 13);
            this._fromLink.TabIndex = 0;
            this._fromLink.TabStop = true;
            this._fromLink.Text = "...";
            this._fromLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._fromLink_LinkClicked);
            // 
            // _convertButton
            // 
            this._convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._convertButton.Location = new System.Drawing.Point(240, 22);
            this._convertButton.Name = "_convertButton";
            this._convertButton.Size = new System.Drawing.Size(54, 23);
            this._convertButton.TabIndex = 4;
            this._convertButton.Text = "Convert";
            this._convertButton.UseVisualStyleBackColor = true;
            this._convertButton.Click += new System.EventHandler(this._convertButton_Click);
            // 
            // _toLabel
            // 
            this._toLabel.Location = new System.Drawing.Point(43, 0);
            this._toLabel.Margin = new System.Windows.Forms.Padding(0);
            this._toLabel.Name = "_toLabel";
            this._toLabel.Size = new System.Drawing.Size(16, 13);
            this._toLabel.TabIndex = 4;
            this._toLabel.Text = "to";
            // 
            // _toLink
            // 
            this._toLink.AutoSize = true;
            this._toLink.Location = new System.Drawing.Point(59, 0);
            this._toLink.Margin = new System.Windows.Forms.Padding(0);
            this._toLink.Name = "_toLink";
            this._toLink.Size = new System.Drawing.Size(16, 13);
            this._toLink.TabIndex = 1;
            this._toLink.TabStop = true;
            this._toLink.Text = "...";
            this._toLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._toLink_LinkClicked);
            // 
            // _encodingsPanel
            // 
            this._encodingsPanel.AutoSize = true;
            this._encodingsPanel.Controls.Add(this._fromLabel);
            this._encodingsPanel.Controls.Add(this._fromLink);
            this._encodingsPanel.Controls.Add(this._toLabel);
            this._encodingsPanel.Controls.Add(this._toLink);
            this._encodingsPanel.Location = new System.Drawing.Point(6, 22);
            this._encodingsPanel.Name = "_encodingsPanel";
            this._encodingsPanel.Size = new System.Drawing.Size(168, 17);
            this._encodingsPanel.TabIndex = 1;
            // 
            // _excludeButton
            // 
            this._excludeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._excludeButton.Location = new System.Drawing.Point(180, 22);
            this._excludeButton.Name = "_excludeButton";
            this._excludeButton.Size = new System.Drawing.Size(54, 23);
            this._excludeButton.TabIndex = 3;
            this._excludeButton.Text = "Exclude";
            this._excludeButton.UseVisualStyleBackColor = true;
            this._excludeButton.Click += new System.EventHandler(this._excludeButton_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // FileItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._excludeButton);
            this.Controls.Add(this._encodingsPanel);
            this.Controls.Add(this._convertButton);
            this.Controls.Add(this._fileNameLink);
            this.Name = "FileItemControl";
            this.Size = new System.Drawing.Size(297, 45);
            this._encodingsPanel.ResumeLayout(false);
            this._encodingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel _fileNameLink;
        private System.Windows.Forms.Label _fromLabel;
        private System.Windows.Forms.LinkLabel _fromLink;
        private System.Windows.Forms.Button _convertButton;
        private System.Windows.Forms.Label _toLabel;
        private System.Windows.Forms.LinkLabel _toLink;
        private System.Windows.Forms.FlowLayoutPanel _encodingsPanel;
        private System.Windows.Forms.Button _excludeButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}
