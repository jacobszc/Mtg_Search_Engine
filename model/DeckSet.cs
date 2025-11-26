namespace CompletemtgDatabase;

//The Deck (Set) Data Model describes the properties of an individual Deck within a Set.

public class DeckSet {

    public int Id { get; set; }

    public string Code { get; set; } = string.Empty;

    public List<CardSetDeck>? Commander { get; set; }

    public List<CardSetDeck> MainBoard { get; set; } =new List<CardSetDeck>();

    public string Name {get; set;} = string.Empty;

    public string? ReleaseDate {get; set;}

    public string[]? SealedProductUuids {get; set;}

    public List<CardSetDeck> SideBoard { get; set; } = new List<CardSetDeck>();

    public string Type { get; set; } = string.Empty;
}