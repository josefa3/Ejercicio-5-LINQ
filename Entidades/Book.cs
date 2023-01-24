using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Book
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublicationDate { get; set; }
        public int Sales { get; set; }

        public Book(string title, int authorId, int publicationDate, int sales)
        {
            this.Title = title;
            this.AuthorId = authorId;
            this.PublicationDate = publicationDate;
            this.Sales = sales;
        }

        public static List<Book> Books()
        {
            return new List<Book>()
            {
                new Book("Don Quijote de la Mancha", 1, 1605, 500),
                new Book("Historia de dos ciudades", 2, 1859, 200),
                new Book("El Señor de los Anillos", 3, 1978, 150),
                new Book("El principito", 4, 1951, 140),
                new Book("El Hobbit", 3, 1982, 100),
                new Book("Sueño en el Pabellon Rojo", 5, 1792, 100),
                new Book("Las Aventuras de Alicia en el Pais de las maravillas", 6, 1865, 100),
                new Book("Diez Negritos", 7, 1939, 100),
                new Book("El Leon, la Bruja y el Armario", 8, 1950, 85),
                new Book("El Codigo Da Vinci", 9, 2003, 80),
                new Book("El Guardian entre el Centeno", 10, 1951, 65),
                new Book("El Alquimista", 11, 1988, 65),

            };
        }
    }
}
