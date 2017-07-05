using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Domain.Commands.Execution.Construction;

namespace ObrasFai.ApplicationService.Execution
{
    public class ConstructionApplicationService : ApplicationService, IConstructionApplicationService
    {
        private IConstructionRepository _repository;

        public ConstructionApplicationService(IConstructionRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Construction Create(CreateConstructionCommand command)
        {
            var construction = new Construction(
                command.Nickname,
                command.Description,
                command.Name,
                command.CampId,
                command.TypeOfConstructionId,
                command.SituationId,
                command.TypeInspectionId,
                command.StartDate,
                command.EndDate,
                command.ContractTerminationDate,
                command.SignatureDate,
                command.Area,
                command.EstimatedValue,
                command.UserIdRegistered);
            construction.Register();
            _repository.Create(construction);

            if (Commit())
                return construction;

            return null;
        }

        public Construction Delete(int id)
        {
            var construction = _repository.Get(id);
            _repository.Delete(construction);

            if (Commit())
                return construction;

            return null;
        }

        public List<Construction> Get()
        {
            return _repository.Get();
        }

        public List<Construction> GetAllListHome()
        {
            return _repository.GetAllListHome();
        }

        public Construction Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Construction> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Construction Update(EditConstructionCommand command)
        {
            var construction = _repository.Get(command.Id);
            construction.Update(
                command.Nickname, 
                command.Description, 
                command.Name, 
                command.CampId, 
                command.TypeOfConstructionId,
                command.SituationId,
                command.TypeInspectionId, 
                command.StartDate, 
                command.EndDate, 
                command.ContractTerminationDate,
                command.SignatureDate,
                command.Area, 
                command.EstimatedValue,
                command.UserIdUpdated);
            _repository.Update(construction);

            if (Commit())
                return construction;

            return null;
        }
    }
}
