using System.Text.Json;
using CompletemtgDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MyDeserializer{

    public JsonElement Elem { get; }  // means it's read-only — it can only be set inside the constructor or initializer.


    public MyDeserializer(JsonElement elem)
    {
        Elem = elem;
    }
    
    
    // public async void Des()
    // {

    //     await foreach (JsonElement elem in JsonSerializer.DeserializeAsyncEnumerable<JsonElement>()) // 1.) grab 1 jsonEleemtn
    //     {

    //         var type = elem.GetProperty("type").GetString(); // extract type

    //         switch(type) {

    //             case "CardSet":

    //                 var CardSet = elem.Deserialize<CardSet>();


    //                 break;

    //             default:
    //                 throw new Exception("type not found within C# model objects");

    //         }


    //         return OK();

    //     }

    // }
        

    
    
}