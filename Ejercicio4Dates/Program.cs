/*
 * Realice un programa que solicite el primer día de cada uno de los doce meses del año. Con esta información podrá pedir al sistema que dada una determinada 
 * fecha el mismo le indique que día será. El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes.
 * */

Console.WriteLine("Hola");

/*
int convertirMes(String mes)
{
    //Meses del año en un array
    String[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

    for (int i = 0; i<12; i++)
    {
        if (mes.ToLower() == meses[i])
        {
            return i+1;
        }
    }

    return 0;
}

String convertirDiaSp(String day, String[] DiasSemana)
{
    String[] EnglishDays = ["monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];
    String[] SpanishDays = DiasSemana;

    for (int i = 0; i<7; i++)
    {
        if (day.ToLower() == EnglishDays[i])
        {
            return SpanishDays[i];
        }
    }

    return null;
}

String calcularDia(int day, String diaFecha, String[] DiasSemana)
{
    int dayIterator = Array.IndexOf(DiasSemana, diaFecha);
    int dayRunning = 1;
    while (dayIterator < 7 && dayRunning<=day)
    {


        dayIterator++;

        if (dayIterator == 7)
        {
            dayIterator = 0;
        }
        dayRunning++;
        if (dayRunning == day)
        {
            break;

        }
        Console.WriteLine(dayIterator + "-" + dayRunning);

    }

    return DiasSemana[dayIterator];
}

/*
bool esUnDia(String dia, String[] DiasSemana)
{
    for (int i = 0; i<7; i++)
    {
        if (dia.ToLower() == DiasSemana[i].ToLower())
        {
            return true;
        }
    }

    return false;
}

String[] DiasSemana = ["Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"];
//String[] diasMeses =  new String[12];

/*
for (int i = 0; i<12; i++)
{
    Console.WriteLine("Ingrese el primer día del mes " + (i+1) + ": ");
    while (!esUnDia(diasMeses[i], DiasSemana))
    {
        diasMeses[i] = Console.ReadLine();
        if (!esUnDia(diasMeses[i], DiasSemana))
        {
            Console.WriteLine("El día ingresado no es válido. Por favor, ingrese un día válido.");
        }
    }
    diasMeses[i] = Console.ReadLine();
}


*/