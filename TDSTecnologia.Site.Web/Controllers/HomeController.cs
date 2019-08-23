﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TDSTecnologia.Site.Infrastructure;

namespace TDSTecnologia.Site.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContexto _context;

        public HomeController(AppContexto context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.CursoDao.ToListAsync());
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
    }
}
