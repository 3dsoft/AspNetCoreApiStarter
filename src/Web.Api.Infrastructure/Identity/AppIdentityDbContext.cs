using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Web.Api.Infrastructure.Identity
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser<int>, IdentityRole<int>, int>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }
    }
}
