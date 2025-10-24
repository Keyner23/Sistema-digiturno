namespace Digiturno.web.Data.Entities;

public class Turn
{
    public Guid id { get; set; }
    public int numeroTiket { get; set; }
    public DateOnly fecha { get; set; }

    public Turn( int numeroTiket, DateOnly fecha)
    {   id=Guid.NewGuid();
        this.numeroTiket = numeroTiket;
        this.fecha = fecha;
    }
    public Turn() { }
}