using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Motocicletas : Vehiculo{
        public Motocicletas(string marca, string modelo) : base(marca, modelo){ 
        
        }
        public void acelerar()
        {
            Console.WriteLine("La motocicleta ha acelerado");
        }
        public void frenar()
        {
            Console.WriteLine("La motocicleta se ha detenido");
        }
    
    }
    
    
}
