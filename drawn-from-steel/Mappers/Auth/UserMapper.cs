using DrawnFromSteel.DTOs.Auth.User;
using DrawnFromSteel.Models.Auth;

namespace DrawnFromSteel.Mappers.Auth
{
    public static class UserMapper
    {
        public static User ToUser(this UserCreateRequest request)
        {
            return new User
            {
                Name = request.Name,
                Email = request.Email,
                EmailVerified = request.EmailVerified,
                Image = request.Image,
            };
        }

        public static UserCreateResponse ToUserCreateResponse(this User user)
        {
            return new UserCreateResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                EmailVerified = user.EmailVerified,
                Image = user.Image,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
            };
        }

        public static UserGetResponse ToUserGetResponse(this User user)
        {
            return new UserGetResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                EmailVerified = user.EmailVerified,
                Image = user.Image,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
            };
        }

        public static User ToUser(this UserUpdateRequest request)
        {
            return new User
            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                EmailVerified = request.EmailVerified,
                Image = request.Image,
            };
        }

        public static UserUpdateResponse ToUserUpdateResponse(this User user)
        {
            return new UserUpdateResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                EmailVerified = user.EmailVerified,
                Image = user.Image,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
            };
        }

        public static UserDeleteResponse ToUserDeleteResponse(this User user)
        {
            return new UserDeleteResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                EmailVerified = user.EmailVerified,
                Image = user.Image,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
            };
        }
    }
}
