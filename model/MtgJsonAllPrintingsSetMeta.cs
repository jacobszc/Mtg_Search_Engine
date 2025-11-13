using Newtonsoft.Json;

namespace CompletemtgDatabase;

public class MtgJsonAllPrintingsSetMeta
{
    [JsonProperty("date")]
    public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");

    [JsonProperty("version")]
    public string Version { get; set; } = "unknown";
}