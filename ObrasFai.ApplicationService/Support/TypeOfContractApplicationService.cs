using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfContract;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
    public class TypeOfContractApplicationService : ApplicationService, ITypeOfContractApplicationService
    {
        private ITypeOfContractRepository _repository;

        public TypeOfContractApplicationService(ITypeOfContractRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public TypeOfContract Create(CreateTypeOfContractCommand command)
        {
            var typeOfContract = new TypeOfContract(
                command.Description,
                command.IntegratedSapiens,
                command.ServiceTransaction,
                command.UserIdRegistered
                );
            typeOfContract.Create();
            _repository.Create(typeOfContract);

            if (Commit())
                return typeOfContract;

            return null;
        }

        public TypeOfContract Delete(int id)
        {
            var typeOfContract = _repository.Get(id);
            _repository.Delete(typeOfContract);

            if (Commit())
                return typeOfContract;

            return null;
        }

        public List<TypeOfContract> Get()
        {
            return _repository.Get();
        }

        public TypeOfContract Get(int id)
        {
            return _repository.Get(id);
        }

        public List<TypeOfContract> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public TypeOfContract Update(EditTypeOfContractCommand command)
        {
            var typeOfContract = _repository.Get(command.Id);
            typeOfContract.UpdateInfo(
                command.Description,
                command.IntegratedSapiens,
                command.ServiceTransaction,
                command.Status
               );
            _repository.Update(typeOfContract);

            if (Commit())
                return typeOfContract;

            return null;
        }

        public TypeOfContract UpdateStatus(UpdateStatusTOContractCommand command)
        {
            var typeOfContract = _repository.Get(command.Id);
            if (typeOfContract.Status.Equals("Ativo"))
            {
                typeOfContract.Inactive();
            }
            else
            {
                typeOfContract.Active();
            }
            _repository.Update(typeOfContract);

            if (Commit())
                return typeOfContract;

            return null;
        }

        public TypeOfContract UpdateISapiens(UpdateISapiensTOContractCommand command)
        {
            var typeOfContract = _repository.Get(command.Id);
            if (typeOfContract.IntegratedSapiens.Equals("SIM"))
            {
                typeOfContract.DotNotIntegrate();
            }
            else
            {
                typeOfContract.YesIntegrate();
            }
            _repository.Update(typeOfContract);

            if (Commit())
                return typeOfContract;

            return null;
        }
    }
}
