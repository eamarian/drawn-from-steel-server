using DrawnFromSteel.DTOs.Auth.Session;
using DrawnFromSteel.Mappers.Auth;
using DrawnFromSteel.Models;
using DrawnFromSteel.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly DFSContext _context;

        public SessionController(DFSContext context)
        {
            _context = context;
        }

        // POST: api/Session
        [HttpPost]
        public async Task<ActionResult<SessionCreateResponse>> CreateSession([FromBody] SessionCreateRequest request)
        {
            User? user = await _context.User.FindAsync(request.UserId);
            if (user == null)
            {
                return UnprocessableEntity(); // TODO: Update this to provide information on the error.
            }
            else
            {
                Session session = request.ToSession();
                user.Sessions.Add(session);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(CreateSession), session.ToSessionCreateResponse());
            }
        }

        // GET: api/Session/123
        [HttpGet("{sessionToken}")]
        public async Task<ActionResult<SessionAndUserGetResponse>> GetSessionAndUserByToken([FromRoute] string sessionToken)
        {
            Session? session = await _context.Session.Include(session => session.User).SingleOrDefaultAsync(session => session.SessionToken == sessionToken);
            return session == null ? NotFound() : Ok(session.ToSessionAndUserGetResponse());
        }

        // PUT api/Session/123
        [HttpPut("{sessionToken}")]
        public async Task<ActionResult<SessionUpdateResponse>> UpdateSession([FromRoute] string sessionToken, [FromBody] SessionUpdateRequest request)
        {
            if (!sessionToken.Equals(request.SessionToken))
            {
                return UnprocessableEntity(); // TODO: Update this to provide information on the error.
            }

            Session? session = await _context.Session.Include(session => session.User).SingleOrDefaultAsync(session => session.SessionToken == sessionToken);

            if (session == null)
            {
                return NotFound();
            }

            session = request.ToSession();

            _context.Update(session);
            await _context.SaveChangesAsync();

            return Ok(session.ToSessionUpdateResponse());
        }

        // DELETE: api/Session/123
        [HttpDelete("{sessionToken}")]
        public async Task<ActionResult<SessionDeleteResponse>> DeleteSession([FromRoute] string sessionToken)
        {
            Session? session = await _context.Session.Include(session => session.User).SingleOrDefaultAsync(session => session.SessionToken == sessionToken);

            if (session == null)
            {
                return NotFound();
            }

            _context.Session.Remove(session);
            await _context.SaveChangesAsync();

            return Ok(session.ToSessionDeleteResponse());
        }
    }
}
