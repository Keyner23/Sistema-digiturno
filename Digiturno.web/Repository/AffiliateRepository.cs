using Digiturno.web.Data;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces;

namespace Digiturno.web.Repository;

public class AffiliateRepository : IAffiliateRepository
{
    private readonly ApplicationDbContext _context;

    public AffiliateRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    //Metodo para traer todos los afiliados
    public List<Affiliate> GetAll()
    {
        return _context.Afiliados.ToList();
    }
    
    // Metodo para agregar un afiliado
    public void Add(Affiliate afiliado)
    {
        _context.Afiliados.Add(afiliado);
        _context.SaveChanges();
    }
}