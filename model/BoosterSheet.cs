namespace CompletemtgDatabase;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class BoosterSheet {

    public int Id { get; set; }

    public bool? AllowDuplicates { get; set; }
    
    public bool? BalanceColors { get; set; }

    [JsonIgnore]
    [NotMapped]
    public Dictionary<string, int> Cards { get; set; } = new();
    
    public bool Foil { get; set; }
    
    public bool? Fixed { get; set; }
    [JsonIgnore]
    public int TotalWeight { get; set; }

}