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

        public string GetBooks()
        {
            return "from book cntrlr";
        }
        public string GetBookByID(int id)
        {
            //return "book with id=" + id;
            return $"book with id= {id}";
        }
    }
}
