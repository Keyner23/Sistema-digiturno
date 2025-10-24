using Digiturno.web.Data;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Digiturno.web.Repository;
using Digiturno.web.Interfaces.Repositories;
public class AffiliateRepository : IAffiliateRepository
{
    private readonly ApplicationDbContext _context;

    public AffiliateRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public List<Affiliate> GetAll()
    {
        return _context.Afiliados.ToList();
    }
    
    public void Add(Affiliate afiliado)
    {
        _context.Afiliados.Add(afiliado);
        _context.SaveChanges();
    }

    public bool DeleteByDocumento(int documento)
    {
        var afiliado = _context.Afiliados.FirstOrDefault(a => a.Documento == documento);
        if (afiliado == null)
            return false;

        _context.Afiliados.Remove(afiliado);
        _context.SaveChanges();
        return true;;
    }

    
    public Affiliate? GetById(int id)
    {
        return _context.Afiliados.FirstOrDefault(a => a.id == id);
    }
}