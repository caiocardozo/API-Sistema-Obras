using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Domain.Services.Administration
{
    public interface IUserApplicationService
    {
        User Authenticate(string email, string password);
    }
}
