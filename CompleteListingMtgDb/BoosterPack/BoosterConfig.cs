namespace CompletemtgDatabase;


public class BoosterConfig
{

public List<BoosterPack> boosters {get; set;}

public int boostersTotalWeight {get; set;}

public string? name {get; set;}

public Dictionary<string, BoosterSheet> sheets {get; set;}

public List<string> sourceSetCodes {get; set;}

    
}
