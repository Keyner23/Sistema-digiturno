using Digiturno.web.Models;

namespace Digiturno.web.Data.Entities;

public class Affiliate:Person
{
    public int id { get; set; }
    public string direccion { get; set; }
    
    public Affiliate() {}
    
    public Affiliate( int id,string nombre, int documento, int telefono, string direccion) 
        : base(nombre, documento, telefono)
    {
        this.id = id;
        this.direccion = direccion;
    }
}