using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Contract;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
   public class ContractApplicationService : ApplicationService, IContractApplicationService
    {
        private IContractRepository _repository;

        public ContractApplicationService(IContractRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Contract Create(CreateContractCommand command)
        {
            var contract = new Contract(
                command.ConstructionId,
                command.TypeOfContractId,
                command.BiddingId,
                command.VendorCode,
                command.SignatureDate,
                command.ContractValue,
                command.Deadline,
                command.Area,
                command.ContractDuration,
                command.Comments,
                command.ContractOrigin,
                command.UserIdRegistered
          );
            contract.Create();
            _repository.Create(contract);

            if (Commit())
                return contract;

            return null;
        }

        public Contract Delete(int id)
        {
            var contract = _repository.Get(id);
            _repository.Delete(contract);

            if (Commit())
                return contract;

            return null;
        }

        public List<Contract> Get()
        {
            return _repository.Get();
        }

        public Contract Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Contract> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Contract Update(EditContractCommand command)
        {
            var contract = _repository.Get(command.Id);
            contract.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.TypeOfContractId,
                command.BiddingId,
                command.VendorCode,
                command.SignatureDate,
                command.ContractValue,
                command.Deadline,
                command.Area,
                command.ContractDuration,
                command.Comments,
                command.ContractOrigin,
                command.UserIdUpdated);
            _repository.Update(contract);

            if (Commit())
                return contract;

            return null;
        }

        public List<Contract> GetContractsConstruction(int idConstruction)
        {
            return _repository.GetContractsConstruction(idConstruction);
        }

    }
}
