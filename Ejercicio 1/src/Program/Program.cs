using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve estanteria1 = new Shelve(book1);
            Shelve estanteria2 = new Shelve(book2);
            Sector sector1 = new Sector();
            sector1.AgregarShelve(estanteria2);
            estanteria1.AddLibros(book2);
            
            

        }
    }
}