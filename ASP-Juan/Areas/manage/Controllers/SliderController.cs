using ASP_Juan.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Juan.Areas.manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly JuanDbContext _context;

        public SliderController( JuanDbContext context)
        {
            _context = context;
        }
        public IActionResult Slider()
        {
            var data = _context.HomeSliders.ToList();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
