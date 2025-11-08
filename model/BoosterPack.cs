using System.ComponentModel.DataAnnotations.Schema;

namespace CompletemtgDatabase;

public class BoosterPack {

    public int Id { get; set; }
   [NotMapped]
    public Dictionary<string, int>? Contents { get; set; }

    public int Weight { get; set; }
}