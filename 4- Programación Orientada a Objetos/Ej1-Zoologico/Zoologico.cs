using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Zoologico
{
    public class Zoologico{ 
        private List<IAnimal> Animales = new List<IAnimal> { };
        private List<Cuidador> Cuidadores = new List<Cuidador> { };
        
        public void nuevoAnimal(IAnimal animal){
            Animales.Add(animal);
        }
        public void nuevoCuidador(Cuidador cuidador){
            Cuidadores.Add(cuidador);
        }
        public void eliminarAnimal(IAnimal animal)
        {
            Animales.Remove(animal);
        }
            public void eliminarCuidador(Cuidador cuidador){
            Cuidadores.Remove(cuidador);
        }
        public void mostrarAnimales()
        {
            foreach(Animal animal in Animales)
            {
                Console.WriteLine(animal.getNombre());
            }
        }
        public void mostrarCuidadores()
        {
            foreach(Cuidador cuidador in Cuidadores)
            {
                Console.WriteLine(cuidador.getNombre());
            }
        }
        public List<Cuidador> getCuidadores()
        {
            return Cuidadores;
        }
        public List<IAnimal> getAnimales()
        {
            return Animales;
        }

    }
}
