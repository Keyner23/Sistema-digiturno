using Digiturno.web.Data;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces.Repositories;

namespace Digiturno.web.Repository;

public class TurnRepository:ITurnRepository
{
    private readonly ApplicationDbContext _context;

    public TurnRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public List<Turn> GetAll()
    {
        return _context.Turnos.ToList();
    }
    
    public void Add(Turn nuevoTurno)
    {
        _context.Turnos.Add(nuevoTurno);
        _context.SaveChanges();
    }
}