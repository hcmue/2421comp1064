using Microsoft.AspNetCore.Mvc;

namespace Buoi04.Controllers;

public class DemoController : Controller
{
    public IActionResult Layout()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}