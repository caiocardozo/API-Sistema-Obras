using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfInspection;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
    public class TypeOfInspectionApplicationService : ApplicationService, ITypeOfInspectionApplicationService
    {
        private ITypeOfInspectionRepository _repository;

        public TypeOfInspectionApplicationService(ITypeOfInspectionRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public TypeOfInspection Create(CreateTypeOfInspectionCommand command)
        {
            var typeInspection = new TypeOfInspection(
                command.Description,
                command.UserIdRegistered
                );
            typeInspection.Create();
            _repository.Create(typeInspection);

            if (Commit())
                return typeInspection;

            return null;
        }

        public TypeOfInspection Delete(int id)
        {
            var typeInspection = _repository.Get(id);
            _repository.Delete(typeInspection);

            if (Commit())
                return typeInspection;

            return null;
        }

        public List<TypeOfInspection> Get()
        {
            return _repository.Get();
        }

        public TypeOfInspection Get(int id)
        {
            return _repository.Get(id);
        }

        public List<TypeOfInspection> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public TypeOfInspection Update(EditTypeOfInspectionCommand command)
        {
            var typeInspection = _repository.Get(command.Id);
            typeInspection.UpdateInfo(
                command.Description,
                command.Status
               );
            _repository.Update(typeInspection);

            if (Commit())
                return typeInspection;

            return null;
        }

        public TypeOfInspection UpdateStatus(UpdateStatusTOInspectionCommand command)
        {
            var typeOfInspection = _repository.Get(command.Id);
            if (typeOfInspection.Status.Equals("Ativo"))
            {
                typeOfInspection.Inactive();
            }
            else
            {
                typeOfInspection.Active();
            }
            _repository.Update(typeOfInspection);

            if (Commit())
                return typeOfInspection;

            return null;
        }
    }
}
