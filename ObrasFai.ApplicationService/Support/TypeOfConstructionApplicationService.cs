using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfConstruction;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
    public class TypeOfConstructionApplicationService : ApplicationService, ITypeOfConstructionApplicationService
    {
        private ITypeOfConstructionRepository _repository;

        public TypeOfConstructionApplicationService(ITypeOfConstructionRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public TypeOfConstruction Create(CreateTypeOfConstructionCommand command)
        {
            var typeOfBond = new TypeOfConstruction(
                command.Description,
                command.UserIdRegistered
                );
            typeOfBond.Create();
            _repository.Create(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }

        public TypeOfConstruction Delete(int id)
        {
            var typeOfBond = _repository.Get(id);
            _repository.Delete(typeOfBond);

            if (Commit())
                return typeOfBond;

            return null;
        }

        public List<TypeOfConstruction> Get()
        {
            return _repository.Get();
        }

        public TypeOfConstruction Get(int id)
        {
            return _repository.Get(id);
        }

        public List<TypeOfConstruction> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public TypeOfConstruction Update(EditTypeOfConstructionCommand command)
        {
            var typeOfConstruction = _repository.Get(command.Id);
            typeOfConstruction.UpdateInfo(
                command.Description,
                command.Status
               );
            _repository.Update(typeOfConstruction);

            if (Commit())
                return typeOfConstruction;

            return null;
        }

        public TypeOfConstruction UpdateStatus(UpdateStatusTOConstructionCommand command)
        {
            var typeOfConstruction = _repository.Get(command.Id);
            if (typeOfConstruction.Status.Equals("Ativo"))
            {
                typeOfConstruction.Inactive();
            }
            else
            {
                typeOfConstruction.Active();
            }
            _repository.Update(typeOfConstruction);

            if (Commit())
                return typeOfConstruction;

            return null;
        }
    }
}
