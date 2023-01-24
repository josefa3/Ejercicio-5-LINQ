using Entidades;
using System.Linq;


//3 libros con mas ventas

var consultaBooksAsc = (from b in Book.Books()
            orderby b.Sales descending
            select new
               {
                  Title = b.Title
               }).Take(3);

Console.WriteLine("Los 3 libros mas vendidos son: ");
foreach (var book in consultaBooksAsc)
  {    
    Console.WriteLine(" {0}", book.Title);
  }
Console.WriteLine();


//3 libros con menos ventas

var consultaBooksDesc = (from b in Book.Books()
                        orderby b.Sales ascending
                        select new
                        {
                            Title = b.Title
                        }).Take(3);

Console.WriteLine("Los 3 libros menos vendidos son: ");
foreach (var book in consultaBooksDesc)
{
    Console.WriteLine(" {0}", book.Title);
}
Console.WriteLine();


//Autor con mas libros publicados

var autorMasPublicado = (from b in Book.Books()
                         join a in Author.Books()
                         on b.AuthorId equals a.AuthorId
                         orderby b.Sales descending
                         select new
                         {
                             Name = a.Name,
                             Title = b.Title
                         }).Take(1);

foreach (var book in autorMasPublicado)
{
    Console.WriteLine("El libro {0}, es el mas publicado del autor {1}.", book.Title, book.Name);
}
Console.WriteLine();


//Autor y cantidad de libros publicados

var autorCant = from a in Author.Books()
                join c in Book.Books()
                on a.AuthorId equals c.AuthorId
                select new
                {
                    Name = a.Name,
                    Sales = c.Sales,
                };

Console.WriteLine("Autores y su numero de ventas: ");
foreach (var book in autorCant)
{
    Console.WriteLine("Nombre: {0}, Numero de ventas: {1}", book.Name, book.Sales);
}
Console.WriteLine();


//Libros publicados hace menos de 50 años

var librosNuevos = from n in Book.Books()
                   where n.PublicationDate > DateTime.Now.AddYears(-50).Year
                   select n;
Console.WriteLine("Libros publicados hace menos de 50 años son: ");
foreach (var libros in librosNuevos)
{
    Console.WriteLine("Titulo: {0}, Año: {1}", libros.Title, libros.PublicationDate);
}
Console.WriteLine();


//Libro mas viejo

var librold = (from v in Book.Books()
                 orderby v.PublicationDate ascending
                 select new
                 {
                     Title = v.Title,
                     PublicationDate = v.PublicationDate
                 }).Take(1);

foreach (var libro in librold)
{
    Console.WriteLine("El libro mas antiguo es {0} del año {1}", libro.Title, libro.PublicationDate);
}
Console.WriteLine();


//Autores que tengan un libro que comience con "El"

var buscarEl = from a in Author.Books()
               join t in Book.Books()
               on a.AuthorId equals t.AuthorId
               where t.Title.StartsWith("El")
               select new
               {
                   Name = a.Name,
                   Title = t.Title,
               };

Console.WriteLine("Los titulos que comienzan con 'El' son: ");
foreach (var titulo in buscarEl)
{
    Console.WriteLine("{0} de {1}", titulo.Title, titulo.Name);
}

Console.Read();