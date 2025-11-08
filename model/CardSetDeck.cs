namespace CompletemtgDatabase;

// The Card (Set Deck) Data Model describes the properties of a single card found in a Deck (Set).

public class CardSetDeck
{

    public int Id { get; set; }

    public int Count { get; set; }

    public bool? IsFoil { get; set; }

    public string Uuid { get; set; } = string.Empty;

}