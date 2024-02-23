using Microsoft.AspNetCore.Mvc;
using MVCWebbApp.Models.Views;

namespace MVCWebbApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        var viewModel = new HomeIndexViewModel();
        ViewData["Title"] = viewModel.Title;

        return View(viewModel);
    }
}
