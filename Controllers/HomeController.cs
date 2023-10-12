using Microsoft.AspNetCore.Mvc;
using Trellol.Models;

namespace Trellol.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
