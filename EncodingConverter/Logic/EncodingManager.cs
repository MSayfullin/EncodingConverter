using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dokas.FluentStrings;
using Mozilla.CharDet;

namespace dokas.EncodingConverter.Logic
{
    internal static class EncodingManager
    {
        private static readonly IEnumerable<Encoding> _encodings;

        static EncodingManager()
        {
            _encodings = Encoding.GetEncodings().Select(e => e.GetEncoding()).ToArray();
        }

        public static IEnumerable<Encoding> Encodings
        {
            get { return _encodings; }
        }

        public static async Task<Encoding> Resolve(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            var charDet = new UniversalDetector();
            await Task.Factory.StartNew(() => charDet.HandleData(bytes));
            return !charDet.DetectedCharsetName.IsEmpty() ? Encoding.GetEncoding(charDet.DetectedCharsetName) : null;
        }

        public static void Convert(string filePath, Encoding from, Encoding to)
        {
            //var bytes = _fileManager.Load(filePath);
            //var convertedBytes = Encoding.Convert(from, to, bytes);
        }
    }
}
