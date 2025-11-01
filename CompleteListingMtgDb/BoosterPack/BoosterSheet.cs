namespace CompletemtgDatabase;

public class BoosterSheet {

    public bool? AllowDuplicates { get; set; }
    
    public bool? BalanceColors { get; set; }
    
    public Dictionary<string, int> Cards { get; set; }
    
    public bool Foil { get; set; }
    
    public bool? Fixed { get; set; }
    
    public int TotalWeight { get; set; }

}