namespace CompletemtgDatabase.cs;

public class BoosterSheet {

    public bool? allowDuplicates { get; set; }
    
    public bool? balanceColors { get; set; }
    
    public Dictonary<string, int> cards { get; set; }
    
    public bool foil { get; set; }
    
    public bool? fixed { get; set; }
    
    public int totalWeight { get; set; }

}