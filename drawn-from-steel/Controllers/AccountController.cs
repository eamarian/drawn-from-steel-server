using DrawnFromSteel.DTOs.Auth.Account;
using DrawnFromSteel.Mappers.Auth;
using DrawnFromSteel.Models;
using DrawnFromSteel.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace DrawnFromSteel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly DFSContext _context;

        public AccountController(DFSContext context)
        {
            _context = context;
        }

        // POST: api/Account
        [HttpPost]
        public async Task<ActionResult<AccountCreateResponse>> CreateAccount([FromBody] AccountCreateRequest request)
        {
            User? user = await _context.User.FindAsync(request.UserId);
            if (user == null)
            {
                return UnprocessableEntity(); // TODO: Update this to provide information on the error.
            }
            else
            {
                Account account = request.ToAccount();
                user.Accounts.Add(account);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(CreateAccount), account.ToAccountCreateResponse());
            }
        }
    }
}
