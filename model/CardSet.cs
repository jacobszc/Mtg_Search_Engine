namespace CompletemtgDatabase;
using System.ComponentModel.DataAnnotations.Schema;

public class CardSet
{
    public int Id { get; set; }

    public string? Artist { get; set; }

    public string[]? ArtistIds { get; set; }

    public string? AsciiName { get; set; }

    public int[]? AttractionLights { get; set; }


    public string[] Availability { get; set; } = [];


    public string[]? BoosterTypes { get; set; }

    public string BorderColor { get; set; } = string.Empty;


    public string[]? CardParts { get; set; }

    public string[] ColorIdentity { get; set; } = [];

    public string[]? ColorIndicator { get; set; }


    public string[] Colors { get; set; } = [];

    public double ManaValue { get; set; }

    public string? Defense { get; set; }

    public string? DuelDeck { get; set; }

    public int? EdhrecRank { get; set; }

    public double? EdhrecSaltiness { get; set; }

    public string? FaceFlavorName { get; set; }

    public double? FaceManaValue { get; set; }

    public string? FaceName { get; set; }


    public string[] Finishes { get; set; } = [];

    public string? FlavorName { get; set; }

    public string? FlavorText { get; set; }


    public ForeignData[]? ForeignData { get; set; }


    public string[]? FrameEffects { get; set; }

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


    public string[]? Keywords { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Layout { get; set; } = string.Empty;

    public LeadershipSkills? LeadershipSkills { get; set; }

    public Legalities Legalities { get; set; } = new();

    public string? Life { get; set; }

    public string? Loyalty { get; set; }

    public string? ManaCost { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Number { get; set; } = string.Empty;


    public string[]? OriginalPrintings { get; set; }

    public string? OriginalReleaseDate { get; set; }

    public string? OriginalText { get; set; }

    public string? OriginalType { get; set; }


    public string[]? OtherFaceIds { get; set; }

    public string? Power { get; set; }


    public string[]? Printings { get; set; }


    public string[]? PromoTypes { get; set; }

    public PurchaceUrls PurchaceUrls { get; set; } = new();

    public string Rarity { get; set; } = string.Empty;

    [NotMapped]
    public string[]? RebalancedPrintings { get; set; }

    [NotMapped]
    public Rulings[]? Rulings { get; set; }

    public string? SecurityStamp { get; set; }

    public string SetCode { get; set; } = string.Empty;

    public string? Side { get; set; }

    public string? Signature { get; set; }

    public SourceProducts? SourceProducts { get; set; }

    [NotMapped]
    public string[]? Subsets { get; set; }

    [NotMapped]
    public string[] Subtypes { get; set; } = [];

    [NotMapped]
    public string[] Supertypes { get; set; } = [];

    public string? Text { get; set; }

    public string? Toughness { get; set; }

    public string Type { get; set; } = string.Empty;

    public string[] Types { get; set; } = [];

    public string Uuid { get; set; } = string.Empty;


    public string[]? Variations { get; set; }

    public string? Watermark { get; set; }


}