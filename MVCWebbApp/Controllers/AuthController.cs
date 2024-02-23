using Microsoft.AspNetCore.Mvc;
using MVCWebbApp.ViewModels;

namespace MVCWebbApp.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if (!ModelState.IsValid)
             return View(viewModel);

        return RedirectToAction("SignIn", "Auth");
    }

}
