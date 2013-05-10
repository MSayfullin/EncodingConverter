using System;
using IO = System.IO;

namespace dokas.EncodingConverter.Logic
{
    internal sealed class FileData
    {
        public string Path { get; private set; }
        public string Name { get; private set; }
        public string Extension { get; private set; }

        public FileData(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            Path = path;
            Name = IO.Path.GetFileName(path);
            Extension = IO.Path.GetExtension(path);
        }

        public override bool Equals(object obj)
        {
            var otherFileData = obj as FileData;
            return otherFileData != null && Path.Equals(otherFileData.Path);
        }

        public override int GetHashCode()
        {
            return Path.GetHashCode();
        }
    }
}
