using Microsoft.AspNetCore.Identity;

namespace Web.Api.Infrastructure.Identity
{
    public class AppUser<T> : IdentityUser<int>
    {
        // Add additional profile data for application users by adding properties to this class
    }
}
