using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dokas.FluentStrings;
using Mozilla.CharDet;

namespace dokas.EncodingConverter.Logic
{
    internal sealed class EncodingManager
    {
        private readonly FileManager _fileManager;
        private static readonly IEnumerable<Encoding> _encodings;
        private static readonly UniversalDetector _detector;

        static EncodingManager()
        {
            _encodings = Encoding.GetEncodings().Select(e => e.GetEncoding()).ToArray();
            _detector = new UniversalDetector();
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
            _detector.Reset();
            await Task.Factory.StartNew(() =>
                {
                    var bytes = _fileManager.Load(filePath);
                    _detector.HandleData(bytes);
                });
            return !_detector.DetectedCharsetName.IsEmpty() ? Encoding.GetEncoding(_detector.DetectedCharsetName) : null;
        }

        public void Convert(string filePath, Encoding from, Encoding to)
        {
            var bytes = _fileManager.Load(filePath);
            var convertedBytes = Encoding.Convert(from, to, bytes);
            _fileManager.Save(filePath, convertedBytes);
        }
    }
}
