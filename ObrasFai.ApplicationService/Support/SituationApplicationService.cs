using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.Situation;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
   public class SituationApplicationService : ApplicationService, ISituationApplicationService
    {
        private ISituationRepository _repository;

        public SituationApplicationService(ISituationRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Situation Create(CreateSituationCommand command)
        {
            var situation = new Situation(command.Description, 1);
            situation.Create();
            _repository.Create(situation);

            if (Commit())
                return situation;

            return null;
        }

        public Situation Delete(int id)
        {
            var situation = _repository.Get(id);
            _repository.Delete(situation);

            if (Commit())
                return situation;

            return null;
        }

        public List<Situation> Get()
        {
            return _repository.Get();
        }

        public Situation Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Situation> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Situation Update(EditSituationCommand command)
        {
            var situation = _repository.Get(command.Id);
            situation.Update(command.Description, command.Status);
            _repository.Update(situation);

            if (Commit())
                return situation;

            return null;
        }

        public Situation UpdateStatus(UpdateStatusSituationCommand command)
        {
            var situation = _repository.Get(command.Id);
            if (situation.Status.Equals("Ativo"))
            {
                situation.Inactive();
            }
            else
            {
                situation.Active();
            }
            _repository.Update(situation);

            if (Commit())
                return situation;

            return null;
        }
    }
}
