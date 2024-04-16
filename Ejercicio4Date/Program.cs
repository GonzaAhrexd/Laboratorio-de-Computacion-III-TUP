/*
 * Realice un programa que solicite el primer día de cada uno de los doce meses del año. Con esta información podrá pedir al sistema que dada una determinada 
 * fecha el mismo le indique que día será. El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes.
 * */

Console.WriteLine("Hola");

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

String calcularDia(int day, String diaFecha, String[] DiasSemana){
    int dayIterator = Array.IndexOf(DiasSemana, diaFecha);
    int dayRunning = 0;
    while (dayIterator < 7 && dayRunning<=day){
        

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
        Console.WriteLine("DiaSemana: " +  dayIterator + "- Día: " + dayRunning);

    }

    return DiasSemana[dayIterator];
}


bool esUnDia(String dia, String[] DiasSemana)
{

    bool wasFinded = false;

    for (int i = 0; i<7; i++){

        if(dia.ToLower() == DiasSemana[i].ToLower()){
            wasFinded = true;
        }
        }
    return wasFinded;
}

String fechasFinDeSemana(int day, String diaFecha, String[] DiasSemana)
{
    int dayIterator = Array.IndexOf(DiasSemana, diaFecha);
    int dayRunning = 0;
    String finDeSemana = "";

    while (dayIterator < 7 && dayRunning<=day)
    {

        dayIterator++;
        if (dayIterator == 6)
        {
            finDeSemana = finDeSemana + dayRunning + ",";
        }

        if (dayIterator == 7)
        {
            finDeSemana = finDeSemana + dayRunning + ",";
            dayIterator = 0;
        }
        dayRunning++;
        if (dayRunning == 31)
        {
            break;

        }
        Console.WriteLine("DiaSemana: " +  dayIterator + "- Día: " + dayRunning);
    }
    return finDeSemana;

    

}
String[] DiasSemana = ["Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"];
String[] diasMeses =  new String[12];

int i = 0;
    while (i<12) {
    Console.WriteLine("Ingrese el primer día del mes " + (i+1) + ": ");
    diasMeses[i] = "";
    while (!esUnDia(diasMeses[i], DiasSemana))
    {
        diasMeses[i] = Console.ReadLine();
        if (!esUnDia(diasMeses[i], DiasSemana))
        {
            Console.WriteLine("Ingrese un día válido");
        }

    }
    i++;    
}

    Console.WriteLine("Ingrese el día que desea saber: ");
    int dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el mes: ");
    String mes = Console.ReadLine();
    

     Console.WriteLine(calcularDia(dia, diasMeses[convertirMes(mes)-1], DiasSemana));

Console.WriteLine("Los fin de semana del  mes seleccionado son: " +  fechasFinDeSemana(31, diasMeses[convertirMes(mes)-1], DiasSemana)); 