using System;
using System.Collections;
namespace SRP;
public class Shelve
    {
        public Shelve(Book Libro)
        {
            this.Libros.Add(Libro);
        }
        
    

        public ArrayList Libros = new ArrayList();

        public void AddLibros(Book libro)
        {
            this.Libros.Add(libro);

            Console.WriteLine("Se agrego un libro");
        }
        public void EliminateLibro(Book Libro)
        {
            this.Libros.Remove(Libro);
            
            Console.WriteLine("Se elimino un libro");
        }

    }