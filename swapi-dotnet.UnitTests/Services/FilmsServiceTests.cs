using System.Linq;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Swapi.Dotnet.Services;
using Xunit;

namespace swapi_dotnet.UnitTests.Services
{
    public class FilmsServiceTests
    {
        private IFilmsService _filmsService;

        public FilmsServiceTests()
        {
            _filmsService = new FilmsService(A.Fake<ILogger<FilmsService>>());
        }

        [Fact]
        public async Task GetFilms_ReturnsList_Success()
        {
            var films = (await _filmsService.GetFilms()).ToArray();
            
            films.Should().HaveCountGreaterThan(1);
            films[0].Id.Should().BeGreaterThan(0);
            films[0].Fields.EpisodeId.Should().BeGreaterThan(0);
            films[0].Fields.Planets.Should().NotBeNullOrEmpty();
        }
    }
}