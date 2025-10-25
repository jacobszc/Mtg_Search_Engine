using Microsoft.EntityFrameworkCore;

public class MagicCardDbContext : DbContext
{

    public MagicCardDbContext(DbContextOptions options) : base(options) { }

    
    public DbSet<Card> Cards { get; set; }

}

