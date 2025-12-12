using System.Text.Json;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

 namespace MyApp.Namespace;


 [Route("api/[controller]")]

[ApiController]


public class ImageSearchController : ControllerBase {

 public ImageSearchController() {

  
   /// 

 }

[HttpGet("imagesearch")]
 public async Task<ActionResult<string>> ImageSearch(string imgQueryResult) {

  if(string.IsNullOrWhiteSpace(imgQueryResult)) {

        return BadRequest("imgQuery parameter 'imgqueryResult' is required.");


    }

      HttpClient client = new HttpClient(); // make this DI later, should only be instantiated once per application

      string uri = $"https://api.scryfall.com/cards/named?exact={imgQueryResult}";

      try
    {
      using HttpResponseMessage response = await client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      string responseBody = await response.Content.ReadAsStringAsync(); // this should auto dserialzie json into string
       Console.WriteLine(responseBody);
       return Ok(responseBody);
    }
     catch(HttpRequestException e)
    {

       Console.WriteLine("\nException Caught!");
      Console.WriteLine("Message :{0} ", e.Message);
      
    }

    






return Ok("connection worked but no img returned");




 }







}


