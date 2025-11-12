namespace CompletemtgDatabase;

//The Deck (Set) Data Model describes the properties of an individual Deck within a Set.

public class DeckSet {

    public int Id { get; set; }

    public string Code { get; set; } = string.Empty;

    public CardSetDeck[]? Commander { get; set; }

    public CardSetDeck[] MainBoard { get; set; } =[];

    public string Name {get; set;} = string.Empty;

    public string? ReleaseDate {get; set;}

    public string[]? SealedProductUuids {get; set;}

    public CardSetDeck[] SideBoard { get; set; } = [];

    public string Type { get; set; } = string.Empty;
}