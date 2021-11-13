using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Swapi.Graphql.Dotnet.Services.Models;

namespace Swapi.Dotnet.Services
{
    public interface IFilmsService
    {
        public Task<IEnumerable<Film>> GetFilms();
        
        
    }
    
    public class FilmsService : EmbeddedResourceService, IFilmsService
    {
        private ILogger _logger;

        public FilmsService(ILogger<FilmsService> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<Film>> GetFilms() => await LoadAndDeserializeResource<IEnumerable<Film>>("Data.films.json");
    }
}