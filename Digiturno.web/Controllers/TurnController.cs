using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Digiturno.web.Data;
using Digiturno.web.Data.Entities;

namespace Digiturno.web.Controllers
{
    public class TurnController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TurnController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult index()
        {
            return View();
        }

    }
}