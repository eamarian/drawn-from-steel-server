using DrawnFromSteel.DTOs.Auth.Account;
using DrawnFromSteel.Models.Auth;

namespace DrawnFromSteel.Mappers.Auth
{
    public static class AccountMapper
    {
        public static Account ToAccount(this AccountCreateRequest request)
        {
            return new Account
            {
                User = new User { Id = request.UserId },
                ProviderType = request.ProviderType,
                ProviderId = request.ProviderId,
                ProviderAccountId = request.ProviderAccountId,

                RefreshToken = request.RefreshToken,
                AccessToken = request.AccessToken,
                AccessTokenExpires = request.AccessTokenExpires,
            };
        }

        public static AccountCreateResponse ToAccountCreateResponse(this Account account)
        {
            return new AccountCreateResponse
            {
                Id = account.Id,
                UserId = account.User.Id,
                ProviderType = account.ProviderType,
                ProviderId = account.ProviderId,
                ProviderAccountId = account.ProviderAccountId,
                RefreshToken = account.RefreshToken,
                AccessToken = account.AccessToken,
                AccessTokenExpires = account.AccessTokenExpires,
                CreatedAt = account.CreatedAt,
                UpdatedAt = account.UpdatedAt,
            };

        }
    }
}
