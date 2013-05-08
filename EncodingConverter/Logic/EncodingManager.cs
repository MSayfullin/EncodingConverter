using System;
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

        static EncodingManager()
        {
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
                throw new ArgumentOutOfRangeException("from");
            }
            if (to == null)
            {
                throw new ArgumentOutOfRangeException("to");
            }

            var bytes = _fileManager.Load(filePath);
            var convertedBytes = Encoding.Convert(from, to, bytes);
            _fileManager.Save(filePath, convertedBytes);
        }
    }
}
