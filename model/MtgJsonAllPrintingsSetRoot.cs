using Newtonsoft.Json;

namespace CompletemtgDatabase;

public class MtgJsonAllPrintingsSetRoot
{
    [JsonProperty("meta")]
    public MtgJsonAllPrintingsSetMeta? Meta { get; set; }

    [JsonProperty("data")]
    public Set? Data { get; set; }
}