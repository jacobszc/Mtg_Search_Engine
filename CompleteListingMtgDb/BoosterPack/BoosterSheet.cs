namespace CompletemtgDatabase;

public class BoosterSheet {

    public bool? allowDuplicates { get; set; }
    
    public bool? balanceColors { get; set; }
    
    public Dictionary<string, int> cards { get; set; }
    
    public bool foil { get; set; }
    
    public bool? Fixed { get; set; }
    
    public int totalWeight { get; set; }

}