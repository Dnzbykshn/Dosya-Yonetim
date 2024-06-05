using Microsoft.AspNetCore.Mvc;

namespace dosya.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
