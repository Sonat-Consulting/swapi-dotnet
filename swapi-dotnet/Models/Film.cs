using System;
using System.Text.Json.Serialization;

namespace Swapi.Graphql.Dotnet.Services.Models
{
    public class Film
    {
        [JsonPropertyName("pk")]
        public int Id { get; set; }
        
        public FilmFields Fields { get; set; }
    }
    public class FilmFields
    {
        public int[] Starships { get; set; }
        
        public DateTime Edited { get; set; }
        
        public int[] Vehicles { get; set; }
        
        public int[] Planets { get; set; }
        
        public string Producer { get; set; }
        
        public string Title { get; set; }
        
        public DateTime Created { get; set; }
        
        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }
        
        public string Director { get; set; }
        
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
        
        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; }
        
        public int[] Characters { get; set; }
        
        public int[] Species { get; set; }
    }
}