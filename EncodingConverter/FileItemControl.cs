using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dokas.EncodingConverter.Logic;
using dokas.FluentStrings;

namespace dokas.EncodingConverter
{
    internal partial class FileItemControl : UserControl
    {
        private const string Exclude = "Exclude";
        private const string Include = "Include";

        private string _filePath;
        private Encoding _encodingFrom;
        private Encoding _encodingTo;
        private readonly EncodingManager _encodingManager;

        public FileItemControl(EncodingManager encodingManager)
        {
            InitializeComponent();

            _excludeButton.Text = Exclude;

            _encodingManager = encodingManager;
        }

        public void LoadData(string filePath, Encoding from, Encoding to)
        {
            _filePath = filePath;
            _encodingFrom = from;
            _encodingTo = to;

            _fileNameLink.Text = Path.GetFileName(filePath).TruncateTo(73).WithEllipsis();
            _fromLink.Text = from != null ? from.EncodingName : String.Empty;
            _toLink.Text = to.EncodingName;
        }

        private void _convertButton_Click(object sender, EventArgs e)
        {
            _encodingManager.Convert(_filePath, _encodingFrom, _encodingTo);
            this.Enabled = false;
        }

        private bool _excludeMode = true;
        private void _excludeButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls.OfType<Control>().Where(c => c != _excludeButton))
            {
                control.Enabled = !_excludeMode;
            }
            _excludeButton.Text = _excludeMode ? Include : Exclude;
            _excludeMode = !_excludeMode;
        }

        private void _fileNameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Process.Start(_filePath);
            }
        }

        private readonly EncodingSelector _encodingSelector = new EncodingSelector();

        private void _fromLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HandleEncodingLinkClick(e, _fromLink, ref _encodingFrom);
        }

        private void _toLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HandleEncodingLinkClick(e, _toLink, ref _encodingTo);
        }

        private void HandleEncodingLinkClick(LinkLabelLinkClickedEventArgs e, LinkLabel link, ref Encoding encoding)
        {
            if (e.Button == MouseButtons.Left)
            {
                _encodingSelector.SelectedEncoding = encoding;
                var result = _encodingSelector.ShowDialog();
                if (result == DialogResult.OK)
                {
                    encoding = _encodingSelector.SelectedEncoding;
                    link.Text = encoding.EncodingName;
                }
            }
        }
    }
}
