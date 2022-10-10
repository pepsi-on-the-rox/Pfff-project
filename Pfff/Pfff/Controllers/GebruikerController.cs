using Microsoft.AspNetCore.Mvc;

namespace Pfff.Controllers
{
    public class GebruikerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
