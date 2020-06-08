using System;
using System.IO;

namespace PdfMerger.Objects
{
    public class PdfEntry
    {
        public String FilePath { get; }
        private String Name { get; }

        public PdfEntry(String path)
        {
            this.FilePath = path;

            Name = Path.GetFileName(path);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
