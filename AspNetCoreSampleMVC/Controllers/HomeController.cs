using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        //added comment for SS_Aspnetcore
        public IActionResult Index()
        {
            return View();
        }
    }
}
