using System.Text.Json;
using System.Xml;
using CompletemtgDatabase;
using EFCore.BulkExtensions;


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

//         var tokens = root.GetProperty("cardToken");
//             var token20 = tokens[20];

// if (token20.TryGetProperty("sourceProducts", out var sp))
// {
//     Console.WriteLine(sp.ValueKind);
//     Console.WriteLine(sp.GetRawText());
// }
// else
// {
//     Console.WriteLine("tokens[20] has no sourceProducts");
// }   
        JsonElement SetElement = new JsonElement() ;
     
        var options = new JsonSerializerOptions
        
        {
          PropertyNameCaseInsensitive = true
         };


         List<Set> SetList = new List<Set>();
         
         List<CardSet> CardList = new List<CardSet>();

          
           
        foreach (JsonProperty setProperty in data.EnumerateObject())   {    
             SetElement = default;
             SetElement = setProperty.Value;
    //////////////////////////////////// Set //////////////////////////////////////////// 
    /// 
                                                                                               // JSONDOCUMENT = whole file
    ///                                                                                      // JSONELEMENT = THE WHOLE JSON OBJECT
    ///                                                                                       // data = root.GetProperty("data) = the whole data section of json object
                                                                                                   
             Set? Set = JsonSerializer.Deserialize<Set>(SetElement, options);
             SetList.Add(Set);


             if(SetElement.TryGetProperty("cards", out var CardsElement))
        
              foreach(var CardEle in CardsElement.EnumerateArray()) {

           
                
                CardSet? Card = JsonSerializer.Deserialize<CardSet>(CardEle, options);
                
                CardList.Add(Card);
           

            }


                
          
        
            
        }

        _db.BulkInsertOrUpdateOrDelete(SetList);
        _db.BulkInsertOrUpdateOrDelete(CardList);
        } // end Deserialize funtiuon






    



} // end class