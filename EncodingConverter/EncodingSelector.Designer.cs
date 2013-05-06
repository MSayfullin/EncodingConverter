namespace dokas.EncodingConverter
{
    partial class EncodingSelector
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
            this._selectEncodingPrompt = new System.Windows.Forms.Label();
            this._encodingsComboBox = new System.Windows.Forms.ComboBox();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _selectEncodingPrompt
            // 
            this._selectEncodingPrompt.AutoSize = true;
            this._selectEncodingPrompt.Location = new System.Drawing.Point(13, 13);
            this._selectEncodingPrompt.Name = "_selectEncodingPrompt";
            this._selectEncodingPrompt.Size = new System.Drawing.Size(174, 13);
            this._selectEncodingPrompt.TabIndex = 0;
            this._selectEncodingPrompt.Text = "Select encoding from the list below:";
            // 
            // _encodingsComboBox
            // 
            this._encodingsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._encodingsComboBox.DisplayMember = "EncodingName";
            this._encodingsComboBox.FormattingEnabled = true;
            this._encodingsComboBox.Location = new System.Drawing.Point(13, 30);
            this._encodingsComboBox.Name = "_encodingsComboBox";
            this._encodingsComboBox.Size = new System.Drawing.Size(240, 21);
            this._encodingsComboBox.Sorted = true;
            this._encodingsComboBox.TabIndex = 0;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(201, 56);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(53, 23);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(142, 57);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(53, 23);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // EncodingSelector
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(266, 91);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._encodingsComboBox);
            this.Controls.Add(this._selectEncodingPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncodingSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encoding Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _selectEncodingPrompt;
        private System.Windows.Forms.ComboBox _encodingsComboBox;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
    }
}