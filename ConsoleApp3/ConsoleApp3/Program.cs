using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaLaboratorio3
{
    class Parcial
    {
        int c = 0;
        int b = 6;
        string s = "s";

        public void suma()
        {
            Console.WriteLine("Ingrese un número, le mostraré su tabla de multiplicar del 1 al 10.");
            int num = int.Parse(Console.ReadLine());
            while(true)
            {

                if(c>=0&& c<10)
                {

                    Console.WriteLine(num+"*"+c+" : " + (num * c));
                }
                else
                {
                    break;

                }
            }


        }
    }
}