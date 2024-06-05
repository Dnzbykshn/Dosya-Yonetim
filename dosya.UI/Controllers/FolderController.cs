using Microsoft.AspNetCore.Mvc;

namespace dosya.UI.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
