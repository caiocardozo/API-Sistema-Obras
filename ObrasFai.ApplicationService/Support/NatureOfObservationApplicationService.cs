using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.NatureOfObservation;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
   public class NatureOfObservationApplicationService : ApplicationService, INatureOfObservationApplicationService
    {
        private INatureOfObservationRepository _repository;

        public NatureOfObservationApplicationService(INatureOfObservationRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public NatureOfObservation Create(CreateNatureOfObservationCommand command)
        {
            var natureOfObservation = new NatureOfObservation(
                command.Description,
                command.InternallyAvailable,
                command.UserIdRegistered);
            natureOfObservation.Create();
            _repository.Create(natureOfObservation);

            if (Commit())
                return natureOfObservation;

            return null;
        }

        public NatureOfObservation Delete(int id)
        {
            var natureOfObservation = _repository.Get(id);
            _repository.Delete(natureOfObservation);

            if (Commit())
                return natureOfObservation;

            return null;
        }

        public List<NatureOfObservation> Get()
        {
            return _repository.Get();
        }

        public NatureOfObservation Get(int id)
        {
            return _repository.Get(id);
        }

        public List<NatureOfObservation> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public NatureOfObservation Update(EditNatureOfObservationCommand command)
        {
            var natureOfObservation = _repository.Get(command.Id);
            natureOfObservation.UpdateInfo(
                command.Id,
                command.Description,
                command.Status,
                command.InternallyAvailable
               );
            _repository.Update(natureOfObservation);

            if (Commit())
                return natureOfObservation;

            return null;
        }

        public NatureOfObservation UpdateStatus(UpdateStatusNatureOfObservationCommand command)
        {
            var natureOfObservation = _repository.Get(command.Id);
            if (natureOfObservation.Status.Equals("Ativo"))
            {
                natureOfObservation.Inactive();
            }
            else
            {
                natureOfObservation.Active();
            }
            _repository.Update(natureOfObservation);

            if (Commit())
                return natureOfObservation;

            return null;
        }

        public NatureOfObservation UpdateInternallyAvaliable(UpdateIAvaliableNatureOfObservationCommand command)
        {
            var natureOfObservation = _repository.Get(command.Id);
            if (natureOfObservation.InternallyAvailable.Equals("SIM"))
            {
                natureOfObservation.InternalNo();
            }
            else
            {
                natureOfObservation.InternalYes();
            }
            _repository.Update(natureOfObservation);

            if (Commit())
                return natureOfObservation;

            return null;
        }
    }
}
