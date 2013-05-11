namespace dokas.EncodingConverter
{
    partial class SettingsEditor
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
            this._orderByGroup = new System.Windows.Forms.GroupBox();
            this._byPathRadio = new System.Windows.Forms.RadioButton();
            this._byTypeRadio = new System.Windows.Forms.RadioButton();
            this._byNameRadio = new System.Windows.Forms.RadioButton();
            this._fileTypeFilters = new System.Windows.Forms.GroupBox();
            this._xmlBasedFilter = new System.Windows.Forms.TextBox();
            this._htmlBasedFilterLabel = new System.Windows.Forms.Label();
            this._htmlBasedFilter = new System.Windows.Forms.TextBox();
            this._xmlBasedFilterLabel = new System.Windows.Forms.Label();
            this._textBasedFilter = new System.Windows.Forms.TextBox();
            this._textBasedFilterLabel = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._applyButton = new System.Windows.Forms.Button();
            this._orderByGroup.SuspendLayout();
            this._fileTypeFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // _orderByGroup
            // 
            this._orderByGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderByGroup.Controls.Add(this._byPathRadio);
            this._orderByGroup.Controls.Add(this._byTypeRadio);
            this._orderByGroup.Controls.Add(this._byNameRadio);
            this._orderByGroup.Location = new System.Drawing.Point(13, 13);
            this._orderByGroup.Name = "_orderByGroup";
            this._orderByGroup.Size = new System.Drawing.Size(407, 47);
            this._orderByGroup.TabIndex = 0;
            this._orderByGroup.TabStop = false;
            this._orderByGroup.Text = "Order By...";
            // 
            // _byPathRadio
            // 
            this._byPathRadio.AutoSize = true;
            this._byPathRadio.Location = new System.Drawing.Point(121, 20);
            this._byPathRadio.Name = "_byPathRadio";
            this._byPathRadio.Size = new System.Drawing.Size(47, 17);
            this._byPathRadio.TabIndex = 2;
            this._byPathRadio.TabStop = true;
            this._byPathRadio.Text = "Path";
            this._byPathRadio.UseVisualStyleBackColor = true;
            // 
            // _byTypeRadio
            // 
            this._byTypeRadio.AutoSize = true;
            this._byTypeRadio.Location = new System.Drawing.Point(66, 20);
            this._byTypeRadio.Name = "_byTypeRadio";
            this._byTypeRadio.Size = new System.Drawing.Size(49, 17);
            this._byTypeRadio.TabIndex = 1;
            this._byTypeRadio.TabStop = true;
            this._byTypeRadio.Text = "Type";
            this._byTypeRadio.UseVisualStyleBackColor = true;
            // 
            // _byNameRadio
            // 
            this._byNameRadio.AutoSize = true;
            this._byNameRadio.Location = new System.Drawing.Point(7, 20);
            this._byNameRadio.Name = "_byNameRadio";
            this._byNameRadio.Size = new System.Drawing.Size(53, 17);
            this._byNameRadio.TabIndex = 0;
            this._byNameRadio.TabStop = true;
            this._byNameRadio.Text = "Name";
            this._byNameRadio.UseVisualStyleBackColor = true;
            // 
            // _fileTypeFilters
            // 
            this._fileTypeFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileTypeFilters.Controls.Add(this._xmlBasedFilter);
            this._fileTypeFilters.Controls.Add(this._htmlBasedFilterLabel);
            this._fileTypeFilters.Controls.Add(this._htmlBasedFilter);
            this._fileTypeFilters.Controls.Add(this._xmlBasedFilterLabel);
            this._fileTypeFilters.Controls.Add(this._textBasedFilter);
            this._fileTypeFilters.Controls.Add(this._textBasedFilterLabel);
            this._fileTypeFilters.Location = new System.Drawing.Point(13, 67);
            this._fileTypeFilters.Name = "_fileTypeFilters";
            this._fileTypeFilters.Size = new System.Drawing.Size(407, 100);
            this._fileTypeFilters.TabIndex = 1;
            this._fileTypeFilters.TabStop = false;
            this._fileTypeFilters.Text = "File Type Filters";
            // 
            // _xmlBasedFilter
            // 
            this._xmlBasedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._xmlBasedFilter.Location = new System.Drawing.Point(77, 43);
            this._xmlBasedFilter.Name = "_xmlBasedFilter";
            this._xmlBasedFilter.Size = new System.Drawing.Size(324, 20);
            this._xmlBasedFilter.TabIndex = 4;
            // 
            // _htmlBasedFilterLabel
            // 
            this._htmlBasedFilterLabel.AutoSize = true;
            this._htmlBasedFilterLabel.Location = new System.Drawing.Point(7, 72);
            this._htmlBasedFilterLabel.Name = "_htmlBasedFilterLabel";
            this._htmlBasedFilterLabel.Size = new System.Drawing.Size(64, 13);
            this._htmlBasedFilterLabel.TabIndex = 6;
            this._htmlBasedFilterLabel.Text = "Html Based:";
            // 
            // _htmlBasedFilter
            // 
            this._htmlBasedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._htmlBasedFilter.Location = new System.Drawing.Point(77, 69);
            this._htmlBasedFilter.Name = "_htmlBasedFilter";
            this._htmlBasedFilter.Size = new System.Drawing.Size(324, 20);
            this._htmlBasedFilter.TabIndex = 5;
            // 
            // _xmlBasedFilterLabel
            // 
            this._xmlBasedFilterLabel.AutoSize = true;
            this._xmlBasedFilterLabel.Location = new System.Drawing.Point(11, 46);
            this._xmlBasedFilterLabel.Name = "_xmlBasedFilterLabel";
            this._xmlBasedFilterLabel.Size = new System.Drawing.Size(60, 13);
            this._xmlBasedFilterLabel.TabIndex = 4;
            this._xmlBasedFilterLabel.Text = "Xml Based:";
            // 
            // _textBasedFilter
            // 
            this._textBasedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBasedFilter.Location = new System.Drawing.Point(77, 17);
            this._textBasedFilter.Name = "_textBasedFilter";
            this._textBasedFilter.Size = new System.Drawing.Size(324, 20);
            this._textBasedFilter.TabIndex = 3;
            // 
            // _textBasedFilterLabel
            // 
            this._textBasedFilterLabel.AutoSize = true;
            this._textBasedFilterLabel.Location = new System.Drawing.Point(7, 20);
            this._textBasedFilterLabel.Name = "_textBasedFilterLabel";
            this._textBasedFilterLabel.Size = new System.Drawing.Size(64, 13);
            this._textBasedFilterLabel.TabIndex = 0;
            this._textBasedFilterLabel.Text = "Text Based:";
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(344, 181);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 7;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _applyButton
            // 
            this._applyButton.Location = new System.Drawing.Point(263, 181);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(75, 23);
            this._applyButton.TabIndex = 6;
            this._applyButton.Text = "Apply";
            this._applyButton.UseVisualStyleBackColor = true;
            this._applyButton.Click += new System.EventHandler(this._applyButton_Click);
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(432, 216);
            this.Controls.Add(this._applyButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._fileTypeFilters);
            this.Controls.Add(this._orderByGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 255);
            this.Name = "SettingsEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            this._orderByGroup.ResumeLayout(false);
            this._orderByGroup.PerformLayout();
            this._fileTypeFilters.ResumeLayout(false);
            this._fileTypeFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _orderByGroup;
        private System.Windows.Forms.RadioButton _byPathRadio;
        private System.Windows.Forms.RadioButton _byTypeRadio;
        private System.Windows.Forms.RadioButton _byNameRadio;
        private System.Windows.Forms.GroupBox _fileTypeFilters;
        private System.Windows.Forms.TextBox _textBasedFilter;
        private System.Windows.Forms.Label _textBasedFilterLabel;
        private System.Windows.Forms.TextBox _xmlBasedFilter;
        private System.Windows.Forms.Label _htmlBasedFilterLabel;
        private System.Windows.Forms.TextBox _htmlBasedFilter;
        private System.Windows.Forms.Label _xmlBasedFilterLabel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _applyButton;
    }
}