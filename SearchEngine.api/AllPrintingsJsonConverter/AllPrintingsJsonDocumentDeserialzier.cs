using System.Text.Json;

namespace Json.Parser;

public class AllPrintingsJsonDocumentDeserialzier
{



    private readonly JsonDocument _allPrintingsjsonDocument;



    public AllPrintingsJsonDocumentDeserialzier(JsonDocument AllPrintingsJsonDocument)
    {
        _allPrintingsjsonDocument = AllPrintingsJsonDocument;

        AllPrintingsDeserialize(_allPrintingsjsonDocument);

    }

    public void AllPrintingsDeserialize(JsonDocument _allPrintingsjsonDocument)
    {

        JsonElement root = _allPrintingsjsonDocument.RootElement;

        var data = root.GetProperty("data");

        JsonElement ValueElement;


        foreach (JsonProperty setProperty in data.EnumerateObject())        //<---- works but ver slow. need to set up as stream
            ValueElement = setProperty.Value;
        }






    }



}