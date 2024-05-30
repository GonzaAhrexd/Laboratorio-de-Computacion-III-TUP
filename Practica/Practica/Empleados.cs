using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Empleados{
        private string nombre;

        public Empleados(string nombre){
            this.nombre = nombre;
        }
        public void setNombre(string nombre){
            this.nombre  = nombre;
        }
        public string getNombre(){ 
            return this.nombre;
        }

        public void conducir(Vehiculo vehiculo){
            Console.WriteLine(this.nombre + " está conduciendo" + vehiculo.getModelo);
        }
        public void verificarBateria(BicicletaElectrica bicicleta)
        {
            Console.WriteLine(this.nombre + " está verificando si " + bicicleta.getModelo + " tiene batería");
            Console.WriteLine("La batería disponible de la bicicleta eléctrica es de " + bicicleta.getBateria());

        }
        public void cargarBateriaBicicletaElectrica(BicicletaElectrica bicicleta){
            Console.WriteLine(this.nombre + " está cargando la batería de " + bicicleta.getModelo());
            bicicleta.setBateria(100);

        }



    }
}
