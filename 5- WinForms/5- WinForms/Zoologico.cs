using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__WinForms
{
    public class Zoologico{
        public List<Animal> animales = new List<Animal>();
        
      
        //Agrega esos animales a la lista
        public Zoologico()
        {
            Animal Perro = new Animal("Firulais", "Perro");
            Animal Gato = new Animal("Michi", "Gato");
            Animal Loro = new Animal("Paco", "Loro");
            Animal Cebra = new Animal("Rayas", "Cebra");
            Animal Elefante = new Animal("Dumbo", "Elefante");
            Animal Jirafa = new Animal("Lola", "Jirafa");
            Animal Tigre = new Animal("Tony", "Tigre");
            
            animales.Add(Perro);
            animales.Add(Gato);
            animales.Add(Loro);
            animales.Add(Cebra);
            animales.Add(Elefante);
            animales.Add(Jirafa);
            animales.Add(Tigre);

        }


    }
}
