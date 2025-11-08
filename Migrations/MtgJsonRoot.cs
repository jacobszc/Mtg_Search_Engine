using System.Text.Json.Serialization;

namespace CompletemtgDatabase;


public class MtgJsonRoot
{
    public Meta Meta { get; set; } = new();

    [JsonIgnore]

    public Dictionary<string, Set> Data { get; set; } = new();

}