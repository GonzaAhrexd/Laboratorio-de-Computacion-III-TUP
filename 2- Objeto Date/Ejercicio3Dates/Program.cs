/*
 * Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes de marzo de 2022 fue un martes.
 * Luego con esta información el sistema debe poder calcular que día será, el correspondiente a una fecha dada.
 * Por lo cual el sistema podría preguntar, ingrese una fecha del mes de marzo y le diré que día cae.
 */
String[] DiasSemana = ["Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"];
int convertirMes(String mes)
{
    //Meses del año en un array
    String[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

    for(int i = 0; i<12; i++)
    {
        if(mes.ToLower() == meses[i])
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

    for(int i = 0; i<7; i++)
    {
        if(day.ToLower() == EnglishDays[i])
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
    while(dayIterator < 7 && dayRunning<=day)
    {


        dayIterator++;

        if(dayIterator == 7)
        {
            dayIterator = 0;
        }
        dayRunning++;
        if(dayRunning == day)
        {
            break;

        }

    }

    return DiasSemana[dayIterator];
}


Console.WriteLine("Ingrese el año: ");
int year = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el mes al que pertenece: ");
String month = Console.ReadLine();

DateTime date = new DateTime(year, convertirMes(month), 1);
Console.WriteLine(date.DayOfWeek.ToString());
String diaFecha = convertirDiaSp(date.DayOfWeek.ToString(), DiasSemana);

Console.WriteLine("Ingrese un día del mes de "  + month + " para saber qué día cayó: ");
int day = int.Parse(Console.ReadLine());

Console.WriteLine("El día que cayó fue: ");
Console.WriteLine(calcularDia(day, diaFecha, DiasSemana));

