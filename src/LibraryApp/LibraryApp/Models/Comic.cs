using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Comic : SpecialEditionPublication
    {
        public string Company { get; set; }

        public override string type => "Comic";
    }
}
