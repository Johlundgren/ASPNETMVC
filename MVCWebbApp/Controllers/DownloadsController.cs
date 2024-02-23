using Microsoft.AspNetCore.Mvc;

namespace MVCWebbApp.Controllers
{
    public class DownloadsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Downloads";
            return View();
        }
    }
}
