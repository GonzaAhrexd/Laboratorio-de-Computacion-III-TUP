using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    public class Peces : Animal, IAnimal{
        public Peces(string nombre, string especie, string comida) : base(nombre, especie, comida) { }

        public string nadar()
        {
            return "El " + this.getNombre() + " nada";
        }
        public string nadar(int metros)
        {
            return "El " + this.getNombre() + " nada " + metros + " metros";
        }   
        public void comer()
        {
            Console.WriteLine("El " + this.getNombre() + " come " + this.getComida());
        }
    }
}
