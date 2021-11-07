using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Swapi.Dotnet.Services
{
    public abstract class EmbeddedResourceService
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        protected EmbeddedResourceService()
        {
            _jsonSerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        }

        protected async Task<T> LoadAndDeserializeResource<T>(string resourceName)
        {
            var resource = LoadResource(resourceName);

            return await JsonSerializer.DeserializeAsync<T>(resource, _jsonSerializerOptions);
        }
        
        private Stream LoadResource(string name)
        {
            var dataStream = GetType().Assembly.GetManifestResourceStream(GetType(), name);
            if (dataStream == null)
                throw new Exception($"Could not load data file {name}");


            return dataStream;
        }
        
    }
}