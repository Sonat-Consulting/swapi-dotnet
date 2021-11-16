using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swapi.Dotnet.Services;
using Swapi.Graphql.Dotnet.Services.Models;

namespace Swapi.Dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class SwapiController : ControllerBase
{
    private readonly IFilmsService _filmsService;
    private readonly IPeopleService _peopleService;

    public SwapiController(IFilmsService filmsService, IPeopleService peopleService)
    {
        _filmsService = filmsService;
        _peopleService = peopleService;
    }

    [HttpGet("films")]
    public async Task<IEnumerable<Film>> GetFilms()
    {
        return await _filmsService.GetFilms();
    }

    [HttpGet("people")]
    public async Task<IEnumerable<Person>> GetPeople()
    {
        return await _peopleService.GetPeople();
    }
}