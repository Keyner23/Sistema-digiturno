using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Digiturno.web.Data;
using Digiturno.web.Data.Entities;
using Digiturno.web.Interfaces.Services;

namespace Digiturno.web.Controllers
{
    public class TurnController : Controller
    {
        private readonly ITurnService _service;

        public TurnController(ITurnService service)
        {
            _service = service;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult tomarTurno(Turn nuevoTurno)
        {
            _service.CrearTurno(nuevoTurno);
            return View("Create");
        }

    }
}