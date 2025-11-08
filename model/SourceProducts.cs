namespace CompletemtgDatabase;

public class SourceProducts
{

  public int Id { get; set; }

  public List<string> etched { get; set; } = new();

  public List<string> foil { get; set; } = new();

  public List<string> nonfoil { get; set; } = new();
}