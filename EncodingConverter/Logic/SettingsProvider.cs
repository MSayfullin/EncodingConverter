using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Xml;
using System.Xml.Linq;
using dokas.EncodingConverter.Exceptions;

namespace dokas.EncodingConverter.Logic
{
    internal static class SettingsProvider
    {
        #region Tag Names

        private const string OrderByTag = "orderBy";
        private const string TextBasedExtensionsTag = "textBasedExtensions";
        private const string XmlBasedExtensionsTag = "xmlBasedExtensions";
        private const string HtmlBasedExtensionsTag = "htmlBasedExtensions";

        #endregion

        #region Defaults

        private const string TextBasedDefaultExtensions = "txt";
        private const string XmlBasedDefaultExtensions = "xml, fb2";
        private const string HtmlBasedDefaultExtensions = "htm, html";

        #endregion

        private static readonly Dictionary<string, FileTypes> _fileExtensionsMap = new Dictionary<string, FileTypes>();
        private static readonly IEnumerable<string> _searchPatterns;

        static SettingsProvider()
        {
            LoadSettings();
            PrepareExtensionsMap();
            _searchPatterns = _fileExtensionsMap.Keys.ToSearhPatterns();
        }

        public static OrderByProperties OrderBy { get; set; }

        public static string TextBasedExtensions { get; set; }
        public static string XmlBasedExtensions { get; set; }
        public static string HtmlBasedExtensions { get; set; }

        public static IEnumerable<string> SearchPatterns
        {
            get { return _searchPatterns; }
        }

        public static FileTypes GetFileType(this string path)
        {
            var fileType = FileTypes.Text;
            _fileExtensionsMap.TryGetValue(Path.GetExtension(path), out fileType);
            return fileType;
        }

        public static IEnumerable<FileData> OrderBySettings(this IEnumerable<FileData> fileData)
        {
            switch (OrderBy)
            {
                case OrderByProperties.Path: return fileData.OrderBy(d => d.Path);
                case OrderByProperties.Name: return fileData.OrderBy(d => d.Name);
                case OrderByProperties.Type: return fileData.OrderBy(d => d.Extension);
                default:
                    throw new NotImplementedException("It seems that newly added Order By Property is not supported everywhere.");
            }
        }

        public static void Save()
        {
            try
            {
                var config =
                    new XDocument(
                        new XElement("configuration",
                            new XElement(OrderByTag, OrderBy),
                            new XElement(TextBasedExtensionsTag, TextBasedExtensions),
                            new XElement(XmlBasedExtensionsTag, XmlBasedExtensions),
                            new XElement(HtmlBasedExtensionsTag, HtmlBasedExtensions)));
                config.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new RecoverableException(
                    "Settings cannot be saved." + Environment.NewLine + ex.Message, ex);
            }
            catch (SecurityException ex)
            {
                throw new RecoverableException(
                    "Settings cannot be saved. Check that you have sufficient permissions.", ex);
            }
        }

        #region Helpers

        private static void LoadSettings()
        {
            OrderBy = OrderByProperties.Name;

            TextBasedExtensions = TextBasedDefaultExtensions;
            XmlBasedExtensions = XmlBasedDefaultExtensions;
            HtmlBasedExtensions = HtmlBasedDefaultExtensions;

            try
            {
                var config = XDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                var tag = config.Root.Element(OrderByTag);
                if (tag != null)
                {
                    OrderBy = (OrderByProperties)Enum.Parse(typeof(OrderByProperties), tag.Value.ToString());
                }
                tag = config.Root.Element(TextBasedExtensionsTag);
                if (tag != null)
                {
                    TextBasedExtensions = tag.Value;
                }
                tag = config.Root.Element(XmlBasedExtensionsTag);
                if (tag != null)
                {
                    XmlBasedExtensions = tag.Value;
                }
                tag = config.Root.Element(HtmlBasedExtensionsTag);
                if (tag != null)
                {
                    HtmlBasedExtensions = tag.Value;
                }
            }
            catch (ArgumentNullException)
            {
                // this rather impossible case
                throw;
            }
            catch (ArgumentException)
            {
                // order by enum parsing is failed
                // just use default values instead
            }
            catch (OverflowException)
            {
                // order by enum parsing is failed
                // just use default values instead
            }
            catch (FileNotFoundException)
            {
                // just use default values instead
            }
            catch (SecurityException ex)
            {
                throw new RecoverableException(
                    "Settings cannot be loaded. Check that you have sufficient permissions.", ex);
            }
            catch (XmlException)
            {
                // settings are corrupted
                // just use default values instead
            }
        }

        private static IEnumerable<string> Prepare(this string setting)
        {
            return setting
                .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(extension => extension.Trim())
                .Distinct()
                .Select(extension => extension.StartsWith(".") ? extension : "." + extension);
        }

        private static void PrepareExtensionsMap()
        {
            foreach (var extension in TextBasedExtensions.Prepare())
            {
                _fileExtensionsMap.Add(extension, FileTypes.Text);
            }
            foreach (var extension in XmlBasedExtensions.Prepare())
            {
                _fileExtensionsMap.Add(extension, FileTypes.Xml);
            }
            foreach (var extension in HtmlBasedExtensions.Prepare())
            {
                _fileExtensionsMap.Add(extension, FileTypes.Html);
            }
        }

        private static IEnumerable<string> ToSearhPatterns(this IEnumerable<string> extensions)
        {
            return extensions.Select(extension => "*" + extension).ToArray();
        }

        #endregion
    }
}
