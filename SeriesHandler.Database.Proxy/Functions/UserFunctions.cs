using System;
using System.Linq;
using SeriesHandler.Database.Connector;
using SeriesHandler.Database.Proxy.DTO.Read;
using ServerLibrary.Utils;


namespace SeriesHandler.Database.Proxy.Functions
{
    public static class UserFunctions
    {
        public static ReadableUser GetUser(string password, string userName)
        {

            var hash = Utilities.Hash(password);
            var salt = Utilities.GenerateSalt();
            var generatedPassword = (Utilities.GeneratePassword(hash, salt));
            using (var db = new Entities())
            {
                var user = db.Users.FirstOrDefault(x => x.username.Equals(userName) && x.password.Equals(generatedPassword));
                return new ReadableUser(user);
            }
        }

    }
}
