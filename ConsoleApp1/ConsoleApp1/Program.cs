using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2024, 05, 1, 18, 22 ,40);

            // Mostrar la fecha en formato corto
            Console.WriteLine(fecha.ToShortDateString());
            // Mostrar la fecha en formato largo
            Console.WriteLine(fecha.ToLongDateString());
            // Mostrar la hora en formato corto
            Console.WriteLine(fecha.ToShortTimeString());
            // Mostrar la hora en formato largo
            Console.WriteLine(fecha.ToLongTimeString());

            Console.WriteLine(fecha.DayOfYear);

            Console.WriteLine(DateTime.IsLeapYear(2005));

            //Sumar días u horas
            Console.WriteLine(fecha.AddDays(50)); 

            TimeSpan diferencia = fecha - DateTime.Now;
            
            //Días de diferencia
            Console.WriteLine(diferencia.Days);
            
            // Horas de diferencia
            Console.WriteLine(diferencia.Hours);
            // Minutos de diferencia
            Console.WriteLine(diferencia.Minutes);
            // Segundos de diferencia
            Console.WriteLine(diferencia.Seconds);

            //Obtener horario en UTC
            Console.WriteLine(fecha.ToUniversalTime());
            //Obtener horario local
            Console.WriteLine(fecha.ToLocalTime());
            //Obtener horario en otro huso horario
            Console.WriteLine(fecha.ToLocalTime().AddHours(3));
        }
    }
}
