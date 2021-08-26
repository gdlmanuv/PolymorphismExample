using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public static class PublicationService
    {
        private static IList<Publication> _publications;

        static PublicationService()
        {
            _publications = new List<Publication>
            {
                new Book
                {
                    Id = 1,
                    ISBN = "1234567890",
                    Editorial = "Porrúa",
                    NumberOfPages = 325,
                    Title = "Cumbres Borrascosas",
                    Authors = new List<Author>
                    {
                        new Author
                        {
                            FirstName = "Emily",
                            LastName = "Brontë"
                        }
                    }
                },
                new Book
                {
                    Id = 2,
                    ISBN = "1234567891",
                    Editorial = "Dewey",
                    NumberOfPages = 412,
                    Title = "El código Da Vinci",
                    Authors = new List<Author>
                    {
                        new Author
                        {
                            FirstName = "Dan",
                            LastName = "Brown"
                        }
                    }
                },
                new Magazine{
                    Id = 3,
                    Editorial = "Planeta",
                    IsSpecialEdition = false,
                    NumberOfPages = 120,
                    PublicationNumber = 25,
                    Title = "Muy interesante",
                    Subtitle = "Las Muralla China"

                },
                new Magazine{
                    Id = 4,
                    Editorial = "Reader's Digest",
                    IsSpecialEdition = true,
                    NumberOfPages = 127,
                    PublicationNumber = 125,
                    Title = "Selecciones",
                    Subtitle = "El Sistema Solar"

                },
                new Comic{
                    Id = 5,
                    Company = "DC",
                    Editorial = "DC United",
                    IsSpecialEdition = true,
                    NumberOfPages = 211,
                    Title = "La muerte de Supermán"
                },
                new Comic{
                    Id = 6,
                    Company = "Marvel",
                    Editorial = "Marvel Ltd.",
                    IsSpecialEdition = true,
                    NumberOfPages = 186,
                    Title = "Spiderman VS Capulina"
                }
            };
        }

        public static IList<Publication> GetPublications()
        {
            return _publications;
        }

        public static void AddPublication(Publication publication)
        {
            _publications.Add(publication);
        }

        public static void ChangeSpecialEdition(SpecialEditionPublication specialEditionPublication, bool value)
        {
            specialEditionPublication.IsSpecialEdition = value;
        }

        public static IEnumerable<Publication> GetPublicationByType(string type)
        {
            foreach (var publication in _publications.Where(p => p.type.Equals(type)))
            {
                yield return publication;
            }


        }
    }
}
