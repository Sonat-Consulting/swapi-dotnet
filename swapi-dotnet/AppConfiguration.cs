using Microsoft.Extensions.Configuration;

namespace Swapi.Dotnet;

public interface IAppConfiguration
{
    string MySecret { get; }
}

public class AppConfiguration : IAppConfiguration
{
    private readonly IConfiguration _configuration;
    
    public AppConfiguration(IConfiguration configuration)
    { 
        _configuration = configuration;
    }
    
    public string MySecret => _configuration.GetValue<string>("Secrets:MySecret");
}