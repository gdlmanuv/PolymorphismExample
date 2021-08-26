﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public abstract class Publication : IPublication
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Editorial { get; set; }

        public int NumberOfPages { get; set; }

        public abstract string type { get; }
    }
}
