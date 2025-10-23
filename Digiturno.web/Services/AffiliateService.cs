using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces;
using Digiturno.web.Interfaces.Services;

namespace Digiturno.web.Services;

public class AffiliateService: IAffiliateService
{
    private readonly IAffiliateRepository _afiliadoRepository;

    public AffiliateService(IAffiliateRepository AffiliateRepository)
    {
        _afiliadoRepository = AffiliateRepository;
    }

    
    public List<Affiliate> ObtenerAfiliados()
    {
        return _afiliadoRepository.GetAll();
    }

   

    public void CrearAfiliado(Affiliate afiliado)
    {
        // Aquí podrías validar, por ejemplo, que no haya correos repetidos
        var existente = _afiliadoRepository.GetAll()
            .FirstOrDefault(a => a.Documento == afiliado.Documento);

        if (existente != null)
            throw new Exception("Ya existe un afiliado con ese correo.");

        _afiliadoRepository.Add(afiliado);
    }

 

}