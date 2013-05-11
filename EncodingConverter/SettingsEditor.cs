using System;
using System.Windows.Forms;
using dokas.EncodingConverter.Logic;

namespace dokas.EncodingConverter
{
    internal partial class SettingsEditor : Form
    {
        public SettingsEditor()
        {
            InitializeComponent();
        }

        private void SettingsEditor_Load(object sender, EventArgs e)
        {
            OrderBy = SettingsProvider.OrderBy;
            _textBasedFilter.Text = SettingsProvider.TextBasedExtensions;
            _xmlBasedFilter.Text = SettingsProvider.XmlBasedExtensions;
            _htmlBasedFilter.Text = SettingsProvider.HtmlBasedExtensions;
        }

        private void _applyButton_Click(object sender, EventArgs e)
        {
            if (SettingsChanged)
            {
                SettingsProvider.OrderBy = this.OrderBy;
                SettingsProvider.TextBasedExtensions = _textBasedFilter.Text;
                SettingsProvider.XmlBasedExtensions = _xmlBasedFilter.Text;
                SettingsProvider.HtmlBasedExtensions = _htmlBasedFilter.Text;

                SettingsProvider.Save();

                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
            this.Close();
        }

        #region Helpers

        private OrderBy OrderBy
        {
            get
            {
                if (_byNameRadio.Checked)
                {
                    return OrderBy.Name;
                }
                else if (_byTypeRadio.Checked)
                {
                    return OrderBy.Type;
                }
                else if (_byPathRadio.Checked)
                {
                    return OrderBy.Path;
                }
                else
                {
                    throw new NotImplementedException("It seems that newly added File Type checkbox is not supported everywhere.");
                }
            }
            set
            {
                switch (value)
                {
                    case OrderBy.Name:
                        _byNameRadio.Checked = true;
                        break;
                    case OrderBy.Type:
                        _byTypeRadio.Checked = true;
                        break;
                    case OrderBy.Path:
                        _byPathRadio.Checked = true;
                        break;
                    default:
                        throw new NotImplementedException("It seems that newly added File Type is not supported everywhere.");
                }
            }
        }

        private bool SettingsChanged
        {
            get
            {
                return
                    OrderBy != SettingsProvider.OrderBy
                    || _textBasedFilter.Text != SettingsProvider.TextBasedExtensions
                    || _xmlBasedFilter.Text != SettingsProvider.XmlBasedExtensions
                    || _htmlBasedFilter.Text != SettingsProvider.HtmlBasedExtensions;
            }
        }

        #endregion
    }
}
