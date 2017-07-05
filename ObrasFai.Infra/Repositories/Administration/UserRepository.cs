using System.Linq;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.Repositories.Administration;
using ObrasFai.Domain.Specs.Administration;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Administration
{
    public class UserRepository : IUserRepository
    {
        private ObrasFaiDataContext _context;

        public UserRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public User Authenticate(string email, string password)
        {
            return _context.Users
                .Where(UserSpecs.AuthenticateUser(email, password))
                .FirstOrDefault();
        }


    }
}

