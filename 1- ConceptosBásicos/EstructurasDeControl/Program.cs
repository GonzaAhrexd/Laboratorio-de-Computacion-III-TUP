int numero = 10;

if (numero > 0)
{
    Console.WriteLine("Ingresa");
}
else
{
    Console.WriteLine("No ingresa");
}

switch (numero)
{
    case 0:
        Console.WriteLine("Ingresa al 0");
        break;
    case 1:
        Console.WriteLine("Ingresa al 1");
        break;
    case 2:
        Console.WriteLine("Ingresa al 2");
        break;
    case 3:
        Console.WriteLine("Ingresa al 3");
        break;
    default:
        Console.WriteLine("Valor no reconocido");
        break;
}

int contador = 0;
while (contador<3)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}

do
{
    Console.WriteLine("Contador " + contador);
    contador++;
} while (contador<3);

