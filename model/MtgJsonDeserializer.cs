using System.Text.Json;
using CompletemtgDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MtgJsonDeserializer{

    public string JsonFile;

    public MtgJsonDeserializer(string filename)
    {

        JsonFile = filename;
    }
    
    
    public async Task DeserializeMtgJson()
    {
          
        using FileStream openStream = File.OpenRead(JsonFile);

        await foreach (JsonElement elem in JsonSerializer.DeserializeAsyncEnumerable<JsonElement>(openStream)) // 1.) grab 1 jsonEleemtn
        {

            var type = elem.GetProperty("type").GetString(); // extract type

            switch(type) {

                
                case "BoosterConfig":

                    BoosterConfig? boosterConfig = elem.Deserialize<BoosterConfig>();
                    break;

                case "BoosterPack":

                    BoosterPack? BoosterPack = elem.Deserialize<BoosterPack>();
                    break;

                case "BoosterSheet":

                    BoosterSheet? BoosterSheet = elem.Deserialize<BoosterSheet>();
                    break;

                case "CardSet":

                    CardSet? CardSet = elem.Deserialize<CardSet>();
                    break;


                case "CardSetDeck":

                    BoosterConfig? CardSetDeck = elem.Deserialize<BoosterConfig>();
                    break;

                case "CardToken":

                    CardToken? CardToken = elem.Deserialize<CardToken>();
                    break;

                case "DeckSet":

                    DeckSet? DeckSet = elem.Deserialize<DeckSet>();
                    break;

                case "ForeignData":

                    ForeignData? ForeignData = elem.Deserialize<ForeignData>();
                    break;

                case "Identifiers":

                    Identifiers? Identifiers = elem.Deserialize<Identifiers>();
                    break;

                case "LeaderShipSkills":

                    LeadershipSkills? LeadershipSkills = elem.Deserialize<LeadershipSkills>();
                    break;

                case "Legalities":

                    Legalities? Legalities = elem.Deserialize<Legalities>();
                    break;

                case "PurchaceUrls":

                    PurchaceUrls? PurchaceUrls = elem.Deserialize<PurchaceUrls>();
                    break;

                case "RelatedCards":

                    RelatedCards? RelatedCards = elem.Deserialize<RelatedCards>();
                    break;

                case "Rulings":

                    Rulings? Rulings = elem.Deserialize<Rulings>();
                    break;

                case "SealedProduct":

                    SealedProduct? SealedProduct = elem.Deserialize<SealedProduct>();
                    break;

                case "SealedProductCard":

                    SealedProductCard? SealedProductCard = elem.Deserialize<SealedProductCard>();
                    break;

                case "SealedProductContents":

                    SealedProductContents? SealedProductContents = elem.Deserialize<SealedProductContents>();
                    break;

                case "SealedProductDeck":

                    SealedProductDeck? SealedProductDeck = elem.Deserialize<SealedProductDeck>();
                    break;

                case "SealedProductOther":

                    SealedProductOther? SealedProductOther = elem.Deserialize<SealedProductOther>();
                    break;

                case "SealedProductPack":

                    SealedProductPack? SealedProductPack = elem.Deserialize<SealedProductPack>();
                    break;

                case "SealedProductSealed":

                    SealedProductSealed? SealedProductSealed = elem.Deserialize<SealedProductSealed>();
                    break;

                case "SealedProductVariableConfig":

                    SealedProductVariableConfig? SealedProductVariableConfig = elem.Deserialize<SealedProductVariableConfig>();
                    break;

                case "Set":

                    Set? Set = elem.Deserialize<Set>();
                    break;

                case "SourceProducts":

                    SourceProducts? SourceProducts = elem.Deserialize<SourceProducts>();
                    break;

                
                 case "Translations":

                    Translations? Translations = elem.Deserialize<Translations>();
                    break;

                case "Meta":

                    Meta? Meta = elem.Deserialize<Meta>();
                    break;
                


                default:
                    throw new Exception("type not found within C# model objects");
                    

            }


           

        }

    }
        

    
    
}