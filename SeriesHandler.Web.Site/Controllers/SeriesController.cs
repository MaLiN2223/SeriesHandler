using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeriesHandler.Web.Site.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}