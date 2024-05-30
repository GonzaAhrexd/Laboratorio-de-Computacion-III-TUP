using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Coches : Vehiculo{
        public Coches(string marca, string modelo) : base(marca, modelo)
        {
        }
        public void arrancar()
        {
            Console.WriteLine("El coche ha arrancado");
        }
        public void detener()
        {
            Console.WriteLine("El coche se ha detenido");
        }   

    }
}
