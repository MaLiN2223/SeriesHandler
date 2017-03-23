using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using SeriesHandler.Database.Proxy.Functions;

namespace SeriesHandler.Web.Api.Infrastructure
{
#pragma warning disable 1591
    public class AuthorizationServer : OAuthAuthorizationServerProvider
    {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            context.Validated();
        }

#pragma warning disable 1998
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
#pragma warning restore 1998
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            var user = UserFunctions.GetUser(context.Password, context.UserName);
            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            if (identity.IsAuthenticated)//&& (user.IsAdmin() || user.IsActive()))
            {
                //TODO : user claims
                //identity.AddClaim(new Claim("sub", context.UserName));

                //string role;
                //role = user.IsAdmin() ? "admin" : "user";
                //identity.AddClaim(new Claim(ClaimTypes.Role, role));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
                identity.AddClaim(new Claim(ClaimTypes.Surname, user.Surname));
                identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                identity.AddClaim(new Claim(ClaimTypes.Dns, context.Request.RemoteIpAddress));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "This user cannot be authenticated.");
            }

        }



    }
}