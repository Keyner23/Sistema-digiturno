namespace Digiturno.web.Data.Entities;

public class Turn
{
    public int id { get; set; }
    public int numeroTiket { get; set; }
    public DateOnly fecha { get; set; }

    public Turn(int id, int numeroTiket, DateOnly fecha)
    {
        this.id = id;
        this.numeroTiket = numeroTiket;
        this.fecha = fecha;
    }
}