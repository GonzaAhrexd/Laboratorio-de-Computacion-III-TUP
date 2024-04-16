using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Animal{
        private string nombre { get; set; }
        public string especie { get; set; }
        public string comida {  get; set; }

        public Animal (string nombre, string especie, string comida){
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
        }

        public string comer(){
            return "El " + this.nombre + " come " + this.comida;
        }   


    }
}
