using Microsoft.AspNetCore.Mvc;

namespace AnimeLife.Controllers;

public class IndexPageController : Controller
{
    private readonly IConfiguration _configuration;

    public IndexPageController(IConfiguration configuration)
    {
        _configuration = configuration;
        var connString = _configuration.GetSection("Database:Connection").Value;
        var i = 1;
    }

    [HttpGet]
    [Route("/")]
    public string Index()
        => "Hello World!";
}