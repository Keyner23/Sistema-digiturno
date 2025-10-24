using System.Diagnostics;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces.Repositories;
using Digiturno.web.Interfaces.Services;

namespace Digiturno.web.Services;

public class TurnService:ITurnService
{
    private readonly ITurnRepository _repositoryTurn;

    public TurnService(ITurnRepository repository)
    {
        _repositoryTurn = repository;
    }
    
    
    public List<Turn> ObtenerTurno()
    {
        return _repositoryTurn.GetAll();
    }
    
    
    public void CrearTurno(Turn nuevoTurno)
    {
        int ultimoNumero = _repositoryTurn.GetAll()
            .OrderByDescending(t => t.numeroTiket).Select(t => t.numeroTiket).FirstOrDefault();
        
        int siguienteNumero = ultimoNumero + 1;
        
        var nuevoturno = new Turn(
            numeroTiket: siguienteNumero, 
            fecha: DateOnly.FromDateTime(DateTime.Now)
        );
        _repositoryTurn.Add(nuevoturno);
    }
}