using Microsoft.AspNetCore.Mvc;

namespace Swapi.Dotnet.Controllers;

[ApiController]
[Route("/")]
public class DefaultController : ControllerBase
{
    [HttpGet]
    public string GetDefault()
    {
        return "Velkommen til Azure fagdag";
    }
}