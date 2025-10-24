using Digiturno.web.Data.Entities;

namespace Digiturno.web.Interfaces.Services;

public interface IAffiliateService
{
    List<Affiliate> ObtenerAfiliados();
    void CrearAfiliado(Affiliate afiliado);
    bool EliminarAfiliadoPorDocumento(int documento); 
    Affiliate? GetById(int id);
}