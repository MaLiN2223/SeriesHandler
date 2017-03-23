using Microsoft.AspNet.Identity.EntityFramework;
namespace SeriesHandler.WebApi.Infrastructure
{
#pragma warning disable 1591
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
               : base("AuthContext")
        {

        }
    }
}