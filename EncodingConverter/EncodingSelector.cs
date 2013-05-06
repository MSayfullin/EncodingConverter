using System;
using System.Text;
using System.Windows.Forms;

namespace dokas.Encoder
{
    internal partial class EncodingSelector : Form
    {
        public EncodingSelector()
        {
            InitializeComponent();

            _encodingsComboBox.DataSource = EncodingManager.Encodings;
        }

        internal Encoding SelectedEncoding
        {
            get { return (Encoding)_encodingsComboBox.SelectedItem; }
            set { _encodingsComboBox.SelectedItem = value; }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
