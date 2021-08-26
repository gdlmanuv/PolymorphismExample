using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Magazine : SpecialEditionPublication
    {
        public int PublicationNumber { get; set; }
        public string Subtitle { get; set; }

        public override string type => "Magazine";
    }
}
