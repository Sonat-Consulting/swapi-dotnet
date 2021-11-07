using System.Collections.Generic;
using System.Threading.Tasks;
using Swapi.Graphql.Dotnet.Services.Models;

namespace Swapi.Dotnet.Services
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetPeople();
    }
    
    public class PeopleService : EmbeddedResourceService, IPeopleService
    {
        public async Task<IEnumerable<Person>> GetPeople()
        {
            return await LoadAndDeserializeResource<IEnumerable<Person>>("Data.people.json");
        }
    }
}