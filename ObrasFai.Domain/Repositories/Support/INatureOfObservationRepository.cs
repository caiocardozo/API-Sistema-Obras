using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface INatureOfObservationRepository
    {
        List<NatureOfObservation> Get();
        List<NatureOfObservation> Get(int skip, int take);
        NatureOfObservation Get(int id);
        void Create(NatureOfObservation natureOfObservation);
        void Update(NatureOfObservation natureOfObservation);
        void Delete(NatureOfObservation natureOfObservation);
    }
}
