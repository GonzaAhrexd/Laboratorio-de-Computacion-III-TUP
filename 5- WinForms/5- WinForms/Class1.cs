using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__WinForms
{
    public class Animal{
        private string nombre;
        private string especie;
        
        public Animal(string nombre, string especie)
        {
            this.nombre = nombre;
            this.especie = especie;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEspecie(string especie)
        {
            this.especie = especie;
        }
        public string getEspecie()
        {
            return this.especie;
        }
        public string getNombre()
        {
            return this.nombre;
        }

    }
}
