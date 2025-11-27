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
    public async Task<ActionResult<IEnumerable<CardSet>>> Search([FromQuery] string queryResult)
    {
        if (string.IsNullOrWhiteSpace(queryResult))
        {
            return BadRequest("Query parameter 'queryResult' is required.");
        }

        var cards = await _db.CardSet
            .Where(c => c.Name.Contains(queryResult))    // or .Equals(q) if you want exact
            .OrderBy(c => c.Name)
                                    // limit so you don’t return thousands
            .ToListAsync();

        return Ok(cards); // will be serialized as JSON
    }







    }
}
