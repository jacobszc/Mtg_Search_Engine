namespace CompletemtgDatabase;


public class BoosterConfig
{

public List<BoosterPack> Boosters {get; set;}

public int BoostersTotalWeight {get; set;}

public string? Name {get; set;}

public Dictionary<string, BoosterSheet> Sheets {get; set;}

public List<string> SourceSetCodes {get; set;}

    
}
