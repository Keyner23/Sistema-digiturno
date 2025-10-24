using Digiturno.web.Data.Entities;

namespace Digiturno.web.Interfaces.Repositories;

public interface ITurnRepository
{
    List<Turn> GetAll();
    void Add(Turn nuevoTurno);
}