using System.Text.Json;
using System.Xml;
using CompletemtgDatabase;

namespace Json.Parser;

public class AllPrintingsJsonDocumentDeserialzier {
private readonly JsonDocument _allPrintingsjsonDocument;
  private readonly mtgDbContext _db;

public AllPrintingsJsonDocumentDeserialzier(JsonDocument AllPrintingsJsonDocument, mtgDbContext db)
    {
        _allPrintingsjsonDocument = AllPrintingsJsonDocument;

        _db = db;

        

        AllPrintingsDeserialize(_allPrintingsjsonDocument);

    } // end constrcutor

    public void AllPrintingsDeserialize(JsonDocument _allPrintingsjsonDocument) {

        JsonElement root = _allPrintingsjsonDocument.RootElement;
        var data = root.GetProperty("data");
        JsonElement SetElement = new JsonElement() ;
     
        var options = new JsonSerializerOptions
        
        {
          PropertyNameCaseInsensitive = true
         };

          
           
        foreach (JsonProperty setProperty in data.EnumerateObject())   {    
             SetElement = default;
             SetElement = setProperty.Value;
    //////////////////////////////////// Set //////////////////////////////////////////// 
             
             Set? Set = JsonSerializer.Deserialize<Set>(SetElement, options);
                 _db.Set.Add(Set);
                 _db.SaveChanges();



                  //////////////////////////////// Token ////////////////////////////////////////////////


           if(SetElement.TryGetProperty("tokens", out var TokensElement)) {
             foreach(var TokenEle in TokensElement.EnumerateArray())

               {
                Console.Write("The type of this is CardToken");
                CardToken? CardToken = JsonSerializer.Deserialize<CardToken>(TokenEle, options);
                _db.CardToken.Add(CardToken);
                _db.SaveChanges();
                continue;
                
              }

           }

     /////////////////////////////// cardSetDeck ////////////////////////////////////////////////////            
                 
                
            if(SetElement.TryGetProperty("decks", out var DecksElement))
                foreach(var DeckEle in DecksElement.EnumerateArray())
                {
                    Console.Write("The type of this is CardSetDeck");
                    CardSetDeck? CardSetDeck = JsonSerializer.Deserialize<CardSetDeck>(DeckEle, options);
                    _db.CardSetDeck.Add(CardSetDeck);
                    _db.SaveChanges();
                    continue;
                }
            
     ///////////////////////////////////////////////////CardSet//////////////////////////////////////////////////////////////   

           

           if(SetElement.TryGetProperty("cards", out var CardsElement))
        
              foreach(var CardEle in CardsElement.EnumerateArray()) {

           
                Console.Write("The type of this is CardSet");
                CardSet? Card = JsonSerializer.Deserialize<CardSet>(CardEle, options);
                _db.CardSet.Add(Card);
                _db.SaveChanges();
                 continue;
           

            }


          

           
           
           
           
           
           if(SetElement.TryGetProperty("commander", out _) && SetElement.TryGetProperty("mainBoard", out _))
           {
            Console.Write("The type of this is DeckSet");
           DeckSet? DeckSet = JsonSerializer.Deserialize<DeckSet>(SetElement, options);
           continue;
           }


           if(SetElement.TryGetProperty("faceName", out _) && SetElement.TryGetProperty("flavorText", out _))
           {
            Console.Write("The type of this is ForignData");
            ForeignData? ForeignData = JsonSerializer.Deserialize<ForeignData>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("abuId", out _) && SetElement.TryGetProperty("cardKingdomEtchedId", out _))
           {
            Console.Write("The type of this is Identifiers");
            Identifiers? Identifiers = JsonSerializer.Deserialize<Identifiers>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("brawl", out _) && SetElement.TryGetProperty("oathBreaker", out _))
           {
            Console.Write("The type of this is LeaderShipSkills");
            LeadershipSkills? LeadershipSkills = JsonSerializer.Deserialize<LeadershipSkills>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("alchemy", out _) && SetElement.TryGetProperty("gladiator", out _))
           {
            Console.Write("The type of this is Legalities");
            Legalities? Legalities = JsonSerializer.Deserialize<Legalities>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("cardMarket", out _) && SetElement.TryGetProperty("tcgPlayer", out _))
           {
            Console.Write("The type of this is PurchaceUrls");
            PurchaceUrls? PurchaceUrls = JsonSerializer.Deserialize<PurchaceUrls>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("reverseRelated", out _) )
           {
            Console.Write("The type of this is Reverse Related");
           RelatedCards? RelatedCards = JsonSerializer.Deserialize<RelatedCards>(SetElement, options);
           continue;
           }

           if(SetElement.TryGetProperty("cardParts", out _) && SetElement.TryGetProperty("colorIndicator", out _))
           {
            Console.Write("The type of this is CardToken");
            CardToken? CardToken = JsonSerializer.Deserialize<CardToken>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("date", out _) && SetElement.TryGetProperty("text", out _))
           {
            Console.Write("The type of this is Rulings");
            Rulings? Rulings = JsonSerializer.Deserialize<Rulings>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("releaseDate", out _) && SetElement.TryGetProperty("subType", out _))
           {
            Console.Write("The type of this is Sealed Product");
            SealedProduct? SealedProduct = JsonSerializer.Deserialize<SealedProduct>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("foil", out _) && SetElement.TryGetProperty("number", out _) && SetElement.TryGetProperty("set", out _))
           {
            Console.Write("The type of this is Sealed Product Csrd");
            SealedProductCard? SealedProductCard = JsonSerializer.Deserialize<SealedProductCard>(SetElement, options);
            continue;
           }


           if(SetElement.TryGetProperty("variable", out _) && SetElement.TryGetProperty("other", out _))
           {
            Console.Write("The type of this is Sealed Product Contetns");
            SealedProductContents? SealedProductContents = JsonSerializer.Deserialize<SealedProductContents>(SetElement, options);
            continue;
           }

            if(SetElement.TryGetProperty("name", out _) && SetElement.TryGetProperty("set", out _))
           {
            Console.Write("The type of this is Sealed Product deck");
            SealedProductDeck? SealedProductDeck = JsonSerializer.Deserialize<SealedProductDeck>(SetElement, options);
            continue;
           }

            if(SetElement.TryGetProperty("code", out _) && SetElement.TryGetProperty("set", out _))
           {
            Console.Write("The type of this is Sealed Product pack");
            SealedProductPack? SealedProductPack = JsonSerializer.Deserialize<SealedProductPack>(SetElement, options);
            continue;
           }

            if(SetElement.TryGetProperty("count", out _) && SetElement.TryGetProperty("set", out _) && SetElement.TryGetProperty("name", out _) && SetElement.TryGetProperty("uUid", out _))
           {
            Console.Write("The type of this is Sealed Product Sealed");
            SealedProductSealed? SealedProductSealed = JsonSerializer.Deserialize<SealedProductSealed>(SetElement, options);
            continue;
           }

            if(SetElement.TryGetProperty("configs", out _) &&  SetElement.EnumerateObject().Count() == 1)
           {
            Console.Write("The type of this is Sealed Product varaible config");
            SealedProductVariableConfig? SealedProductVariableConfig = JsonSerializer.Deserialize<SealedProductVariableConfig>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("etched", out _) && SetElement.TryGetProperty("foil", out _))
           {
            Console.Write("The type of this is Source Products ");
            SourceProducts? SealedProduct = JsonSerializer.Deserialize<SourceProducts>(SetElement, options);
            continue;
           }

           if(SetElement.TryGetProperty("ancientGreek", out _) && SetElement.TryGetProperty("arabic", out _))
           {
            Console.Write("The type of this is translations");
            Translations? Translations = JsonSerializer.Deserialize<Translations>(SetElement, options);
            continue;
           }



           

           else
            {
               Console.Write("some other type"); 
            }
        
            
        }
        } // end Deserialize funtiuon






    



} // end class