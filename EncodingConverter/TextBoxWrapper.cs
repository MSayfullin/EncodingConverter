using System;
using System.Windows.Forms;
using dokas.EncodingConverter.Logic;

namespace dokas.EncodingConverter
{
    internal class TextBoxWrapper : ITextWrapper
    {
        private readonly TextBox _sourceTextBox;

        public TextBoxWrapper(TextBox sourceTextBox)
        {
            if (sourceTextBox == null)
            {
                throw new ArgumentNullException("sourceTextBox");
            }
            _sourceTextBox = sourceTextBox;
        }

        public string Value
        {
            get { return _sourceTextBox.Text; }
            set { _sourceTextBox.Text = value; }
        }
    }
}
