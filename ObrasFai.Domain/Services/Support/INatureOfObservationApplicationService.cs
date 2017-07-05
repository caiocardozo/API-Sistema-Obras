using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.NatureOfObservation;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface INatureOfObservationApplicationService
    {
        List<NatureOfObservation> Get();
        List<NatureOfObservation> Get(int skip, int take);
        NatureOfObservation Get(int id);
        NatureOfObservation Create(CreateNatureOfObservationCommand command);
        NatureOfObservation Update(EditNatureOfObservationCommand command);
        NatureOfObservation Delete(int id);
        NatureOfObservation UpdateStatus(UpdateStatusNatureOfObservationCommand command);
        NatureOfObservation UpdateInternallyAvaliable(UpdateIAvaliableNatureOfObservationCommand command);
    }
}
