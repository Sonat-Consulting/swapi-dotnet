using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swapi.Dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class ErrorController : ControllerBase
{
    [HttpGet]
    public Task GetAnError()
    {
        throw new Exception("Ouch, something terrible happened!");
    }
}