string nombre = "Juan";
string apellido = "Perez";

Console.WriteLine("Nombre: " + nombre + " Apellido: " + apellido);

int longitudNombre = nombre.Length;
Console.WriteLine("Longitud del nombre: " + longitudNombre);

string frase = "La facultad UTN es la mejor";
string palabra = "UTN";

// Contains devuelve un booleano si la palabra esta en la frase
bool contiene = frase.Contains(palabra);
Console.WriteLine(contiene);

// IndexOf devuelve el indice de la palabra en la frase
int indice = frase.IndexOf(palabra);
Console.WriteLine("Indice de la palabra: " + indice);

string fraseCambiada = frase.Replace("facultad", "universidad");
