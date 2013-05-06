using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dokas.EncodingConverter.Logic
{
    internal sealed class FileManager
    {
        private const string ConvertedFolderDefaultName = "Converted";

        private readonly ITextWrapper _sourcePath;
        private readonly ITextWrapper _destinationPath;
        private string _destinationPathGeneratedValue;

        private readonly IEnumerable<string> _textFileExtensions = new[] { "*.txt" };
        private readonly IEnumerable<string> _xmlBasedFileExtensions = new[] { "*.xml", "*.fb2" };
        private readonly IEnumerable<string> _htmlFileExtensions = new[] { "*.htm", "*.html" };
        private readonly IEnumerable<string> _searchPatterns;

        public FileManager(ITextWrapper sourcePath, ITextWrapper destinationPath)
        {
            if (sourcePath == null)
            {
                throw new ArgumentNullException("sourcePath");
            }
            if (destinationPath == null)
            {
                throw new ArgumentNullException("destinationPath");
            }

            _sourcePath = sourcePath;
            _destinationPath = destinationPath;
            _destinationPathGeneratedValue = String.Empty;

            _searchPatterns = _textFileExtensions.Concat(_xmlBasedFileExtensions).Concat(_htmlFileExtensions);
        }

        public void SetDestinationPath()
        {
            if (_destinationPath.Value.Length == 0
                || _destinationPath.Value.ToLower() == _destinationPathGeneratedValue.ToLower())
            {
                _destinationPath.Value = Path.Combine(_sourcePath.Value, ConvertedFolderDefaultName);
                _destinationPathGeneratedValue = _destinationPath.Value;
            }
        }

        public IEnumerable<string> GetFilePaths()
        {
            return _searchPatterns
                .AsParallel()
                .SelectMany(pattern => Directory.EnumerateFiles(_sourcePath.Value, pattern, SearchOption.AllDirectories));
        }
    }
}
