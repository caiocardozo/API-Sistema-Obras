using System;
using System.Linq.Expressions;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Shared.Helpers;

namespace ObrasFai.Domain.Specs.Administration
{
    public static class UserSpecs
    {
        public static Expression<Func<User, bool>> AuthenticateUser(string email, string password)
        {
            string encriptedPassword = StringHelper.Encrypt(password);
            return x => x.Username == email && x.Password == encriptedPassword;
        }

        }
}
