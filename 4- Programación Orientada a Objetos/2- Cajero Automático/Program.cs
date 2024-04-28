/*
 * Desarrolle una aplicación en C#, para un cajero automático. La aplicación permitirá crear
 * cuentas para jubilados y personas en actividad. Los usuarios del cajero podrán depositar 
 * en su cuenta y realizar extracciones de la misma. 
 * Si el usuario es una persona en actividad laboral podrá retirar hasta, 20000 pesos en concepto de 
 * adelanto de sueldo. Si el usuario es una persona jubilada podrá retirar en concepto de adelanto solo 
 * 10000. Cada operación de ingreso o extracción deberá registrar la fecha, el cajero y el monto de la operación
 * . Los cajeros se identifican por su dirección y número de cajeros. Si durante dos meses de operación 
 * un usuario tuvo un saldo positivo superior a 20000 pesos, se le ofrecerá un crédito pre acordado 
 * de, 80000 pesos. Con lo cual, su nuevo límite de extracción en negativo será de, 80000 pesos
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


class Banco{
    public List<Cuenta> cuentas = new List<Cuenta>();
    public void nuevoMes(){
        Console.WriteLine("Nuevo mes");
        foreach (Cuenta cuenta in cuentas)
        {

            double saldo = cuenta.getSaldoAdelanto();

            bool cuentaLaboral = cuenta.getDuenioCuenta().getTipoCuenta() == "persona en actividad laboral";
            bool jubilado = cuenta.getDuenioCuenta().getTipoCuenta() == "jubilado";


            if (saldo < 20000.00 && cuentaLaboral{
                cuenta.setSaldoAdelanto(20000);
                cuenta.setMesesAFavor(0);
            }
            else if (saldo == 20000.00 && cuenta.getMesesAFavor() < 2{
                cuenta.setMesesAFavor(cuenta.getMesesAFavor() + 1);
            }
            else if (jubilado){
                cuenta.setSaldoAdelanto(10000);

            }
            else if (cuenta.getMesesAFavor() >= 2){
                cuenta.setSaldoAdelanto(80000);
                cuenta.setMesesAFavor(cuenta.getMesesAFavor() + 1);
            }
        }
    }
}

class Operacion
{
    private DateTime DateTime;
    private string cajero;
    private double monto;

    public Operacion(DateTime DateTime, string cajero, double monto)
    {
        this.DateTime = DateTime;
        this.cajero = cajero;
        this.monto = monto;
    }

    public void setDateTime(DateTime date)
    {
        this.DateTime = DateTime;
    }
    public DateTime getDateTime()
    {
        return this.DateTime;
    }
    public string getCajero()
    {
        return this.cajero;
    }
    public void setCajero(string cajero)
    {
        this.cajero = cajero;
    }
    public double getMonto()
    {
        return this.monto;
    }
    public void setMonto(double monto)
    {
        this.monto = monto;
    }


}

class Cuenta
{
    private Persona duenioCuenta;
    private double saldo;
    private double saldoAdelanto;
    private List<Operacion> operaciones;
    public int mesesAFavor = 1;
    public Cuenta(Persona duenioCuenta)
    {
        this.duenioCuenta = duenioCuenta;
        this.saldo = 0;
        this.operaciones = new List<Operacion>();
        if (duenioCuenta.getTipoCuenta() == "persona en actividad laboral")
        {
            this.saldoAdelanto = 20000.00;
        }
        else
        {
            this.saldoAdelanto = 10000.00;
        }
    }
    public int getMesesAFavor()
    {
        return this.mesesAFavor;
    }

    public void setMesesAFavor(int mesesAFavor)
    {
        this.mesesAFavor = mesesAFavor;
    }
    public double getSaldo()
    {
        return this.saldo;
    }
    public void setSaldo(double saldo)
    {
        this.saldo = saldo;
    }
    public List<Operacion> getOperaciones()
    {
        return this.operaciones;
    }
    public void setOperaciones(List<Operacion> operaciones)
    {
        this.operaciones = operaciones;
    }
    public void addOperacion(Operacion operacion)
    {
        this.operaciones.Add(operacion);
    }
    public void removeOperacion(Operacion operacion)
    {
        this.operaciones.Remove(operacion);
    }
    public double getSaldoAdelanto()
    {
        return this.saldoAdelanto;
    }
    public void setSaldoAdelanto(double saldoAdelanto)
    {
        this.saldoAdelanto = saldoAdelanto;
    }
    public Persona getDuenioCuenta()
    {
        return this.duenioCuenta;
    }
    public void setDuenioCuenta(Persona duenioCuenta)
    {
        this.duenioCuenta = duenioCuenta;
    }



}

class Cajero
{
    String direccion;
    int numeroCajero;

    public Cajero(String direccion, int numeroCajero)
    {
        this.direccion = direccion;
        this.numeroCajero = numeroCajero;
    }
    public String getDireccion()
    {
        return this.direccion;
    }
    public void setDireccion(String direccion)
    {
        this.direccion = direccion;
    }
    public int getNumeroCajero()
    {
        return this.numeroCajero;
    }
    public void setNumeroCajero(int numeroCajero)
    {
        this.numeroCajero = numeroCajero;
    }


}



class Persona
{
    private int dni;
    private string nombre;
    private string apellido;
    private int edad;
    private string telefono;
    private string tipoCuenta;
    public Persona(int dni, string nombre, string apellido, int edad, string telefono, string tipoCuenta)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.telefono = telefono;
        this.tipoCuenta = tipoCuenta;
    }

    //Cómo se declara un metodo abstracto en C#
    public void Depositar(Cuenta cuenta)
    {
        Console.WriteLine("Ingrese el monto a retirar: ");
        double monto = Convert.ToDouble(Console.ReadLine());
        int dia, mes, year;
        Console.WriteLine("Ingrese el día de la operación: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el mes de la operación: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el año de la operación: ");
        year = Convert.ToInt32(Console.ReadLine());
        DateTime fecha = new DateTime(year, mes, dia);

        Console.WriteLine("Ingrese el cajero: ");
        string cajero = Console.ReadLine();

        Operacion operacion = new Operacion(fecha, cajero, monto);
        cuenta.setSaldo(cuenta.getSaldo() + monto);
    }


    //duenioCuenta.RetiroAdelanto(cuenta);
    public void Retirar(Cuenta cuenta)
    {
        Console.WriteLine("Ingrese el monto a retirar: ");
        double monto = Convert.ToDouble(Console.ReadLine());
        if (monto>=cuenta.getSaldo())
        {
            Console.WriteLine("Fondos insuficientes");
            return;
        }
        else
        {
            int dia, mes, year;
            Console.WriteLine("Ingrese el día de la operación: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de la operación: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año de la operación: ");
            year = Convert.ToInt32(Console.ReadLine());
            DateTime fecha = new DateTime(year, mes, dia);

            Console.WriteLine("Ingrese el cajero: ");
            string cajero = Console.ReadLine();

            Operacion operacion = new Operacion(fecha, cajero, monto * -1);
            cuenta.setSaldo(cuenta.getSaldo() - monto);
        }
    }
    public void RetirarAdelanto(Cuenta cuenta)
    {

        Console.WriteLine("Puede retirar " + cuenta.getSaldoAdelanto());
        // Console.WriteLine("Acumula + " + cuenta.getMesesAFavor() + " meses con saldo positivo");
        int dia, mes, year;

        Console.WriteLine("Ingrese el día de la operación: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el mes de la operación: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el año de la operación: ");
        year = Convert.ToInt32(Console.ReadLine());
        DateTime fecha = new DateTime(year, mes, dia);


        Console.WriteLine("Ingrese el cajero: ");
        string cajero = Console.ReadLine();
        Console.WriteLine("Ingrese el monto a retirar: ");
        double monto = Convert.ToDouble(Console.ReadLine());
        double Limite = cuenta.getSaldoAdelanto();
        if (monto <= Limite)
        {
            Operacion operacion = new Operacion(fecha, cajero, monto);
            cuenta.setSaldoAdelanto(cuenta.getSaldoAdelanto() - monto);
            Console.WriteLine("Se realizó el adelanto de sueldo con éxito");
            Operacion nuevaOperacion = new Operacion(fecha, cajero, monto);
            cuenta.addOperacion(nuevaOperacion);
        }
        else
        {
            Console.WriteLine("El monto ingresado supera el límite de adelanto de sueldo");
        }
    }
    public int getDni()
    {
        return this.dni;
    }
    public void setDni(int dni)
    {
        this.dni = dni;
    }
    public string getNombre()
    {
        return this.nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public string getApellido()
    {
        return this.apellido;
    }
    public void setApellido(string apellido)
    {
        this.apellido = apellido;
    }
    public int getEdad()
    {
        return this.edad;
    }
    public void setEdad(int edad)
    {
        this.edad = edad;
    }
    public string getTelefono()
    {
        return this.telefono;
    }
    public void setTelefono(string telefono)
    {
        this.telefono = telefono;
    }
    public void setTipoCuenta(string tipoCuenta)
    {
        this.tipoCuenta = tipoCuenta;
    }
    public string getTipoCuenta()
    {
        return this.tipoCuenta;
    }
}

//Crea la clase PersonaEnActividad que herede de Persona

class Program
{
    static void Main()
    {
        //Hazme pruebas para sacar un adelanto de un jubilado y una persona en actividad
        Banco banco = new Banco();


        while (true)
        {

            int buscarDNI;
            //Menú de opciones para crear cuenta, consultar saldo, depositar, retirar, adelantos y salir
            Console.WriteLine("1. Crear cuenta");
            Console.WriteLine("2. Consultar saldo");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Retirar");
            Console.WriteLine("5. Adelanto de sueldo");
            Console.WriteLine("6. Nuevo mes");
            Console.WriteLine("7. Salir");
            Console.WriteLine("Ingrese una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el DNI: ");
                    int dni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el teléfono: ");
                    string telefono = Console.ReadLine();
                    string tipoCuenta;
                    do
                    {
                        Console.WriteLine("Ingrese el tipo de cuenta (Persona en Actividad o Jubilado): ");
                        tipoCuenta = Console.ReadLine();
                    } while (!(tipoCuenta.ToLower() == "persona en actividad laboral" || tipoCuenta.ToLower() == "jubilado"));

                    if (tipoCuenta.ToLower() == "persona en actividad laboral")
                    {
                        Persona persona = new Persona(dni, nombre, apellido, edad, telefono, "persona en actividad laboral");
                        Cuenta cuenta = new Cuenta(persona);

                        banco.cuentas.Add(cuenta);
                    }
                    else if (tipoCuenta.ToLower() == "jubilado")
                    {
                        Persona jubilado = new Persona(dni, nombre, apellido, edad, telefono, "jubilado");
                        Cuenta cuenta = new Cuenta(jubilado);
                        banco.cuentas.Add(cuenta);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese el DNI: ");
                    buscarDNI = Convert.ToInt32(Console.ReadLine());
                    foreach (Cuenta cuenta in banco.cuentas)
                    {
                        Persona duenioCuenta = cuenta.getDuenioCuenta();
                        if (duenioCuenta.getDni() == buscarDNI)
                        {
                            Console.WriteLine("El saldo de la cuenta es: " + cuenta.getSaldo());
                            break;
                        }

                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese el DNI: ");
                    buscarDNI = Convert.ToInt32(Console.ReadLine());
                    foreach (Cuenta cuenta in banco.cuentas)
                    {
                        Persona duenioCuenta = cuenta.getDuenioCuenta();
                        if (duenioCuenta.getDni() == buscarDNI)
                        {
                            duenioCuenta.Depositar(cuenta);
                        }

                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese el DNI: ");
                    buscarDNI = Convert.ToInt32(Console.ReadLine());
                    foreach (Cuenta cuenta in banco.cuentas)
                    {
                        Persona duenioCuenta = cuenta.getDuenioCuenta();
                        if (duenioCuenta.getDni() == buscarDNI)
                        {
                            Console.WriteLine("El saldo de la cuenta es: " + cuenta.getSaldo());

                            duenioCuenta.Retirar(cuenta);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingrese el DNI: ");
                    buscarDNI = Convert.ToInt32(Console.ReadLine());
                    foreach (Cuenta cuenta in banco.cuentas)
                    {
                        Persona duenioCuenta = cuenta.getDuenioCuenta();
                        if (duenioCuenta.getDni() == buscarDNI)
                        {
                            duenioCuenta.RetirarAdelanto(cuenta);
                        }
                    }

                    break;
                case 6:
                    banco.nuevoMes();
                    break;
                case 7:
                    return;
            }



        }

    }
}