using Microsoft.EntityFrameworkCore;

namespace CompletemtgDatabase;

    public class CompletemtgDbContext  : DbContext
    {
        
     public CompletemtgDbContext(DbContextOptions options) : base(options) { }
     
     
     
     
     
      public DbSet<Set> set {get; set;}
      
      public DbSet<BoosterConfig> BoosterConfig {get; set;}

      public DbSet<BoosterPack> BoosterPack {get; set;}
      
      public DbSet<BoosterSheet> BoosterSheet {get; set;}

      public DbSet<CardSet> CardSet {get; set;}

      public DbSet<CardSetDeck> CardSetDeck {get; set;}

      public DbSet<CardToken> CardToken {get; set;}

      public DbSet<DeckSet> DeckSet {get; set;}

      public DbSet<Identifiers> Identifiers {get; set;}

      public DbSet<LeadershipSkills> LeadershipSkills {get; set;}

      public DbSet<Legalities> Legalities {get; set;}

      public DbSet<PurchaseUrls> PurchaseUrls {get; set;}

      public DbSet<RelatedCards> RelatedCards {get; set;}

      public DbSet<Rulings> Rulings {get; set;}

      public DbSet<SourceProducts> SourceProducts {get; set;}

      public DbSet< SealedProduct>  SealedProduct {get; set;}

      public DbSet< SealedProductCard>  SealedProductCard {get; set;}

      public DbSet< SealedProductContents>  SealedProductContents {get; set;}

      public DbSet<SealedProductDeck> SealedProductDeck {get; set;}

      public DbSet<SealedProductOther> SealedProductOther {get; set;}

      public DbSet<SealedProductPack> SealedProductPack {get; set;}

      public DbSet<SealedProductSealed> SealedProductSealed  {get; set;}

      public DbSet<SealedProductVariableConfig> SealedProductVariableConfig  {get; set;}

      public DbSet<ForeignData> ForeignData  {get; set;}

      public DbSet<Translations> Translations  {get; set;}

      



    }
