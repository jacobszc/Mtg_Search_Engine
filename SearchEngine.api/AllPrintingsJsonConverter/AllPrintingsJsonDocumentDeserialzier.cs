using System.Text.Json;
using CompletemtgDatabase;

namespace Json.Parser;

public class AllPrintingsJsonDocumentDeserialzier {
private readonly JsonDocument _allPrintingsjsonDocument;

public AllPrintingsJsonDocumentDeserialzier(JsonDocument AllPrintingsJsonDocument)
    {
        _allPrintingsjsonDocument = AllPrintingsJsonDocument;

        AllPrintingsDeserialize(_allPrintingsjsonDocument);

    } // end constrcutor

    public void AllPrintingsDeserialize(JsonDocument _allPrintingsjsonDocument) {

        JsonElement root = _allPrintingsjsonDocument.RootElement;
        var data = root.GetProperty("data");
        JsonElement ValueElement = new JsonElement() ;
        var options = new JsonSerializerOptions
        {
          PropertyNameCaseInsensitive = true
         };


        foreach (JsonProperty setProperty in data.EnumerateObject())   {    //<---- works but ver slow. need to set up as stream
             ValueElement = setProperty.Value;

            
            if(ValueElement.TryGetProperty( "baseSetSize", out _))
            {
                 Console.Write("The type of this is Set!");
                 Set? Set = JsonSerializer.Deserialize<Set>(ValueElement, options);
            }
            
            
            
            if(ValueElement.EnumerateObject().Count() == 6 &&  ValueElement.ValueEquals("BoosterTotalWeight") )
           {
            Console.Write("The type of this is BoosterConfig");
           }

           else
            {
               Console.Write("some other type"); 
            }
        
            
        }
        } // end Deserialize funtiuon






    



} // end class