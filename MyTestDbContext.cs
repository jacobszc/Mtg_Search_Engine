using Microsoft.EntityFrameworkCore;

public class MyTestDbContext : DbContext
{

public MyTestDbContext(DbContextOptions options) : base(options)
    {
        
        
    }
    public DbSet<Card> Cards { get; set; }

}

