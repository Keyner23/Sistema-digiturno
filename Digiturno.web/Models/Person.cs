namespace Digiturno.web.Models;

public abstract class Person
{
    public string Nombre { get; set; }
    public int Documento { get; set; }
    public int Telefono { get; set; }

    
    protected Person(string nombre, int documento, int telefono)
    {
        Nombre = nombre;
        Documento = documento;
        Telefono = telefono;
    }
}

