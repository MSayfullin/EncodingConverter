using System;
using System.Windows.Forms;

namespace dokas.Encoder
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
