namespace CompletemtgDatabase;

//The Deck (Set) Data Model describes the properties of an individual Deck within a Set.

public class DeckSet {

    public string code { get; set; }

    public List<CardSetDeck>? commander { get; set; }

    public List<CardSetDeck> mainBoard { get; set; }

    public string name {get; set;}

    public string? releaseDate {get; set;}

    public List<string>? sealedProductUuids {get; set;}

    public List<CardSetDeck> sideBoard;

    public string type {get; set;}
}