using DrawnFromSteel.DTOs;
using DrawnFromSteel.Models;
using DrawnFromSteel.Models.Auth;
using DrawnFromSteel.Models.Transient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly DFSContext _context;

        public HeroController(DFSContext context)
        {
            _context = context;
        }

        // GET: api/Hero/123
        [HttpGet("{userId}")]
        public async Task<ActionResult<List<GetHeroesResponse>>> GetHeroes([FromRoute] int userId)
        {
            List<GetHeroesResponse> heroes = await _context.Hero
                .Select(hero => new GetHeroesResponse { Id = hero.Id, UserId = hero.User.Id, Name = hero.Name, Level = hero.Level })
                .Where(hero => hero.UserId == userId)
                .ToListAsync();
            return Ok(heroes);
        }

        // GET: api/Hero/123/456
        [HttpGet("{userId}/{heroId}")]
        public async Task<ActionResult<GetHeroesResponse>> GetHero([FromRoute] int userId, [FromRoute] int heroId)
        {
            Hero? hero = await _context.Hero.Include(hero => hero.User).SingleOrDefaultAsync(hero => hero.User.Id == userId && hero.Id == heroId);
            if (hero == null)
            {
                return NotFound();
            }
            else
            {
                GetHeroesResponse response = new GetHeroesResponse { Id = hero.Id, UserId = hero.User.Id, Name = hero.Name, Level = hero.Level };
                return Ok(response);
            }
        }

        // POST: api/Hero/123
        [HttpPost("{userId}")]
        public async Task<ActionResult<GetHeroesResponse>> CreateHero([FromRoute] int userId, [FromBody] HeroCreateRequest request)
        {
            if (userId != request.UserId)
            {
                return BadRequest();
            }
            User? user = await _context.User.FindAsync(userId);
            if (user == null)
            {
                return BadRequest();
            }

            Hero hero = new Hero { User = user, Name = request.Name, Level = request.Level };
            _context.Hero.Add(hero);
            await _context.SaveChangesAsync();
            GetHeroesResponse response = new() { Id = hero.Id, UserId = hero.User.Id, Name = hero.Name, Level = hero.Level };
            return CreatedAtAction(nameof(CreateHero), response);
        }

        // DELETE: api/Hero/123/456
        [HttpDelete("{userId}/{heroId}")]
        public async Task<ActionResult> DeleteHero([FromRoute] int userId, [FromRoute] int heroId)
        {
            Hero? hero = await _context.Hero.Include(hero => hero.User).SingleOrDefaultAsync(hero => hero.User.Id == userId && hero.Id == heroId);
            if (hero == null)
            {
                return NotFound();
            }
            else
            {
                _context.Hero.Remove(hero);
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
