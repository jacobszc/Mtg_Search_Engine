namespace CompletemtgDatabase;

public class ForeignData
{
    public string? FaceName { get; set; }
    
    public string? FlavorText { get; set; }

    public Identifiers Identifiers { get; set; } = new Identifiers();

    public string Language { get; set; } = string.Empty;
    
    public string Name { get; set; } = string.Empty;

    public string? Text { get; set; }
    
    public string? Type { get; set; }

    public string Uuid { get; set; } = string.Empty;
}