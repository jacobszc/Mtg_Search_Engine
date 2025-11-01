namespace CompletemtgDatabase;

//The Deck (Set) Data Model describes the properties of an individual Deck within a Set.

public class DeckSet {

    public string Code { get; set; } = string.Empty;

    public List<CardSetDeck>? Commander { get; set; }

    public List<CardSetDeck> MainBoard { get; set; } = new();

    public string Name {get; set;} = string.Empty;

    public string? ReleaseDate {get; set;}

    public List<string>? SealedProductUuids {get; set;}

    public List<CardSetDeck> SideBoard { get; set; } = new();

    public string Type { get; set; } = string.Empty;
}