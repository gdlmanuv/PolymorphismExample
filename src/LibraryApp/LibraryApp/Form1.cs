using LibraryApp.Models;
using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private readonly IList<Publication> _publications;

        public Form1()
        {
            InitializeComponent();
            _publications = PublicationService.GetPublications();

            PublicationService.AddPublication(new Book
            {
                Id = 7,
                Editorial = "Castillo",
                Title = "Matemáticas 2",
                ISBN = "1928364759",
                NumberOfPages = 201,
                Authors = new List<Author> { new Author { FirstName = "Martin", LastName = "Carrillo" } }
            });

            _publications.ToList().ForEach(p =>
            {
                if (p is SpecialEditionPublication)
                {
                    PublicationService.ChangeSpecialEdition(p as SpecialEditionPublication, true);
                }
                
            });

            List<Publication> t = PublicationService.GetPublicationByType("Comic").ToList();

            
        }
    }
}
