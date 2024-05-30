using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class BicicletaElectrica : Vehiculo{
        private bool isMotorOn = false;
        private int bateria = 0;
        public BicicletaElectrica (string marca, string modelo) : base(marca, modelo){
            this.bateria = 100;
        }

        public void encenderMotor(){
            isMotorOn = true;            
            this.bateria = bateria - 10;
        }
        public void apagarMotor(){
            isMotorOn = false;
        } 

        public int getBateria(){
            return this.bateria;
        }

        public void setBateria(int carga){
            this.bateria = carga;
        }

    }
}
