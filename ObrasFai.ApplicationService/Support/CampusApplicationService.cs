using ObrasFai.Domain.Commands.Support.Campus;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;
using System;
using System.Collections.Generic;

namespace ObrasFai.ApplicationService.Support
{
    public class CampusApplicationService : ApplicationService, ICampusApplicationService
    {
        private ICampusRepository _repository;

        public CampusApplicationService(ICampusRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Campus Create(CreateCampusCommand command)
        {
            var campus = new Campus(command.City);
            campus.Create();
            _repository.Create(campus);

            if (Commit())
                return campus;

            return null;
        }

        public Campus Delete(Int16 id)
        {
            var campus = _repository.Get(id);
            _repository.Delete(campus);

            if (Commit())
                return campus;

            return null;
        }

        public List<Campus> Get()
        {
            return _repository.Get();
        }

        public Campus Get(Int16 id)
        {
            return _repository.Get(id);
        }

        public List<Campus> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Campus Update(EditCampusCommand command)
        {
            var campus = _repository.Get(command.Id);
            campus.Update(command.City);
            _repository.Update(campus);

            if (Commit())
                return campus;

            return null;
        }
    }
}
