using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico{
    public class PlantaCarnivora : IAnimal
    {
        private string nombre;
        private string especie;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setEspecie(string especie)
        {
            this.especie = especie;
        }
        public string getEspecie()
        {
            return this.especie;
        }

        public PlantaCarnivora(string nombre, string especie){
            this.nombre = nombre;
            this.especie = especie;
        }
 

        public void comer()
        {
             Console.WriteLine("La " + this.getNombre() + " come ");
        }

        public string comer(Animal animal)
        {
            return "La " + this.getNombre() + " come un " + animal;
        }
    }
   

}
