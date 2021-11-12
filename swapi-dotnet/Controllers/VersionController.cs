using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Swapi.Dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public string GetVersion()
        {
            return Assembly.GetEntryAssembly()?.GetName().Version?.ToString();
        }
    }
}