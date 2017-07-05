using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Domain.Repositories.Administration
{
    public interface IUserRepository
    {
        User Authenticate(string email, string password);
    }
}
