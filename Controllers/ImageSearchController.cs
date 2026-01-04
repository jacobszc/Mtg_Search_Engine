using System.Text.Json;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

 namespace MyApp.Namespace;


 [Route("api/[controller]")]

[ApiController]


public class ImageSearchController : ControllerBase {

  private readonly HttpClient _http;

 public ImageSearchController(HttpClient http) {

  _http = http;
   /// 

 }

[HttpGet("imagesearch")]
 public async Task<IActionResult> ImageSearch(string imgQueryResult) {

  if(string.IsNullOrWhiteSpace(imgQueryResult)) {

        return BadRequest("imgQuery parameter 'imgqueryResult' is required.");


    }

    var query = Uri.EscapeDataString(imgQueryResult); 
    var uri = $"https://api.scryfall.com/cards/named?fuzzy={query}";
    _http.DefaultRequestHeaders.UserAgent.ParseAdd(
    "MagicCardApp/1.0 (contact: jacobszc@buffalo.edu)"

);
    _http.DefaultRequestHeaders.Accept.ParseAdd("application/json");

      try
    {
      using HttpResponseMessage response = await _http.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var responseBody = await response.Content.ReadAsStringAsync();

      var options = new JsonSerializerOptions {

        PropertyNameCaseInsensitive = true


      
      };

      var card= JsonSerializer.Deserialize<ScryfallCard>(responseBody, options) ?? throw new Exception("failed to desericaluize!");

      var imguri = card.ImgUris?.Normal;
      
       // this should auto dserialzie json into string
       Console.WriteLine(responseBody);
       return Ok(imguri);
    }
     catch(HttpRequestException e)
    {

       Console.WriteLine("\nException Caught!");
      Console.WriteLine("Message :{0} ", e.Message);
      
    }

    






   return Ok("whatever");




 }







}


