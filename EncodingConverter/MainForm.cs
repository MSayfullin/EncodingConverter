using System;
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

        public MainForm()
        {
            InitializeComponent();

            _encodingsComboBox.DataSource = EncodingManager.Encodings;
            _encodingsComboBox.SelectedItem = Encoding.UTF8;

            _fileManager = new FileManager(
                sourcePath: new TextBoxWrapper(_sourceFolderPath),
                destinationPath: new TextBoxWrapper(_destinationFolderPath));

            _encodingManager = new EncodingManager(_fileManager);
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

                _itemsTable.SuspendLayout();
                _itemsTable.Controls.Clear();
                _itemsTable.RowStyles.Clear();
                _itemsTable.ResumeLayout(true);

                int i = 0;
                var to = (Encoding)_encodingsComboBox.SelectedItem;
                foreach (var fileData in _fileManager.GetFilePaths().OrderBySettings())
                {
                    var control = new FileItemControl(_encodingManager) { Dock = DockStyle.Fill };
                    control.Resolve(fileData, to);
                    _itemsTable.SuspendLayout();
                    _itemsTable.Controls.Add(control, 1, i++);
                    _itemsTable.ResumeLayout(true);
                    Application.DoEvents();
                }
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
    }
}
