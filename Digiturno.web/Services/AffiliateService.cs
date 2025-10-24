using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces;
using Digiturno.web.Interfaces.Services;

namespace Digiturno.web.Services;
using Digiturno.web.Interfaces.Repositories;
public class AffiliateService:IAffiliateService

    {
        private readonly IAffiliateRepository _repository;

        public AffiliateService(IAffiliateRepository repository)
        {
            _repository = repository;
        }

        public List<Affiliate> ObtenerAfiliados()
        {
            return _repository.GetAll();
        }

        public void CrearAfiliado(Affiliate afiliado)
        {
            _repository.Add(afiliado);
        }
    }
 

