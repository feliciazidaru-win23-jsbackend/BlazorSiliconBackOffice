using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorSiliconBackOffice.Components.GraphQL;

public class GraphQlResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}

