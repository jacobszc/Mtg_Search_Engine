namespace CompletemtgDatabase;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class Set
{

    public int Id { get; set; }
    public int BaseSetSize { get; set; }
    
    public string? Block { get; set; }
    
    [NotMapped]
    public Dictionary<string, BoosterConfig>? Booster { get; set; } // booster is the name of the object and it a dictorany that maps a string to a confi and it may be null
    
    
    public List<CardSet> Cards { get; set; } = new List<CardSet>();
    
    public int? CardsphereSetId { get; set; }
    
    public string Code { get; set; } = string.Empty;
    
    public string? CodeV3 { get; set; }
    

    [NotMapped]
    public DeckSet[]? Decks { get; set; }
    
    public bool? IsForeignOnly { get; set; }
    
    public bool IsFoilOnly { get; set; }
    
    public bool? IsNonFoilOnly { get; set; }
    
    public bool IsOnlineOnly { get; set; }
    
    public bool? IsPaperOnly { get; set; }
    
    public bool? IsPartialPreview { get; set; }
    
    public string KeyruneCode { get; set; } = string.Empty;
    
    [JsonIgnore]
    [NotMapped]
     public string[] Languages { get; set; } = Array.Empty<string>();
    
    public int? McmId { get; set; }
    
    public int? McmIdExtras { get; set; }
    
    public string? McmName { get; set; }
    
    public string? MtgoCode { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string? ParentCode { get; set; }
    
    public string ReleaseDate { get; set; } = string.Empty;
    
    [NotMapped]
    public SealedProduct[]? SealedProduct { get; set; }
    
    public int? TcgplayerGroupId { get; set; }
    [NotMapped]
    public CardToken[] Tokens { get; set; } = Array.Empty<CardToken>();
    
    public string? TokenSetCode { get; set; }
    
    public int TotalSetSize { get; set; }
    
    public Translations Translations { get; set; } = new();
    
    public string Type { get; set; } = string.Empty;

}