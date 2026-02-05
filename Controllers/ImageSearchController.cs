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

  if (!_http.DefaultRequestHeaders.UserAgent.Any())
            _http.DefaultRequestHeaders.UserAgent.ParseAdd("MagicCardApp/1.0 (contact: jacobszc@buffalo.edu)");

  if (!_http.DefaultRequestHeaders.Accept.Any())
            _http.DefaultRequestHeaders.Accept.ParseAdd("application/json");
   

 }

[HttpGet("imagesearch")]
 public async Task<ActionResult<IEnumerable<string>>> ImageSearch(string imgQueryResult) {

  if(string.IsNullOrWhiteSpace(imgQueryResult)) {

        return BadRequest("imgQuery parameter 'imgqueryResult' is required.");


    }


    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

    var query = Uri.EscapeDataString(imgQueryResult); 
    var uri = $"https://api.scryfall.com/cards/named?fuzzy={query}"; // this is the path to scryfall to send the query name

     var cardUrlList = new List<string>(capacity:50); // empty list of strings to store all imgs returned from scry fall





    
      try
    {
      using HttpResponseMessage response = await _http.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var responseBody = await response.Content.ReadAsStringAsync();

      

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


