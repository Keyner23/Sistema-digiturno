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
            var exist = _repository.GetAll()
                .FirstOrDefault(a => a.Documento == afiliado.Documento);

            if (exist != null)
            {
                throw new Exception("Ya existe un afiliado con este documento.");
            }
            _repository.Add(afiliado);
        }


        public bool EliminarAfiliadoPorDocumento(int documento)
        {
            return _repository.DeleteByDocumento(documento);
        }

      
        
        public Affiliate? GetById(int id) => _repository.GetById(id);
    }
 

