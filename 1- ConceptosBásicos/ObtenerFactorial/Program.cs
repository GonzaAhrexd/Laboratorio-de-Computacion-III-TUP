int obtenerFactorial(int num)
{
    if (num == 1)
    {
        return num;
    }
    else
    {
        return num * obtenerFactorial(num - 1);
    }
}


int aFactorear = int.Parse(Console.ReadLine());
int numeroFactoreado = obtenerFactorial(aFactorear);
Console.WriteLine(numeroFactoreado);

