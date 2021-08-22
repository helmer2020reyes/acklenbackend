using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACKLEN_API_BACKEND.Data.VM
{
    public class BooksVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Isread { get; set; }
        public DateTime? Dateread { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Coverurl { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
