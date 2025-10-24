using Digiturno.web.Data.Entities;

namespace Digiturno.web.Interfaces.Services;

public interface ITurnService
{
    List<Turn> ObtenerTurno();
    void CrearTurno(Turn nuevoTurno);
}