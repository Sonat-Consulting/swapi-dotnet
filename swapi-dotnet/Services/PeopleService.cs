using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Swapi.Graphql.Dotnet.Services.Models;

namespace Swapi.Dotnet.Services
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetPeople();
    }
    
    public class PeopleService : EmbeddedResourceService, IPeopleService
    {
        private ILogger _logger;

        public PeopleService(ILogger<PeopleService> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<Person>> GetPeople()
        {
            _logger.LogInformation("Fetching people");
            _logger.LogWarning("Test warning while fetching people");
            return await LoadAndDeserializeResource<IEnumerable<Person>>("Data.people.json");
        }
    }
}