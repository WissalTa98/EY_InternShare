using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http; // Add this using directive


namespace EY_InternShare.Shared
{
    public class DocumentIntern
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string FileExtension { get; set; }
        public string BlobUri { get; set; }
        public string FilePath { get; set; }

    }
}
