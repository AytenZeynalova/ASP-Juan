using ASP_Juan.DAL;
using ASP_Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Juan.Controllers
{
    public class HomeController : Controller
    {
        private JuanDbContext _context;

        public HomeController(JuanDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                HomeSliderss = _context.HomeSliders.ToList(),
                Featuress =_context.Features.ToList(),
            };


            return View(homeViewModel);
        }
    }
}
