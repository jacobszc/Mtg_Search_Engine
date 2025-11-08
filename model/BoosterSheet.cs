namespace CompletemtgDatabase;
using System.ComponentModel.DataAnnotations.Schema;

public class BoosterSheet {

    public int Id { get; set; }

    public bool? AllowDuplicates { get; set; }
    
    public bool? BalanceColors { get; set; }

    [NotMapped]
    public Dictionary<string, int> Cards { get; set; } = new();
    
    public bool Foil { get; set; }
    
    public bool? Fixed { get; set; }
    
    public int TotalWeight { get; set; }

}