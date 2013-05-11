using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using dokas.EncodingConverter.Exceptions;
using dokas.FluentStrings;

namespace dokas.EncodingConverter
{
    internal partial class AboutBox : Form
    {
        private readonly Dictionary<Type, object> _attributes;

        public AboutBox()
        {
            InitializeComponent();

            _attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(false).ToDictionary(a => a.GetType());

            this.Text = "About " + AssemblyTitle;
            _productNameLabel.Text = AssemblyProduct;
            _versionLabel.Text = "Version " + AssemblyVersion;
            _copyrightLabel.Text = AssemblyCopyright;
            _descriptionLabel.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        private T Get<T>()
        {
            object attribute;
            _attributes.TryGetValue(typeof(T), out attribute);
            return (T)attribute;
        }

        public string AssemblyTitle
        {
            get
            {
                var attribute = Get<AssemblyTitleAttribute>();
                if (!attribute.Title.IsEmpty().OrWhiteSpace())
                {
                    return attribute.Title;
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                var attribute = Get<AssemblyDescriptionAttribute>();
                return attribute != null ? attribute.Description : String.Empty;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attribute = Get<AssemblyProductAttribute>();
                return attribute != null ? attribute.Product : String.Empty;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                var attribute = Get<AssemblyCopyrightAttribute>();
                return attribute != null ? attribute.Copyright : String.Empty;
            }
        }

        #endregion

        #region Event Handlers

        private void _charDetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process.Start("http://code.google.com/p/chardetsharp/");
                }
                catch (Win32Exception ex)
                {
                    throw new RecoverableException(
                        "CharDetSharp project website cannot be opened. Something is wrong with environment: " + ex.Message, ex);
                }
            }
        }

        private void _charDetLicenseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process.Start("http://www.mozilla.org/MPL/");
                }
                catch (Win32Exception ex)
                {
                    throw new RecoverableException(
                        "Mozilla Public License website cannot be opened. Something is wrong with environment: " + ex.Message, ex);
                }
            }
        }

        #endregion
    }
}
