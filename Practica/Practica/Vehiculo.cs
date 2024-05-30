using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Vehiculo{
        public string marca;
        public string modelo;
        public bool disponible;
        
        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.disponible = true;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public string getMarca(){
        return this.marca;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public void setDisponible(bool disponible)
        {
            this.disponible = disponible;
        }
        public bool getDisponible()
        {
            return this.disponible;
        }



    }
}
