using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Mozilla.CharDet;
using dokas.FluentStrings;
using System.Threading.Tasks;
using System.Threading;

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
            var bytes = File.ReadAllBytes(filePath);
            var convertedBytes = Encoding.Convert(from, to, bytes);
            //if (!Directory.Exists(DestinationFolder))
            //{
            //    Directory.CreateDirectory(DestinationFolder);
            //}
            //File.WriteAllBytes(Path.Combine(DestinationFolder, Path.GetFileName(filePath)), convertedBytes);
        }
    }
}
