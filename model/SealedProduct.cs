namespace CompletemtgDatabase;

public class SealedProduct {

    public int Id { get; set; }
    
    public int? CardCount { get; set; }

    public string? Category { get; set; }

    public SealedProductContents? Contents { get; set; }

    public Identifiers Identifiers { get; set; } = new Identifiers();

    public string Name { get; set; } = string.Empty;

    public int? ProductSize { get; set; }

    public PurchaceUrls PurchaceUrls { get; set; } = new PurchaceUrls();

    public string? ReleaseDate { get; set; }

    public string? Subtype { get; set; }

    public string Uuid { get; set; } = string.Empty;
}