
public class Persona()
{
    public virtual void saludar()
    {
        Console.WriteLine("Hola");
    }
}

public class Estudiante : Persona
{
    public override void saludar()
    {
        Console.WriteLine("¡Hola, profesor!");
    }
}

class Program
{
    static void main(string[] args)
    {

Persona persona = new Estudiante();
persona.saludar(); 
    }
}