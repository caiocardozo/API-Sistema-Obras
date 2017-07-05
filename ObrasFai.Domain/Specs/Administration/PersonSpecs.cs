using System;
using System.Linq.Expressions;
using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Domain.Specs.Administration
{
   public static class PersonSpecs
    {
        public static Expression<Func<Person, bool>> GetByEmail(string email)
        {
            return x => x.Email.Address == email;
        }
    }
}
