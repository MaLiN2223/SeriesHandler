﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SeriesHandler.Web.Api.Infrastructure
{
#pragma warning disable 1591
    public sealed class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(LoginCredentials userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.Login
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }
        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }

    public class LoginCredentials
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}