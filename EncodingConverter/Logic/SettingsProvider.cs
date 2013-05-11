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

        static SettingsProvider()
        {
            LoadSettings();

            AddToExtensionsMap(FileTypes.Text, _textBasedExtensions);
            AddToExtensionsMap(FileTypes.Xml, _xmlBasedExtensions);
            AddToExtensionsMap(FileTypes.Html, _htmlBasedExtensions);
        }

        public static OrderBy OrderBy { get; set; }

        private static string _textBasedExtensions;
        public static string TextBasedExtensions
        {
            get { return _textBasedExtensions; }
            set
            {
                _textBasedExtensions = value;
                UpdateExtensionsMapFor(FileTypes.Text, _textBasedExtensions);
            }
        }

        private static string _xmlBasedExtensions;
        public static string XmlBasedExtensions
        {
            get { return _xmlBasedExtensions; }
            set
            {
                _xmlBasedExtensions = value;
                UpdateExtensionsMapFor(FileTypes.Xml, _xmlBasedExtensions);
            }
        }

        private static string _htmlBasedExtensions;
        public static string HtmlBasedExtensions
        {
            get { return _htmlBasedExtensions; }
            set
            {
                _htmlBasedExtensions = value;
                UpdateExtensionsMapFor(FileTypes.Html, _htmlBasedExtensions);
            }
        }

        public static IEnumerable<string> SearchPatterns
        {
            get { return _fileExtensionsMap.Keys.ToSearhPatterns(); }
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
                case OrderBy.Path: return fileData.OrderBy(d => d.Path);
                case OrderBy.Name: return fileData.OrderBy(d => d.Name);
                case OrderBy.Type: return fileData.OrderBy(d => d.Extension);
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
                            new XElement(TextBasedExtensionsTag, _textBasedExtensions),
                            new XElement(XmlBasedExtensionsTag, _xmlBasedExtensions),
                            new XElement(HtmlBasedExtensionsTag, _htmlBasedExtensions)));
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
            OrderBy = OrderBy.Name;

            _textBasedExtensions = TextBasedDefaultExtensions;
            _xmlBasedExtensions = XmlBasedDefaultExtensions;
            _htmlBasedExtensions = HtmlBasedDefaultExtensions;

            try
            {
                var config = XDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                var tag = config.Root.Element(OrderByTag);
                if (tag != null)
                {
                    OrderBy = (OrderBy)Enum.Parse(typeof(OrderBy), tag.Value.ToString());
                }
                tag = config.Root.Element(TextBasedExtensionsTag);
                if (tag != null)
                {
                    _textBasedExtensions = tag.Value;
                }
                tag = config.Root.Element(XmlBasedExtensionsTag);
                if (tag != null)
                {
                    _xmlBasedExtensions = tag.Value;
                }
                tag = config.Root.Element(HtmlBasedExtensionsTag);
                if (tag != null)
                {
                    _htmlBasedExtensions = tag.Value;
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

        private static void AddToExtensionsMap(FileTypes fileType, string extensions)
        {
            foreach (var extension in extensions.Prepare())
            {
                _fileExtensionsMap.Add(extension, fileType);
            }
        }

        private static void UpdateExtensionsMapFor(FileTypes fileType, string extensions)
        {
            // clean up old values
            var extensionsToRemove =_fileExtensionsMap
                .Where(p => p.Value == fileType)
                .Select(p => p.Key)
                .ToArray();
            foreach (var key in extensionsToRemove)
            {
                _fileExtensionsMap.Remove(key);
            }
            AddToExtensionsMap(fileType, extensions);
        }

        private static IEnumerable<string> ToSearhPatterns(this IEnumerable<string> extensions)
        {
            return extensions.Select(extension => "*" + extension);
        }

        #endregion
    }
}
