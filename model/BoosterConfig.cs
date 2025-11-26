using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CompletemtgDatabase;


public class BoosterConfig
{


   public int Id { get; set; }

    public BoosterPack[] Boosters { get; set; } = Array.Empty<BoosterPack>();

    public int BoostersTotalWeight {get; set;}

    public string? Name {get; set;}

   [NotMapped]
   public Dictionary<string, BoosterSheet> Sheets { get; set; } = new();
   [JsonIgnore]
   public string[] SourceSetCodes { get; set; } = Array.Empty<string>();

    
}
