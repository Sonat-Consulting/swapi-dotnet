using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swapi.Dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class SecretController : ControllerBase
{
    private readonly IAppConfiguration _appConfiguration;

    public SecretController(IAppConfiguration appConfiguration)
    {
        _appConfiguration = appConfiguration;
    }

    [HttpGet]
    public string GetSecretValue()
    {
        return _appConfiguration.MySecret;
    }
}