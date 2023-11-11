using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY_InternShare.Shared
{
    public class BlobObject
    {
        public Stream? Content { get; set; }
        public string? ContentType { get; set; }
        public string? Genre { get; set; } // Can be "PFE" or "Ete"
        public string? FileName { get; set; }
        public string? FileExtension { get; set; }
    }
}
