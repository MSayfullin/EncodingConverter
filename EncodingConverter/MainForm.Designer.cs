namespace dokas.EncodingConverter
{
    partial class MainForm
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
            this._openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this._sourceFolderPath = new System.Windows.Forms.TextBox();
            this._openSourceFolderDialog = new System.Windows.Forms.Button();
            this._openDestinationFolderDialog = new System.Windows.Forms.Button();
            this._mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sourceFolderLabel = new System.Windows.Forms.Label();
            this._destinationFolderLabel = new System.Windows.Forms.Label();
            this._destinationFolderPath = new System.Windows.Forms.TextBox();
            this._outputEncodingLabel = new System.Windows.Forms.Label();
            this._encodingsComboBox = new System.Windows.Forms.ComboBox();
            this._itemsTable = new System.Windows.Forms.TableLayoutPanel();
            this._convertAllButton = new System.Windows.Forms.Button();
            this._mainLayout.SuspendLayout();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _openFolder
            // 
            this._openFolder.ShowNewFolderButton = false;
            // 
            // _sourceFolderPath
            // 
            this._sourceFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._sourceFolderPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._sourceFolderPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this._mainLayout.SetColumnSpan(this._sourceFolderPath, 2);
            this._sourceFolderPath.Location = new System.Drawing.Point(107, 33);
            this._sourceFolderPath.Name = "_sourceFolderPath";
            this._sourceFolderPath.Size = new System.Drawing.Size(432, 20);
            this._sourceFolderPath.TabIndex = 1;
            // 
            // _openSourceFolderDialog
            // 
            this._openSourceFolderDialog.Location = new System.Drawing.Point(545, 33);
            this._openSourceFolderDialog.Name = "_openSourceFolderDialog";
            this._openSourceFolderDialog.Size = new System.Drawing.Size(30, 20);
            this._openSourceFolderDialog.TabIndex = 2;
            this._openSourceFolderDialog.Text = "...";
            this._openSourceFolderDialog.UseVisualStyleBackColor = true;
            this._openSourceFolderDialog.Click += new System.EventHandler(this._openSourceFolderDialog_Click);
            // 
            // _openDestinationFolderDialog
            // 
            this._openDestinationFolderDialog.Location = new System.Drawing.Point(545, 59);
            this._openDestinationFolderDialog.Name = "_openDestinationFolderDialog";
            this._openDestinationFolderDialog.Size = new System.Drawing.Size(30, 20);
            this._openDestinationFolderDialog.TabIndex = 4;
            this._openDestinationFolderDialog.Text = "...";
            this._openDestinationFolderDialog.UseVisualStyleBackColor = true;
            this._openDestinationFolderDialog.Click += new System.EventHandler(this._openDestinationFolderDialog_Click);
            // 
            // _mainLayout
            // 
            this._mainLayout.ColumnCount = 4;
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this._mainLayout.Controls.Add(this._menu, 0, 0);
            this._mainLayout.Controls.Add(this._sourceFolderLabel, 0, 1);
            this._mainLayout.Controls.Add(this._sourceFolderPath, 1, 1);
            this._mainLayout.Controls.Add(this._openSourceFolderDialog, 3, 1);
            this._mainLayout.Controls.Add(this._destinationFolderLabel, 0, 2);
            this._mainLayout.Controls.Add(this._destinationFolderPath, 1, 2);
            this._mainLayout.Controls.Add(this._openDestinationFolderDialog, 3, 2);
            this._mainLayout.Controls.Add(this._outputEncodingLabel, 0, 3);
            this._mainLayout.Controls.Add(this._encodingsComboBox, 1, 3);
            this._mainLayout.Controls.Add(this._itemsTable, 1, 4);
            this._mainLayout.Controls.Add(this._convertAllButton, 2, 3);
            this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainLayout.Location = new System.Drawing.Point(0, 0);
            this._mainLayout.Name = "_mainLayout";
            this._mainLayout.RowCount = 5;
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this._mainLayout.Size = new System.Drawing.Size(584, 661);
            this._mainLayout.TabIndex = 4;
            // 
            // _menu
            // 
            this._mainLayout.SetColumnSpan(this._menu, 4);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenuItem,
            this._aboutMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(584, 24);
            this._menu.TabIndex = 6;
            this._menu.Text = "Menu";
            // 
            // _fileMenuItem
            // 
            this._fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._closeMenuItem});
            this._fileMenuItem.Name = "_fileMenuItem";
            this._fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileMenuItem.Text = "File";
            // 
            // _closeMenuItem
            // 
            this._closeMenuItem.Name = "_closeMenuItem";
            this._closeMenuItem.Size = new System.Drawing.Size(152, 22);
            this._closeMenuItem.Text = "Close";
            this._closeMenuItem.Click += new System.EventHandler(this._closeMenuItem_Click);
            // 
            // _aboutMenuItem
            // 
            this._aboutMenuItem.Name = "_aboutMenuItem";
            this._aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this._aboutMenuItem.Text = "About";
            // 
            // _sourceFolderLabel
            // 
            this._sourceFolderLabel.AutoSize = true;
            this._sourceFolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sourceFolderLabel.Location = new System.Drawing.Point(3, 30);
            this._sourceFolderLabel.Name = "_sourceFolderLabel";
            this._sourceFolderLabel.Size = new System.Drawing.Size(98, 26);
            this._sourceFolderLabel.TabIndex = 4;
            this._sourceFolderLabel.Text = "Source folder:";
            this._sourceFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _destinationFolderLabel
            // 
            this._destinationFolderLabel.AutoSize = true;
            this._destinationFolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._destinationFolderLabel.Location = new System.Drawing.Point(3, 56);
            this._destinationFolderLabel.Name = "_destinationFolderLabel";
            this._destinationFolderLabel.Size = new System.Drawing.Size(98, 26);
            this._destinationFolderLabel.TabIndex = 7;
            this._destinationFolderLabel.Text = "Destination folder:";
            this._destinationFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _destinationFolderPath
            // 
            this._destinationFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._destinationFolderPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._destinationFolderPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this._mainLayout.SetColumnSpan(this._destinationFolderPath, 2);
            this._destinationFolderPath.Location = new System.Drawing.Point(107, 59);
            this._destinationFolderPath.Name = "_destinationFolderPath";
            this._destinationFolderPath.Size = new System.Drawing.Size(432, 20);
            this._destinationFolderPath.TabIndex = 3;
            // 
            // _outputEncodingLabel
            // 
            this._outputEncodingLabel.AutoSize = true;
            this._outputEncodingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._outputEncodingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._outputEncodingLabel.Location = new System.Drawing.Point(3, 82);
            this._outputEncodingLabel.Name = "_outputEncodingLabel";
            this._outputEncodingLabel.Size = new System.Drawing.Size(98, 30);
            this._outputEncodingLabel.TabIndex = 8;
            this._outputEncodingLabel.Text = "Output encoding:";
            this._outputEncodingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _encodingsComboBox
            // 
            this._encodingsComboBox.DisplayMember = "EncodingName";
            this._encodingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._encodingsComboBox.FormattingEnabled = true;
            this._encodingsComboBox.Location = new System.Drawing.Point(107, 85);
            this._encodingsComboBox.Name = "_encodingsComboBox";
            this._encodingsComboBox.Size = new System.Drawing.Size(240, 21);
            this._encodingsComboBox.Sorted = true;
            this._encodingsComboBox.TabIndex = 5;
            // 
            // _itemsTable
            // 
            this._itemsTable.AutoScroll = true;
            this._itemsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._itemsTable.ColumnCount = 1;
            this._mainLayout.SetColumnSpan(this._itemsTable, 4);
            this._itemsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._itemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemsTable.Location = new System.Drawing.Point(0, 124);
            this._itemsTable.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this._itemsTable.Name = "_itemsTable";
            this._itemsTable.Padding = new System.Windows.Forms.Padding(9, 0, 9, 3);
            this._itemsTable.Size = new System.Drawing.Size(584, 537);
            this._itemsTable.TabIndex = 3;
            // 
            // _convertAllButton
            // 
            this._mainLayout.SetColumnSpan(this._convertAllButton, 2);
            this._convertAllButton.Location = new System.Drawing.Point(497, 85);
            this._convertAllButton.Name = "_convertAllButton";
            this._convertAllButton.Size = new System.Drawing.Size(78, 24);
            this._convertAllButton.TabIndex = 6;
            this._convertAllButton.Text = "Convert All";
            this._convertAllButton.UseVisualStyleBackColor = true;
            this._convertAllButton.Click += new System.EventHandler(this._convertAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this._mainLayout);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this._menu;
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "MainForm";
            this.Text = "Encoder";
            this._mainLayout.ResumeLayout(false);
            this._mainLayout.PerformLayout();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog _openFolder;
        private System.Windows.Forms.TextBox _sourceFolderPath;
        private System.Windows.Forms.Button _openSourceFolderDialog;
        private System.Windows.Forms.Button _openDestinationFolderDialog;
        private System.Windows.Forms.TableLayoutPanel _mainLayout;
        private System.Windows.Forms.TableLayoutPanel _itemsTable;
        private System.Windows.Forms.Label _sourceFolderLabel;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem _fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutMenuItem;
        private System.Windows.Forms.Label _destinationFolderLabel;
        private System.Windows.Forms.TextBox _destinationFolderPath;
        private System.Windows.Forms.Label _outputEncodingLabel;
        private System.Windows.Forms.ComboBox _encodingsComboBox;
        private System.Windows.Forms.Button _convertAllButton;
    }
}

