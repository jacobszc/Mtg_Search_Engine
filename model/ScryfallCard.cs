using System.Text.Json.Serialization;

namespace MyApp.Namespace;


public class ScryfallCard {

    [JsonPropertyName("image_uris")]
    public ImgUris? ImgUris {get; set;}
}