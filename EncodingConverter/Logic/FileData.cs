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
            Path = path;
            Name = IO.Path.GetFileName(path);
            Extension = IO.Path.GetExtension(path);
        }
    }
}
