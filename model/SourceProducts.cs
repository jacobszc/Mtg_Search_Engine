using System.ComponentModel.DataAnnotations.Schema;

namespace CompletemtgDatabase;

public class SourceProducts
{

  public int Id { get; set; }

 
  //public string[] Etched { get; set; } = Array.Empty<string>();

  public string[]? Foil { get; set; } 

  public string[]? Nonfoil { get; set; } 
}