﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dokas.EncodingConverter.Logic;

namespace dokas.EncodingConverter
{
    internal partial class MainForm : Form
    {
        private readonly FileManager _fileManager;
        private readonly EncodingManager _encodingManager;
        private readonly EncodingSelector _encodingSelector;
        private SettingsEditor _settingsEditor;
        private AboutBox _aboutBox;

        public MainForm()
        {
            InitializeComponent();

            _encodingsComboBox.DataSource = EncodingManager.Encodings;
            _encodingsComboBox.SelectedItem = Encoding.UTF8;

            _fileManager = new FileManager(
                sourcePath: new TextBoxWrapper(_sourceFolderPath),
                destinationPath: new TextBoxWrapper(_destinationFolderPath));

            _encodingManager = new EncodingManager(_fileManager);
            _encodingSelector = new EncodingSelector();
        }

        private void ReloadFileItems()
        {
            _itemsTable.SuspendLayout();
            _itemsTable.Controls.Clear();
            _itemsTable.RowStyles.Clear();
            _itemsTable.ResumeLayout(true);

            int i = 0;
            var to = (Encoding)_encodingsComboBox.SelectedItem;
            foreach (var fileData in _fileManager.GetFilePaths().OrderBySettings())
            {
                var control = new FileItemControl(_encodingManager, _encodingSelector) { Dock = DockStyle.Fill };
                control.Resolve(fileData, to);
                _itemsTable.SuspendLayout();
                _itemsTable.Controls.Add(control, 1, i++);
                _itemsTable.ResumeLayout(true);
                Application.DoEvents();
            }
        }

        private void _openSourceFolderDialog_Click(object sender, EventArgs e)
        {
            _openFolder.ShowNewFolderButton = false;
            _openFolder.Description = "Select source folder with files which encodings should be changed";
            _openFolder.SelectedPath = _sourceFolderPath.Text;
            var result = _openFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                _sourceFolderPath.Text = _openFolder.SelectedPath;
                _fileManager.SetDestinationPath();

                ReloadFileItems();
            }
        }

        private void _openDestinationFolderDialog_Click(object sender, EventArgs e)
        {
            _openFolder.ShowNewFolderButton = true;
            _openFolder.Description = "Select destination folder for converted files.";
            _openFolder.SelectedPath = _destinationFolderPath.Text;
            var result = _openFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                _destinationFolderPath.Text = _openFolder.SelectedPath;
            }
        }

        private void _convertAllButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var control in _itemsTable.Controls.OfType<FileItemControl>())
            {
                if (control.Convert())
                {
                    count++;
                }
            }
            MessageBox.Show(count + " files were converted.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Menu

        private void _closeMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _optionsMenuItem_Click(object sender, EventArgs e)
        {
            if (_settingsEditor == null)
            {
                _settingsEditor = new SettingsEditor();
            }
            var result = _settingsEditor.ShowDialog();
            if (result == DialogResult.Yes && _itemsTable.Controls.Count > 0)
            {
                ReloadFileItems();
            }
        }

        private void _aboutMenuItem_Click(object sender, EventArgs e)
        {
            if (_aboutBox == null)
            {
                _aboutBox = new AboutBox();
            }
            _aboutBox.ShowDialog();
        }

        #endregion
    }
}
