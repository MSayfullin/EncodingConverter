using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dokas.FluentStrings;
using Mozilla.CharDet;

namespace dokas.EncodingConverter.Logic
{
    internal sealed class EncodingManager
    {
        #region Consts

        private const string XmlEncodingPattern = @"(<\?xml.+encoding.*=.*[""|'])(.*)([""|'].*\?>)";
        private const string HtmlEncodingPattern = @"(<meta.+charset.*=)(.*)([""|'].*/*>)";
        private const string Html5EncodingPattern = @"(<meta.+charset.*=.*[""|'])(.*)([""|'].*/>)";

        #endregion

        private readonly FileManager _fileManager;

        private static readonly Regex _xmlEncoding;
        private static readonly Regex _htmlEncoding;
        private static readonly Regex _html5Encoding;

        private static readonly IEnumerable<Encoding> _encodings;

        static EncodingManager()
        {
            _xmlEncoding = new Regex(XmlEncodingPattern, RegexOptions.IgnoreCase);
            _htmlEncoding = new Regex(HtmlEncodingPattern, RegexOptions.IgnoreCase);
            _html5Encoding = new Regex(Html5EncodingPattern, RegexOptions.IgnoreCase);

            _encodings = Encoding.GetEncodings().Select(e => e.GetEncoding()).ToArray();
        }

        public static IEnumerable<Encoding> Encodings
        {
            get { return _encodings; }
        }

        public EncodingManager(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public async Task<Encoding> Resolve(string filePath)
        {
            UniversalDetector detector = null;
            await Task.Factory.StartNew(() =>
                {
                    var bytes = _fileManager.Load(filePath);

                    detector = new UniversalDetector();
                    detector.HandleData(bytes);
                });
            return !detector.DetectedCharsetName.IsEmpty() ? Encoding.GetEncoding(detector.DetectedCharsetName) : null;
        }

        public void Convert(string filePath, Encoding from, Encoding to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }
            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            byte[] convertedBytes;
            var bytes = _fileManager.Load(filePath);
            var fileType = filePath.GetFileType();
            if (fileType == FileTypes.Text)
            {
                // we just need to convert data
                convertedBytes = Encoding.Convert(from, to, bytes);
            }
            else if (fileType == FileTypes.Xml || fileType == FileTypes.Html)
            {
                var content = from.GetString(bytes);
                content = _xmlEncoding.Replace(content, m => m.Groups[1] + to.WebName + m.Groups[3]);
                if (fileType == FileTypes.Html)
                {
                    content = _htmlEncoding.Replace(content, m => m.Groups[1] + to.WebName + m.Groups[3]);
                    content = _html5Encoding.Replace(content, m => m.Groups[1] + to.WebName + m.Groups[3]);
                }
                convertedBytes = to.GetBytes(content);
            }
            else
            {
                throw new NotImplementedException("It seems that newly added File Type is not supported everywhere.");
            }
            _fileManager.Save(filePath, convertedBytes);
        }
    }
}
