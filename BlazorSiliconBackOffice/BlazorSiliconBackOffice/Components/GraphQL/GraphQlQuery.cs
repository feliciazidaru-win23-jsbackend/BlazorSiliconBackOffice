using System.Text.Json.Serialization;

namespace BlazorSiliconBackOffice.Components.GraphQL;


    public class GraphQlQuery
    {
        public string Query { get; set; } = null!;

    [JsonPropertyName("variables")]
    public object Variables { get; set; } = null!;
}

