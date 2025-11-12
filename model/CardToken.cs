using System.ComponentModel.DataAnnotations.Schema;

namespace CompletemtgDatabase;

public class CardToken
{
    public int Id { get; set; }
    public string? Artist { get; set; }


    public string[]? ArtistIds { get; set; }

    public string? AsciiName { get; set; }

    public string[] Availability { get; set; } = [];

    public string[]? BoosterTypes { get; set; }

    public string BorderColor { get; set; } = string.Empty;


    public string[]? CardParts { get; set; }

    public string[] ColorIdentity { get; set; } = [];

    public string[]? ColorIndicator { get; set; }


    public string[] Colors { get; set; } = [];

    public double? EdhrecSaltiness { get; set; }

    public string? FaceName { get; set; }

    public string? FaceFlavorName { get; set; }


    public string[] Finishes { get; set; } = [];

    public string? FlavorName { get; set; }

    public string? FlavorText { get; set; }


    public string[]? FrameEffects { get; set; }

    public string FrameVersion { get; set; } = string.Empty;

    public bool HasFoil { get; set; }

    public bool HasNonFoil { get; set; }

    public Identifiers Identifiers { get; set; } = new Identifiers();

    public bool? IsFullArt { get; set; }

    public bool? IsFunny { get; set; }

    public bool? IsOnlineOnly { get; set; }

    public bool? IsOversized { get; set; }

    public bool? IsPromo { get; set; }

    public bool? IsReprint { get; set; }

    public bool? IsTextless { get; set; }

    public string[]? Keywords { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Layout { get; set; } = string.Empty;

    public string? Loyalty { get; set; }

    public string? ManaCost { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Number { get; set; } = string.Empty;

    public string? Orientation { get; set; }

    public string? OriginalText { get; set; }

    public string? OriginalType { get; set; }


    public string[]? OtherFaceIds { get; set; }

    public string? Power { get; set; }


    public string[]? PromoTypes { get; set; }

    public RelatedCards? RelatedCards { get; set; }

    public string[]? ReverseRelated { get; set; }

    public string? SecurityStamp { get; set; }

    public string SetCode { get; set; } = string.Empty;

    public string? Side { get; set; }

    public string? Signature { get; set; }

    public string[]? SourceProducts { get; set; }


    public string[]? Subsets { get; set; }


    public string[] Subtypes { get; set; } = [];


    public string[] Supertypes { get; set; } = [];

    public string? Text { get; set; }

    public string? Toughness { get; set; }

    public string Type { get; set; } = string.Empty;

    public string[] Types { get; set; } = [];

    public string Uuid { get; set; } = string.Empty;

    public string? Watermark { get; set; }
}
