using System.Text.Json;
using CompletemtgDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MtgJsonDeserializer{

    

    
    
    
    public async void DeserializeMtgJson()
    {
        string JsonFile = "C:\\Users\\Jacob\\repos\\AllPrintings.json";
        using FileStream openStream = File.OpenRead(JsonFile);

        await foreach (JsonElement elem in JsonSerializer.DeserializeAsyncEnumerable<JsonElement>(openStream)) // 1.) grab 1 jsonEleemtn
        {

            var type = elem.GetProperty("type").GetString(); // extract type

            switch(type) {

                case "CardSet":

                    var CardSet = elem.Deserialize<CardSet>();


                    break;

                default:
                    throw new Exception("type not found within C# model objects");

            }


           

        }

    }
        

    
    
}