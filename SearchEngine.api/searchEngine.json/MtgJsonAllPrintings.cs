
using Newtonsoft.Json;

namespace CompletemtgDatabase;

public class MtgJsonAllPrintingsFile
{
    [JsonProperty("meta")]
    public required MtgJsonAllPrintingsSetMeta Meta { get; set; }

    [JsonProperty("data")]
    public Dictionary<string, Set> Sets { get; set; } = new Dictionary<string, Set>();
}