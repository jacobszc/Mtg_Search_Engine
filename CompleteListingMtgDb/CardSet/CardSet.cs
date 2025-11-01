namespace CompletemtgDatabase;

//The Card (Set) Data Model describes the properties of a single card found in a Set.

public class CardSet {

    public string? Artist { get; set; }
    
    public List<string>? ArtistIds { get; set; }
    
    public string? AsciiName { get; set; }
    
    public List<int>? AttractionLights { get; set; }
    
    public List<string> Availability { get; set; } = new(); // must use new to init a new empty list withouth making it null
    
    public List<string>? BoosterTypes { get; set; }
   
    public string BorderColor { get; set; } = string.Empty;
    
    public List<string>? CardParts { get; set; }
   
    public List<string> ColorIdentity { get; set; } = new();
   
    public List<string>? ColorIndicator { get; set; }
   
    public List<string> Colors { get; set; } = new();
    
    public double ManaValue { get; set; }
    
    public string? Defense { get; set; }
    
    public string? DuelDeck { get; set; }
    
    public int? EdhrecRank { get; set; }
    
    public double? EdhrecSaltiness { get; set; }
    
    //public double? FaceConvertedManaCost { get; set; }
    
    public string? FaceFlavorName { get; set; }
    
    public double? FaceManaValue { get; set; }
    
    public string? FaceName { get; set; }
    
    public List<string> Finishes { get; set; } = new();
    
    public string? FlavorName { get; set; }
    
    public string? FlavorText { get; set; }
    
    public List<ForeignData>? ForeignData { get; set; }
    
    public List<string>? FrameEffects { get; set; }
    
    public string FrameVersion { get; set; } = string.Empty;
    
    public string? Hand { get; set; }
    
    public bool? HasAlternativeDeckLimit { get; set; }
    
    public bool? HasContentWarning { get; set; }
    public Identifiers Identifiers { get; set; } = new();
    
    public bool? IsAlternative { get; set; }
    
    public bool? IsFullArt { get; set; }
    
    public bool? IsFunny { get; set; }
    
    public bool? IsGameChanger { get; set; }
    
    public bool? IsOnlineOnly { get; set; }
    
    public bool? IsOversized { get; set; }
    
    public bool? IsPromo { get; set; }
    
    public bool? IsRebalanced { get; set; }
    
    public bool? IsReprint { get; set; }
    
    public bool? IsReserved { get; set; }
    
    public bool? IsStarter { get; set; }
    
    public bool? IsStorySpotlight { get; set; }
    
    public bool? IsTextless { get; set; }
    
    public bool? IsTimeshifted { get; set; }
    
    public List<string>? Keywords { get; set; }
    
    public string Language { get; set; } = string.Empty;
    
    public string Layout { get; set; } = string.Empty;
    
    public LeadershipSkills? LeadershipSkills { get; set; }
    
    public Legalities Legalities { get; set; } = new();
    
    public string? Life { get; set; }
    
    public string? Loyalty { get; set; }
    
    public string? ManaCost { get; set; }
    
    //public double ManaValue { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Number { get; set; } = string.Empty;
    
    public List<string>? OriginalPrintings { get; set; }
    
    public string? OriginalReleaseDate { get; set; }
    
    public string? OriginalText { get; set; }
    
    public string? OriginalType { get; set; }
    
    public List<string>? OtherFaceIds { get; set; }
    
    public string? Power { get; set; }
    
    public List<string>? Printings { get; set; }
    
    public List<string>? PromoTypes { get; set; }
    
    public PurchaseUrls PurchaseUrls { get; set; } = new();
    
    public string Rarity { get; set; } = string.Empty;
   
    public List<string>? RebalancedPrintings { get; set; }
    
    public List<Rulings>? Rulings { get; set; }
    
    public string? SecurityStamp { get; set; }
    
    public string SetCode { get; set; } = string.Empty;
    
    public string? Side { get; set; }
    
    public string? Signature { get; set; }
    
    public SourceProducts? SourceProducts { get; set; }
    
    public List<string>? Subsets { get; set; }
    
    public List<string> Subtypes { get; set; } = new();
    
    public List<string> Supertypes { get; set; } = new();
    
    public string? Text { get; set; }
    
    public string? Toughness { get; set; }
    
    public string Type { get; set; } = string.Empty;
    
    public List<string> Types { get; set; } = new();
    
    public string Uuid { get; set; } = string.Empty;
    
    public List<string>? Variations { get; set; }
    
    public string? Watermark { get; set; }
}