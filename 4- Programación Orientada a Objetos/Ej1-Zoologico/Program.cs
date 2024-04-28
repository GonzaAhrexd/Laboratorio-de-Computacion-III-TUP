/*
 * Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores
 * . El sistema debe permitir la creación y gestión de diferentes tipos de animales, 
 * incluyendo mamíferos, aves, peces y una planta carnívora. Cada animal debe tener un nombre, 
 * una especie y un tipo de comida asociado. 
 * Los mamíferos deben ser capaces de amamantar, las aves deben poder volar y los peces deben poder 
 * nadar. Además, se requiere la capacidad de crear una planta carnívora que se alimente 
 * de otros seres vivos
Los cuidadores serán responsables de alimentar a los animales. Cada cuidador debe 
tener un nombre y ser capaz de alimentar a los animales bajo su cuidado con la comida adecuada. 
Esto incluye tanto a los animales convencionales como a la planta carnívora.
El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores. 
Esto implica la capacidad de agregar, eliminar y actualizar la información de los animales 
y cuidadores. Además, el zoológico debe ser capaz de mostrar la lista de animales y cuidadores 
disponibles.

El sistema debe ser implementado en C# y ejecutarse por consola. 
Los alumnos deberán utilizar herencia, polimorfismo, interfaces y métodos virtuales para garantizar 
la flexibilidad y extensibilidad del sistema. Además, se debe implementar la inyección 
de dependencias para permitir que los cuidadores alimenten a cualquier tipo de animal,
incluida la planta carnívora.
 * 
 * 
 * 
 */

using Ej1_Zoologico;
using System.Runtime.CompilerServices;


namespace Ej1_Zoologico
{

    class Program
    {


        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();
            while(true)
            {

                Console.WriteLine("Bienvenido al zoológico");
                Console.WriteLine("Qué desea hacer?");
                Console.WriteLine("1. Agregar animal");
                Console.WriteLine("2. Agregar Planta Carnivora");
                Console.WriteLine("3. Agregar cuidador");
                Console.WriteLine("4. Mostrar lista de animales");
                Console.WriteLine("5. Mostrar lista de cuidadores");
                Console.WriteLine("6. Cuidar animales");
                Console.WriteLine("7. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {

                    case 1:
                        agregarAnimal(zoologico);
                        break;
                    case 2:
                        agregarPlantaCarnivora(zoologico);
                        break;
                    case 3:
                        agregarCuidador(zoologico);
                        break;
                    case 4:
                        zoologico.mostrarAnimales();
                        break;
                    case 5:
                        zoologico.mostrarCuidadores();
                        break;
                    case 6:
                        cuidarNuevoAnimal(zoologico);
                        break;
                    case 7:
                        return;
                        
                }
            }

        }

        private static void agregarAnimal(Zoologico zoologico)
        {
            Console.WriteLine("Qué tipo de animal desea agregar?");
            Console.WriteLine("1. Mamífero");
            Console.WriteLine("2. Ave");
            Console.WriteLine("3. Pez");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    agregarNuevoAnimal("Mamifero", zoologico);
                    break;
                case 2:
                    agregarNuevoAnimal("Ave", zoologico);
                    break;
                case 3:
                    agregarNuevoAnimal("Pez", zoologico);
                    break;

            }
        }
        private static void agregarNuevoAnimal(String tipo, Zoologico zoologico)
        {

            Console.WriteLine("Ingrese el nombre del animal");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la especie del animal");
            string especie = Console.ReadLine();
            Console.WriteLine("Ingrese la comida del animal");
            string comida = Console.ReadLine();

            if(tipo=="Mamifero")
            {
                Mamiferos mamifero = new Mamiferos(nombre, especie, comida);
                zoologico.nuevoAnimal(mamifero);
            }
            else if(tipo=="Ave")
            {
                Aves ave = new Aves(nombre, especie, comida);
                zoologico.nuevoAnimal(ave);
            }
            else if(tipo=="Pez")
            {
                Peces pez = new Peces(nombre, especie, comida);
                zoologico.nuevoAnimal(pez);
            }


        }
        private static void agregarPlantaCarnivora(Zoologico zoologico)
        {
            Console.WriteLine("Ingrese el nombre de la planta");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la especie de la planta");
            string especie = Console.ReadLine();
            PlantaCarnivora plantaCarnivora = new PlantaCarnivora(nombre, especie);
            zoologico.nuevoAnimal(plantaCarnivora);
        }
        private static void agregarCuidador(Zoologico zoologico)
        {
            Console.WriteLine("Ingrese el nombre del cuidador");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del cuidador");
            int edad = int.Parse(Console.ReadLine());
            Cuidador cuidador = new Cuidador(nombre, edad);
            zoologico.nuevoCuidador(cuidador);
        }
        private static void cuidarNuevoAnimal(Zoologico zoologico){
            Console.WriteLine("Ingrese el nombre del cuidador");
            string nombre = Console.ReadLine();
                
            // Buscar cuidador 
            foreach(Cuidador cuidador in zoologico.getCuidadores())
            {
                if(cuidador.getNombre()==nombre)
                {
                    Console.WriteLine("Ingrese el nombre del animal que desea cuidar");
                    string nombreAnimal = Console.ReadLine();
                    foreach(Animal animal in zoologico.getAnimales())
                    {
                        if(animal.getNombre()==nombreAnimal)
                        {
                            cuidador.cuidarAnimal(animal);
                        }
                    }
                }
            }

        }

    }
}