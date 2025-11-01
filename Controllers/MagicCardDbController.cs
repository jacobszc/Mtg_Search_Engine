using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace Demo.Controllers;

[ApiController]
[Route("api/cards")]
public class MagicCardDbController : ControllerBase
{
    

    private ILogger<MagicCardDbController> _logger;
    private MagicCardDbContext _dbContext;
    public MagicCardDbController(ILogger<MagicCardDbController> logger, MagicCardDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet("{name}")] // when javascript sends fetch request to server, sends a get request to the server, it knows to pass the name sent to that function to this line, and pass the name result into this fuinction 

    public async Task<ActionResult<Card>> GetByName(string name) {

        if(string.IsNullOrWhiteSpace(name))


        
              return BadRequest("Name is Required");

              var card = await _dbContext.Cards.AsNoTracking().FirstOrDefaultAsync(c => c.CardName.ToLower() == name.ToLower());  //<-- ok for now but fix nullable properties in Card later

        if (card is null) return NotFound();
                
                var cards = _dbContext.Cards.ToList();
                foreach (var c in cards)
    {
               _logger.LogInformation("Name= {Name}, ManaCost= {Cost}, ColorIdentity= {Color}",
                c.CardName, c.BaseManaCost, c.ColorIdentity);
     }

              return Ok(card); 



    }
    
    
    
}
