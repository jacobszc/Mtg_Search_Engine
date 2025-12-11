using System.Text.Json;
using CompletemtgDatabase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardSearchController : ControllerBase
    {
        
    public readonly mtgDbContext _db;

    public CardSearchController(mtgDbContext db)
        {
            
            _db = db;
        }


        [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<CardSet>>> Search(string queryResult, string? colors, string? types) //from query attribute is jsut a safety measure
    {
        if (string.IsNullOrWhiteSpace(queryResult)) // if query result is empty, which it wont be if it made it this far, but jut to double check
        {
            return BadRequest("Query parameter 'queryResult' is required."); // return a repsonse obejct with a ok repsonse set to false, and an error message in the body
        }

       
       

        var query = _db.CardSet.Where(c => c.Name.Contains(queryResult));

        if (colors != null && colors.Any())
        {
        query = query.Where(d => d.ColorIdentity.Any(color => colors.Contains(color)));
        }

        if(types != null && types.Any())
            {
              query = query.Where(e => e.Types.Any(type => types.Contains(type)));  

            }

         var cards = await query
           .OrderBy(c => c.Name)
           .Take(5)
           .ToListAsync(); // we need this because the sql will only execture when you ENUMERATE IT, so we must use .Tolist(), count(), foreach... etc..

        return Ok(cards); // will be serialized as JSON, asp.net returns repsonse objects as json by default
    }







    }
}
