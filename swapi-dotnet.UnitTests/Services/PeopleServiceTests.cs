using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Swapi.Dotnet.Services;
using Xunit;

namespace swapi_dotnet.UnitTests.Services
{
    public class PeopleServiceTests
    {
        private readonly IPeopleService _peopleService;

        public PeopleServiceTests()
        {
            _peopleService = new PeopleService();
        }

        [Fact]
        public async Task GetPeople_ReturnsList_Success()
        {
            var people = (await _peopleService.GetPeople()).ToArray();
            
            people.Should().HaveCountGreaterThan(1);
            people[0].Id.Should().BeGreaterThan(0);
            people[0].Fields.Name.Should().NotBeNullOrEmpty();
        }
    }
}