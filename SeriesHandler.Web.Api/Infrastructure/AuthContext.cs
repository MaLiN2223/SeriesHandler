using Microsoft.AspNet.Identity.EntityFramework;

namespace SeriesHandler.Web.Api.Infrastructure
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