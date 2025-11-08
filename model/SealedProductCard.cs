namespace CompletemtgDatabase;

public class  SealedProductCard
{
        
        public int Id { get; set; }
        public bool? Foil { get; set; }

    public string Name { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string Set { get; set; } = string.Empty;

        public string Uuid { get; set; } = string.Empty;
    }