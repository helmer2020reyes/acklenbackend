using System;
using System.Collections.Generic;

#nullable disable

namespace ACKLEN_API_BACKEND.EntityModels
{
    public partial class Book
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
