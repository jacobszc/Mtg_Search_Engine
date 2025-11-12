namespace CompletemtgDatabase;


public class SealedProductContents
{
        
        public int Id { get; set; }
        public SealedProductCard[]? Card { get; set; }
        
        public SealedProductDeck[]? Deck { get; set; }
        
        public SealedProductOther[]? Other { get; set; }
        
        public SealedProductPack[]? Pack { get; set; }
        
        public SealedProductSealed[]? Sealed { get; set; }

        public SealedProductVariableConfig[]? Variable { get; set; }
    }
