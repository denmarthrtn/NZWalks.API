using Microsoft.AspNetCore.Identity;

namespace RestDemo.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
