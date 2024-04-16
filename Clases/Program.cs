class Persona{
    private string nombre;
    private string telefono;
    private string direccion;
    
    public Persona(string nombre, string telefono, string direccion){
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion;
    }

    public void mostrar(Persona persona){
        Console.WriteLine("Nombre: {" +  persona.nombre + "}teléfono: {" + persona.telefono + "}" + persona.direccion); 
    }




}