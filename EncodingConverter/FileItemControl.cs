using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dokas.EncodingConverter.Exceptions;
using dokas.EncodingConverter.Logic;

namespace dokas.EncodingConverter
{
    internal partial class FileItemControl : UserControl
    {
        #region Consts
        private const string Undefined = "Undefined";

        private const string Exclude = "Exclude";
        private const string Include = "Include";

        #endregion

        private FileData _fileData;
        private Encoding _encodingFrom;
        private Encoding _encodingTo;
        private readonly EncodingManager _encodingManager;
        private readonly EncodingSelector _encodingSelector;

        public FileItemControl(EncodingManager encodingManager, EncodingSelector encodingSelector)
        {
            InitializeComponent();

            _excludeButton.Text = Exclude;

            _encodingManager = encodingManager;
            _encodingSelector = encodingSelector;
        }

        public bool IsConvertable
        {
            get { return _encodingFrom != null && _encodingTo != null; }
        }

        public async void Resolve(FileData fileData, Encoding to)
        {
            if (fileData == null)
            {
                throw new ArgumentNullException("fileData");
            }
            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            _fileData = fileData;
            _encodingTo = to;

            _fileNameLink.Text = fileData.Name;
            _toLink.Text = _encodingTo.EncodingName;

            _encodingFrom = await _encodingManager.Resolve(fileData.Path);
            _fromLink.Text = _encodingFrom != null ? _encodingFrom.EncodingName : Undefined;
            if (this.IsConvertable)
            {
                _convertButton.Enabled = true;
            }
            else
            {
                _convertButton.Enabled = false;

                // do not blink on load
                _errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                SetEncodingsError();
                _errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            }
        }

        public bool Convert()
        {
            if (this.IsConvertable && _excludeModeOff)
            {
                _encodingManager.Convert(_fileData.Path, _encodingFrom, _encodingTo);

                // setting just this.Enabled = false will disable control itself
                // preventing scrol from working with wheel
                foreach (var control in this.Controls.OfType<Control>())
                {
                    control.Enabled = false;
                }
                // it is NOT consistent now
                // and will prevent from erroneous double converting also
                _encodingFrom = null;
                return true;
            }
            return false;
        }


        #region Event Handlers

        private void _convertButton_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private bool _excludeModeOff = true;
        private void _excludeButton_Click(object sender, EventArgs e)
        {
            _excludeModeOff = !_excludeModeOff;

            foreach (var control in this.Controls.OfType<Control>().Where(c => c != _excludeButton))
            {
                control.Enabled = _excludeModeOff;
            }
            _excludeButton.Text = _excludeModeOff ? Exclude : Include;

            if (this.IsConvertable)
            {
                _convertButton.Enabled = _excludeModeOff;
            }
            else
            {
                _convertButton.Enabled = false;

                if (_excludeModeOff)
                {
                    SetEncodingsError();
                }
                else
                {
                    _errorProvider.Clear();
                }
            }
        }

        private void _fileNameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenFileInAssignedApp();
            }
        }

        private void _fromLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HandleEncodingLinkClick(e, _fromLink, ref _encodingFrom);
        }

        private void _toLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HandleEncodingLinkClick(e, _toLink, ref _encodingTo);
        }

        #endregion

        #region Helpers

        private void SetEncodingsError()
        {
            _errorProvider.SetError(_encodingsPanel, "File cannot be converted until both encodings are defined.");
        }

        private void OpenFileInAssignedApp()
        {
            try
            {
                Process.Start(_fileData.Path);
            }
            catch (FileNotFoundException ex)
            {
                throw new RecoverableException("File was not found.", ex);
            }
            catch (Win32Exception ex)
            {
                throw new RecoverableException("File cannot be opened. Something is wrong with environment: " + ex.Message, ex);
            }
        }

        private void HandleEncodingLinkClick(LinkLabelLinkClickedEventArgs e, LinkLabel link, ref Encoding encoding)
        {
            if (e.Button == MouseButtons.Left)
            {
                _encodingSelector.AdditionalInfo = _fileData.Name;
                _encodingSelector.SelectedEncoding = encoding;
                var result = _encodingSelector.ShowDialog();
                if (result == DialogResult.OK)
                {
                    encoding = _encodingSelector.SelectedEncoding;
                    link.Text = encoding != null ? encoding.EncodingName : Undefined;

                    if (this.IsConvertable)
                    {
                        _convertButton.Enabled = true;
                        _errorProvider.Clear();
                    }
                    else
                    {
                        _convertButton.Enabled = false;
                        SetEncodingsError();
                    }
                }
            }
        }

        #endregion
    }
}
