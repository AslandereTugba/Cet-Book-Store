using CetBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CetBookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Book  book= new Book();

            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
