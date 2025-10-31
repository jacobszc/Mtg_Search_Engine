namespace CompletemtgDatabase;


public class SealedProductContents
    {
        public List<SealedProductCard>? Card { get; set; }
        
        public List<SealedProductDeck>? Deck { get; set; }
        
        public List<SealedProductOther>? Other { get; set; }
        
        public List<SealedProductPack>? Pack { get; set; }
        
        public List<SealedProductSealed>? Sealed { get; set; }

        public List<SealedProductVariableConfig>? Variable { get; set; }
    }
