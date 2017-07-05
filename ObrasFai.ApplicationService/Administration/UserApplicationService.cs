using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.Repositories.Administration;
using ObrasFai.Domain.Services.Administration;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Administration
{
    public class UserApplicationService : ApplicationService, IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public User Authenticate(string username, string password)
        {
            return _repository.Authenticate(username, password);
        }


    }
}
