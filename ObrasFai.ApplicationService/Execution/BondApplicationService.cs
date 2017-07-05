using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Bond;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class BondApplicationService : ApplicationService, IBondApplicationService
    {
        private IBondRepository _repository;

        public BondApplicationService(IBondRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Bond Create(CreateBondCommand command)
        {
            var bond = new Bond(
                command.ConstructionId,
                command.ContractId,
                command.TypeOfBondId,
                command.ExpirationDate,
                command.Value,
                command.UserIdRegistered
          );
            bond.Create();
            _repository.Create(bond);

            if (Commit())
                return bond;

            return null;
        }

        public Bond Delete(int id)
        {
            var bond = _repository.Get(id);
            _repository.Delete(bond);

            if (Commit())
                return bond;

            return null;
        }

        public List<Bond> Get()
        {
            return _repository.Get();
        }

        public Bond Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Bond> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Bond Update(EditBondCommand command)
        {
            var bond = _repository.Get(command.Id);
            bond.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.ContractId,
                command.TypeOfBondId,
                command.ExpirationDate,
                command.Value,
                command.Status);
            _repository.Update(bond);

            if (Commit())
                return bond;

            return null;
        }

        public Bond UpdateStatus(UpdateStatusBondCommand command)
        {
            var bond = _repository.Get(command.Id);
            if (bond.Status.Equals("Ativo"))
            {
                bond.Inactive();
            }
            else
            {
                bond.Active();
            }
            _repository.Update(bond);

            if (Commit())
                return bond;

            return null;
        }
    }
}
