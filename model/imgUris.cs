using System.Text.Json.Serialization;

namespace MyApp.Namespace;


public class ImgUris {


[JsonPropertyName("normal")]
public string? Normal {get; set;} // each of these points to the actual uri of the image we want


[JsonPropertyName("small")]
public string? Small {get; set;}

[JsonPropertyName("large")]

public string? Large {get; set;}



}