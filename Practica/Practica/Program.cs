/*
 * ¡Entendido! Aquí tienes un enunciado alternativo para un problema de programación orientada a objetos en C#:

Enunciado del problema:

Una empresa de alquiler de vehículos necesita un sistema para gestionar su flota de automóviles y empleados.
El sistema debe permitir la creación y gestión de diferentes tipos de vehículos, incluyendo coches, motocicletas y bicicletas eléctricas. 
Cada vehículo debe tener una marca, un modelo y un estado de disponibilidad. 
Los coches deben ser capaces de arrancar y detenerse, las motocicletas deben poder acelerar y frenar, y 
las bicicletas eléctricas deben ser capaces de encender y apagar su motor eléctrico.

Los empleados serán responsables de gestionar los vehículos. Cada empleado debe tener un nombre y ser capaz de realizar 
acciones específicas según el tipo de vehículo. Esto incluye desde conducir los coches y motocicletas hasta asegurarse de que las 
bicicletas eléctricas estén cargadas y listas para su uso.
La empresa debe tener la capacidad de administrar tanto los vehículos como a los empleados. 
Esto implica la capacidad de agregar, eliminar y actualizar la información de los vehículos y empleados.
Además, la empresa debe ser capaz de mostrar la lista de vehículos disponibles y de asignar tareas a los empleados 
según sus habilidades y disponibilidad.

El sistema debe ser implementado en C# y ejecutarse por consola. Se debe hacer uso de herencia, 
polimorfismo, interfaces y métodos virtuales para garantizar la flexibilidad y extensibilidad del sistema. 
Además, se requiere implementar la inyección de dependencias para permitir que los empleados realicen acciones en 
cualquier tipo de vehículo de manera adecuada.
 */


namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vehiculo vehiculo = new Vehiculo("Toyota", "Corolla");



        }
    }
}
