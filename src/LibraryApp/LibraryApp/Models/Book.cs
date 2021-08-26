using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book : Publication
    {
        public string ISBN { get; set; }

        public List<Author> Authors { get; set; }

        public override string type => "Book";
    }
}
