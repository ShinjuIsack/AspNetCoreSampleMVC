using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebApplication.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string GetAllBooksGIT()
        {
            return "from book cntrlr";
        }
        public string GetAllBooksLocal()
        {
            return "from book cntrlr";
        }
        public string GetBooks()
        {
            return "from book cntrlr";
        }
    }
}
