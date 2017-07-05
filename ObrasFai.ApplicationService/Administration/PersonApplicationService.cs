using System.Collections.Generic;
using ObrasFai.Domain.Commands.Administration.Person;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.Repositories.Administration;
using ObrasFai.Domain.Services.Administration;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Administration
{
    public class PersonApplicationService : ApplicationService, IPersonApplicationService
    {
        private IPersonRepository _repository;

        public PersonApplicationService(IPersonRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Person Create(CreatePersonCommand command)
        {
            var person = new Person(command.Name,command.BirthDate, command.Email, command.Cpf, command.Username, command.Password);
            person.Create();
            _repository.Create(person);

            if (Commit())
                return person;

            return null;
        }

        public Person Delete(int id)
        {
            var person = _repository.Get(id);
            _repository.Delete(person);

            if (Commit())
                return person;

            return null;
        }

        public List<Person> Get()
        {
            return _repository.Get();
        }

        public Person Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Person> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Person Update(EditPersonCommand command)
        {
            var person = _repository.Get(command.Id);
            person.UpdateInfo(command.Id,command.Name, command.BirthDate, command.Email, command.Cpf, command.Username, command.Password);
            _repository.Update(person);

            if (Commit())
                return person;

            return null;
        }
    }
}

