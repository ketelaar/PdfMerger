using System.IO;

namespace PdfMerger.Objects
{
    public class PdfEntry
    {
        public string FilePath { get; }
        private string Name { get; }

        public PdfEntry(string path)
        {
            FilePath = path;

            Name = Path.GetFileName(path);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
