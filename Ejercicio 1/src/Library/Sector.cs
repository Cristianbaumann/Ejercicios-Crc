using System;
using System.Collections;
namespace SRP
{
    public class Sector
    {
        public Sector()
        {

        }
        public string NombreSector { get ; set ;}
        public string NombreEstanteria{get; set;}

        public ArrayList Shelve = new ArrayList();

        public void AgregarShelve(Shelve shelve)
        {
            this.Shelve.Add(NombreEstanteria);
            Console.WriteLine("Se agrego una estanteria ");
        
        }
        public void EliminateShelve(Shelve shelve, string NombreEstanteria)
        {
            this.NombreEstanteria = NombreEstanteria;
            this.Shelve.Remove(shelve);
            Console.WriteLine("Se elimino una estanteria ");
        }
    }
}