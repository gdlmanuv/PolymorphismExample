using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public abstract class SpecialEditionPublication : Publication
    {
        public bool IsSpecialEdition { get; set; }
    }
}
