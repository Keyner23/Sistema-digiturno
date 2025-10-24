
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
        public IActionResult create(Affiliate afiliado)
        {
            if (ModelState.IsValid)
            {
                _service.CrearAfiliado(afiliado);
                return RedirectToAction(nameof(Index));
            }
            return View(afiliado);
        }
    }
}
