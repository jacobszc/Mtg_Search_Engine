using System.ComponentModel.DataAnnotations.Schema;

namespace CompletemtgDatabase;


public class BoosterConfig
{


   public int Id { get; set; }
    public List<BoosterPack> Boosters { get; set; } = new();

public int BoostersTotalWeight {get; set;}

public string? Name {get; set;}

   [NotMapped]
   public Dictionary<string, BoosterSheet> Sheets { get; set; } = new();

public List<string> SourceSetCodes { get; set; } = new();

    
}
