using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfBond;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
    public class TypeOfBondApplicationService : ApplicationService, ITypeOfBondApplicationService
    {
        private ITypeOfBondRepository _repository;

        public TypeOfBondApplicationService(ITypeOfBondRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public TypeOfBond Create(CreateTypeOfBondCommand command)
        {
            var typeOfBond = new TypeOfBond(
                command.Description,
                command.UserIdRegistered
                );
            typeOfBond.Create();
            _repository.Create(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }

        public TypeOfBond Delete(int id)
        {
            var typeOfBond = _repository.Get(id);
            _repository.Delete(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }

        public List<TypeOfBond> Get()
        {
            return _repository.Get();
        }

        public TypeOfBond Get(int id)
        {
            return _repository.Get(id);
        }

        public List<TypeOfBond> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public TypeOfBond Update(EditTypeOfBondCommand command)
        {
            var typeOfBond = _repository.Get(command.Id);
            typeOfBond.UpdateInfo(
                command.Description,
                command.Status
               );
            _repository.Update(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }

        public TypeOfBond UpdateStatus(UpdateStatusTOBondCommand command)
        {
            var typeOfBond = _repository.Get(command.Id);
            if (typeOfBond.Status.Equals("Ativo"))
            {
                typeOfBond.Inactive();
            }
            else
            {
                typeOfBond.Active();
            }
            _repository.Update(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }
    }
}
