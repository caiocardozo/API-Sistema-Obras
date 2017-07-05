using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
    public class NatureOfObservationRepository : INatureOfObservationRepository
    {
        private ObrasFaiDataContext _context;

        public NatureOfObservationRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(NatureOfObservation natureOfObservation)
        {
            _context.NatureOfObservations.Add(natureOfObservation);
        }

        public void Delete(NatureOfObservation natureOfObservation)
        {
            _context.NatureOfObservations.Remove(natureOfObservation);
        }

        public List<NatureOfObservation> Get()
        {
            return _context.NatureOfObservations.OrderBy(c => c.Id).ToList();
        }

        public NatureOfObservation Get(int id)
        {
            return _context.NatureOfObservations.Find(id);
        }

        public List<NatureOfObservation> Get(int skip, int take)
        {
            return _context.NatureOfObservations.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(NatureOfObservation natureOfObservation)
        {
            _context.Entry<NatureOfObservation>(natureOfObservation).State = EntityState.Modified;
        }
    }
}
