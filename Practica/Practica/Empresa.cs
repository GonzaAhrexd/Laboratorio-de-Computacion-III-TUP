using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Empresa{
       private List<Vehiculo> vehiculos = new List<Vehiculo>();
       
        private List<Empleados> Empleados = new List<Empleados>();
    
        public Empresa(List<Vehiculo> vehiculos, List<Empleados> empleados){
            this.vehiculos = vehiculos;
            this.Empleados = empleados;
        }

        public void agregarVehiculos(Vehiculo vehiculo){
            this.vehiculos.Add(vehiculo);
        }

        public void agregarEmpleado(Empleados empleado){
            this.Empleados.Add(empleado);
        }

        public void eliminarVehiculos(Vehiculo vehiculo){
            this.vehiculos.Remove(vehiculo);
        }
        public void eliminarEmpleado(Empleados empleado){
            this.Empleados.Remove(empleado);
        }
        public void editarVehiculo(int index, Vehiculo vehiculo){
            this.vehiculos[index] = vehiculo;
        }
        public void editarEmpleado(int index, Empleados empleado)
        {
            this.Empleados[index] = empleado;
        }


    }
}
