using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
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
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = "Version " + AssemblyVersion;
            this.labelCopyright.Text = AssemblyCopyright;
            this.textBoxDescription.Text = AssemblyDescription;
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
    }
}
