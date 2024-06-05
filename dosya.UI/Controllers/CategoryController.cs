using Microsoft.AspNetCore.Mvc;

namespace dosya.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
