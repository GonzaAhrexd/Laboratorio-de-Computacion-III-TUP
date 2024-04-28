using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    abstract public class Animal{
        private string nombre;
        public string especie;
        public string comida;

        public Animal(string nombre, string especie, string comida){
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
        }

        public void setNombre(string nombre){
            this.nombre = nombre;
        }
        public string getNombre(){
            return this.nombre;
        }
        public string getEspecie(){
            return this.especie;
        }
        public string getComida(){
            return this.comida;
        }
        public void setComida(string comida){
            this.comida = comida;
        }
        public void setEspecie(string especie){
            this.especie = especie;
        }

        public void comer()
        {
            Console.WriteLine("El " + this.getNombre() + " come " + this.getComida());
        }


    }
}
