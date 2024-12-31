using DrawnFromSteel.DTOs.Auth.Session;
using DrawnFromSteel.Models.Auth;

namespace DrawnFromSteel.Mappers.Auth
{
    public static class SessionMapper
    {
        public static Session ToSession(this SessionCreateRequest request)
        {
            return new Session
            {
                User = new User { Id = request.UserId },
                Expires = request.Expires,
                SessionToken = request.SessionToken,
            };
        }

        public static SessionCreateResponse ToSessionCreateResponse(this Session session)
        {
            return new SessionCreateResponse
            {
                Id = session.Id,
                UserId = session.User.Id,
                SessionToken = session.SessionToken,
                Expires = session.Expires,
                CreatedAt = session.CreatedAt,
                UpdatedAt = session.UpdatedAt,
            };
        }

        public static SessionAndUserGetResponse ToSessionAndUserGetResponse(this Session session)
        {
            return new SessionAndUserGetResponse
            {
                Session = new SessionAndUserGetResponse.SessionGetResponse
                {
                    Id = session.Id,
                    UserId = session.User.Id,
                    SessionToken = session.SessionToken,
                    Expires = session.Expires,
                    CreatedAt = session.CreatedAt,
                    UpdatedAt = session.UpdatedAt,
                },
                User = new SessionAndUserGetResponse.UserGetResponse
                {
                    Id = session.User.Id,
                    Name = session.User.Name,
                    Email = session.User.Email,
                    EmailVerified = session.User.EmailVerified,
                    Image = session.User.Image,
                    CreatedAt = session.User.CreatedAt,
                    UpdatedAt = session.User.UpdatedAt,
                }

            };
        }

        public static Session ToSession(this SessionUpdateRequest request)
        {
            return new Session
            {
                Id = request.Id,
                User = new User { Id = request.UserId },
                Expires = request.Expires,
                SessionToken = request.SessionToken,
            };
        }

        public static SessionUpdateResponse ToSessionUpdateResponse(this Session session)
        {
            return new SessionUpdateResponse
            {
                Id = session.Id,
                UserId = session.User.Id,
                SessionToken = session.SessionToken,
                Expires = session.Expires,
                CreatedAt = session.CreatedAt,
                UpdatedAt = session.UpdatedAt,
            };
        }

        public static Session ToSession(this SessionDeleteRequest request)
        {
            return new Session
            {
                Id = request.Id,
                User = new User { Id = request.UserId },
                Expires = request.Expires,
                SessionToken = request.SessionToken,
            };
        }

        public static SessionDeleteResponse ToSessionDeleteResponse(this Session session)
        {
            return new SessionDeleteResponse
            {
                Id = session.Id,
                UserId = session.User.Id,
                SessionToken = session.SessionToken,
                Expires = session.Expires,
                CreatedAt = session.CreatedAt,
                UpdatedAt = session.UpdatedAt,
            };
        }
    }
}
