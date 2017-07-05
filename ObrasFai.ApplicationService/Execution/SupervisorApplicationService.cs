using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Supervisor;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class SupervisorApplicationService : ApplicationService, ISupervisorApplicationService
    {
        private ISupervisorRepository _repository;

        public SupervisorApplicationService(ISupervisorRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Supervisor Create(CreateSupervisorCommand command)
        {
            var supervisor = new Supervisor(
                command.Name,
                command.Cpf,
                command.Email,
                command.Phone,
                command.PhoneTwo,
                command.TypeInspectionId,
                command.CreaNumber,
                command.UserIdRegistered);
            supervisor.Create();
            _repository.Create(supervisor);

            if (Commit())
                return supervisor;

            return null;
        }

        public Supervisor Delete(int id)
        {
            var supervisor = _repository.Get(id);
            _repository.Delete(supervisor);

            if (Commit())
                return supervisor;

            return null;
        }

        public List<Supervisor> Get()
        {
            return _repository.Get();
        }

        public Supervisor Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Supervisor> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Supervisor Update(EditSupervisorCommand command)
        {
            var supervisor = _repository.Get(command.Id);
            supervisor.Update(
                command.Id,
                command.Name,
                command.Cpf,
                command.Email,
                command.Phone,
                command.PhoneTwo,
                command.TypeInspectionId,
                command.Status,
                command.CreaNumber
               );
            _repository.Update(supervisor);

            if (Commit())
                return supervisor;

            return null;
        }

        public Supervisor UpdateStatus(UpdateStatusSupervisorCommand command)
        {
            var supervisor = _repository.Get(command.Id);
            if (supervisor.Status.Equals("Ativo"))
            {
                supervisor.Inactive();
            }
            else
            {
                supervisor.Active();
            }
            _repository.Update(supervisor);

            if (Commit())
                return supervisor;

            return null;
        }
    }
}
