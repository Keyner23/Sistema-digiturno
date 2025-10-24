
using Microsoft.AspNetCore.Mvc;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces.Services;


namespace Digiturno.web.Controllers
{
    public class AffiliateController : Controller
    
    {
        private readonly IAffiliateService _service;

        public AffiliateController(IAffiliateService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var afiliados = _service.ObtenerAfiliados();
            return View(afiliados);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Affiliate afiliado)
        {
            try
            {
                _service.CrearAfiliado(afiliado);
                TempData["SuccessMessage"] = "Afiliado creado exitosamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $" {ex.Message}";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(int documento)
        {
            if (documento <= 0)
            {
                TempData["ErrorMessage"] = "Debe ingresar un documento válido.";
                return RedirectToAction("Index");
            }

            var eliminado = _service.EliminarAfiliadoPorDocumento(documento);

            if (!eliminado)
            {
                TempData["ErrorMessage"] = $"No se encontró un afiliado con el documento '{documento}'.";
                return RedirectToAction("Index");
            }

            TempData["SuccessMessage"] = "Afiliado eliminado correctamente.";
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var afiliado = _service.GetById(id);

            if (afiliado == null)
            {
                TempData["ErrorMessage"] = "No se encontró el afiliado.";
                return RedirectToAction("Index");
            }

            return View(afiliado);
        }


        
    }
}
