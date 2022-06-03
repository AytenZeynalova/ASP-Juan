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
        public SliderController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
