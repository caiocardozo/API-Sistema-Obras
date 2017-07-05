using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.SupervisorConstruction;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class SupervisorConstructionApplicationService : ApplicationService, ISupervisorConstructionApplicationService
    {
        private ISupervisorConstructionRepository _repository;

        public SupervisorConstructionApplicationService(ISupervisorConstructionRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public SupervisorConstruction Create(CreateSupervisorConstructionCommand command)
        {
            var supervisorConstruction = new SupervisorConstruction(
                command.ConstructionId,
                command.SupervisorId,
                command.UserIdRegistered);
            supervisorConstruction.Create();
            _repository.Create(supervisorConstruction);

            if (Commit())
                return supervisorConstruction;

            return null;
        }

        public SupervisorConstruction Delete(int id)
        {
            var supervisorConstruction = _repository.Get(id);
            _repository.Delete(supervisorConstruction);

            if (Commit())
                return supervisorConstruction;

            return null;
        }

        public List<SupervisorConstruction> Get()
        {
            return _repository.Get();
        }

        public SupervisorConstruction Get(int id)
        {
            return _repository.Get(id);
        }

        public List<SupervisorConstruction> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public SupervisorConstruction Update(EditSupervisorConstructionCommand command)
        {
            var supervisorConstruction = _repository.Get(command.Id);
            supervisorConstruction.Update(
                command.Id,
                command.ConstructionId,
                command.SupervisorId,
                command.Status
               );
            _repository.Update(supervisorConstruction);

            if (Commit())
                return supervisorConstruction;

            return null;
        }

        public SupervisorConstruction UpdateStatus(UpdateStatusSupervisorConstructionCommand command)
        {
            var supervisorConstruction = _repository.Get(command.Id);
            if (supervisorConstruction.Status.Equals("Ativo"))
            {
                supervisorConstruction.Inactive();
            }
            else
            {
                supervisorConstruction.Active();
            }
            _repository.Update(supervisorConstruction);

            if (Commit())
                return supervisorConstruction;

            return null;
        }
    }
}
