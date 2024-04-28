using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    public class Mamiferos : Animal, IAnimal  {
        public Mamiferos(string nombre, string especie, string comida) : base(nombre, especie, comida) { }
        
        public string amamantar()
        {
            return "El " + this.getNombre() + " amamanta a sus crias";
        }
        public void comer()
        {
            Console.WriteLine("El " + this.getNombre() + " come " + this.getComida());
        }

    }
}
