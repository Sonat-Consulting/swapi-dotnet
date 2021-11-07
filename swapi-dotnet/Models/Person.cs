using System.Text.Json.Serialization;

namespace Swapi.Graphql.Dotnet.Services.Models
{
    public class Person
    {
        public Person(int id, PersonFields fields)
        {
            Id = id;
            Fields = fields;
        }

        [JsonPropertyName("pk")] public int Id { get; }
        public PersonFields Fields { get; }
    }

    public record PersonFields
    {
        public PersonFields(string name, string gender, string skinColor, string hairColor, string height, string eyeColor, string mass, int homeworld, string birthYear)
        {
            Name = name;
            Gender = gender;
            SkinColor = skinColor;
            HairColor = hairColor;
            Height = height;
            EyeColor = eyeColor;
            Mass = mass;
            Homeworld = homeworld;
            BirthYear = birthYear;
        }

        public string Name { get; }
        
        public string Gender { get; }

        [JsonPropertyName("skin_color")]
        public string SkinColor { get; }
        
        [JsonPropertyName("hair_color")]
        public string HairColor { get; }
        
        public string Height { get; }
        
        [JsonPropertyName("eye_color")]
        public string EyeColor { get; }
        
        public string Mass { get; }
        
        public int Homeworld { get; }
        
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; }
    }
}