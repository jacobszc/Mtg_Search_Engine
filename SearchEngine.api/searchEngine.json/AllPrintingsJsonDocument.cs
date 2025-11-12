using System;
using System.IO;
using System.Text.Json;


namespace Json.Parser;


public class AllPrintingsJsonDocument : IJsonDocument , IDisposable
{
    
   
   private JsonDocument? _allPrintingsJsonDocument;  
  
   private readonly JsonDocumentOptions _options = new JsonDocumentOptions(){
    AllowTrailingCommas = true,
    CommentHandling = JsonCommentHandling.Skip
   };

   
   public AllPrintingsJsonDocument(string path){      // contrcutor automaticly converts json string to json doc

    StringToDoc(path);
   
   }

    public void StringToDoc(string path) {

        using FileStream fs = File.OpenRead(path); // open filesteam of my json doc
       
        //_allPrintingsJsonDocument?.Dispose(); // dispose previous if reloading
        _allPrintingsJsonDocument = JsonDocument.Parse(fs, _options); // convert json string into a JsonDoc

        var data = _allPrintingsJsonDocument.RootElement.GetProperty("data");
        int setCount = data.EnumerateObject().Count(); // count number of object in root object which is the json itself
        Console.WriteLine($"Properties in object: {setCount}");   

 

    
   }

   public void Dispose() {

    _allPrintingsJsonDocument?.Dispose();   //<--- Idisposable is an interface and the dipose is defined in JsonDOcment so we need to call it here
   }
    
    
    
    


}