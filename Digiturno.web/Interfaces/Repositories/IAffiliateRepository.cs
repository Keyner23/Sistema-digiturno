using Digiturno.web.Data.Entities;

namespace Digiturno.web.Interfaces.Repositories;

public interface IAffiliateRepository
{
    List<Affiliate> GetAll();
    void Add(Affiliate afiliado);
    bool DeleteByDocumento(int documento);
    Affiliate? GetById(int id);
}