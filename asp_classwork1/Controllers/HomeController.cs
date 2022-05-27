using asp_classwork1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_classwork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
    }
}
