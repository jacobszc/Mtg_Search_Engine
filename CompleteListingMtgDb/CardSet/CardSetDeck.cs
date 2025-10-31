namespace CompletemtgDatabase;

// The Card (Set Deck) Data Model describes the properties of a single card found in a Deck (Set).

public class CardSetDeck {

    public int count {get; set;}

    public bool? isFoil {get; set;}

    public string uuid {get; set;}
}