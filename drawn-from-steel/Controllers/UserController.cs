using DrawnFromSteel.DTOs.Auth.User;
using DrawnFromSteel.Mappers.Auth;
using DrawnFromSteel.Models;
using DrawnFromSteel.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DFSContext _context;

        public UserController(DFSContext context)
        {
            _context = context;
        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<UserCreateResponse>> CreateUser([FromBody] UserCreateRequest request)
        {
            User user = request.ToUser();
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CreateUser), user.ToUserCreateResponse());
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserGetResponse>> GetUserById([FromRoute] int id)
        {
            User? user = await _context.User.FindAsync(id);
            return user == null ? NotFound() : Ok(user.ToUserGetResponse());
        }

        // GET api/User?email=test@email.com
        [HttpGet]
        public async Task<ActionResult<UserGetResponse>> GetUserByEmail([FromQuery] string email)
        {
            User? user = await _context.User.SingleOrDefaultAsync(user => user.Email == email);
            return user == null ? NotFound() : Ok(user.ToUserGetResponse());
        }

        // GET: api/User/google/123
        [HttpGet("{providerId}/{providerAccountId}")]
        public async Task<ActionResult<UserGetResponse>> GetUserByAccount(string providerId, string providerAccountId)
        {
            Account? account = await _context.Account.Include(account => account.User).SingleOrDefaultAsync(account => account.ProviderAccountId == providerAccountId && account.ProviderId == providerId);
            return account == null ? NotFound() : Ok(account.User.ToUserGetResponse());
        }

        // PUT: api/User/123
        [HttpPut("{id}")]
        public async Task<ActionResult<UserUpdateResponse>> UpdateUser([FromRoute] int id, [FromBody] UserUpdateRequest request)
        {
            if (id != request.Id)
            {
                return UnprocessableEntity(); // TODO: Update this to provide information on the error.
            }

            User? user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            user = request.ToUser();

            _context.Update(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        // DELETE: api/User/123
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDeleteResponse>> DeleteUser([FromRoute] int id)
        {
            User? user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user.ToUserDeleteResponse());
        }
    }
}
