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
            return SettingsSupplier.SearchPatterns
                .AsParallel()
                .SelectMany(pattern => Directory.EnumerateFiles(_sourcePath.Value, pattern, SearchOption.AllDirectories));
        }

        public byte[] Load(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public void Save(string filePath, byte[] bytes)
        {
            if (!Directory.Exists(_destinationPath.Value))
            {
                Directory.CreateDirectory(_destinationPath.Value);
            }
            File.WriteAllBytes(Path.Combine(_destinationPath.Value, Path.GetFileName(filePath)), bytes);
        }
    }
}
