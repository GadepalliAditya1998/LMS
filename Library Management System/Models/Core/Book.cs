using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models.Core
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public int Volume { get; set; }

        public Genre Genre { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
