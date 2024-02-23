using Microsoft.AspNetCore.Mvc;

namespace MVCWebbApp.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }

}
