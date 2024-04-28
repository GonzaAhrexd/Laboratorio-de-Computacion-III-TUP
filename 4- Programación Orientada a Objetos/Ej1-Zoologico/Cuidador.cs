using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    public class Cuidador{
        private String nombre;
        private int edad;
        private List<Animal> AnimalesASuCuidado = new List<Animal> { };

        public void setNombre(String nombre){
            this.nombre = nombre;
        }
        public String getNombre(){
            return this.nombre;
        }
        public void setEdad(int edad){
            this.edad = edad;
        }
        public int getEdad(){
            return this.edad;
        }

        public Cuidador(String nombre, int edad) {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void cuidarAnimal(Animal animal){
            AnimalesASuCuidado.Add(animal);
        }
        public void dejarDeCuidar(Animal animal){
            AnimalesASuCuidado.Remove(animal);
        }
        public void AlimentarAnimal(Animal animal){
            animal.comer();
        }



    }
}
