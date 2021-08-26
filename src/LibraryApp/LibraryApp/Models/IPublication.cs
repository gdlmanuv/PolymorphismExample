using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public interface IPublication
    {
        int Id { get; set; }

        string Title { get; set; }

        string Editorial { get; set; }

        int NumberOfPages { get; set; }

        string type { get; }
    }
}
