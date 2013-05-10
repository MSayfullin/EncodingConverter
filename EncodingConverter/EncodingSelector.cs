using System;
using System.Text;
using System.Windows.Forms;
using dokas.EncodingConverter.Logic;

namespace dokas.EncodingConverter
{
    internal partial class EncodingSelector : Form
    {
        public EncodingSelector()
        {
            InitializeComponent();

            _encodingsComboBox.DataSource = EncodingManager.Encodings;
        }

        public string AdditionalInfo
        {
            set { _additionalInfo.Text = value; }
        }

        public Encoding SelectedEncoding
        {
            get { return (Encoding)_encodingsComboBox.SelectedItem; }
            set { _encodingsComboBox.SelectedItem = value; }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
