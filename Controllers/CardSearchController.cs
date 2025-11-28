using CompletemtgDatabase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<IEnumerable<CardSet>>> Search([FromQuery] string queryResult) //from query attribute is jsut a safety measure
    {
        if (string.IsNullOrWhiteSpace(queryResult)) // if query result is empty, which it wont be if it made it this far, but jut to double check
        {
            return BadRequest("Query parameter 'queryResult' is required."); // return a repsonse obejct with a ok repsonse set to false, and an error message in the body
        }

        var cards = await _db.CardSet    /// this part if the EF core Linq query where im wrtiting a db query in c# rather than sql
            .Where(c => c.Name.Contains(queryResult))    
            .OrderBy(c => c.Name)
            .Take(3)   // so this is sql says SELECT * 
                                                          //FROM CARDSET 
                                                          // WHERE NAME LIKE <queryResult> 
                                                          // ORDER BY Name Ascending
                                    
            .ToListAsync(); // we need this because the sql will only execture when you ENUMERATE IT, so we must use .Tolist(), count(), foreach... etc..

        return Ok(cards); // will be serialized as JSON, asp.net returns repsonse objects as json by default
    }







    }
}
