using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    public class Aves : Animal, IAnimal{
        public Aves(string nombre, string especie, string comida) : base(nombre, especie, comida) { }

        public string volar()
        {
            return "El " + this.getNombre() + " vuela";
        }
        public string volar(int metros){
            return "El " + this.getNombre() + " vuela " + metros + " metros";
        }
        public string volar(int metros, String destino){
            return "El " + this.getNombre() + " vuela " + metros + " metros hasta" + destino;
        }
        public void comer()
        {
            Console.WriteLine("El " + this.getNombre() + " come " + this.getComida());
        }

    }
}
