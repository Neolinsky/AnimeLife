using Microsoft.AspNetCore.Mvc;

namespace AnimeLife.Controllers;

public class IndexPageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}