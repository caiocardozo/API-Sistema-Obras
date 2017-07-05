using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
   public class SituationRepository : ISituationRepository
    {
        private ObrasFaiDataContext _context;

        public SituationRepository(ObrasFaiDataContext context)
        {
            this._context = context;
        }

        public void Create(Situation situation)
        {
            _context.Situations.Add(situation);
        }

        public void Delete(Situation situation)
        {
            _context.Situations.Remove(situation);
        }

        public List<Situation> Get()
        {
            return _context.Situations.OrderBy(s => s.Id).ToList();
        }

        public Situation Get(int id)
        {
            return _context.Situations.Find(id);
        }

        public List<Situation> Get(int skip, int take)
        {
            return _context.Situations.OrderBy(x => x.Description).Skip(skip).Take(take).ToList();
        }

        public void Update(Situation situation)
        {
            _context.Entry<Situation>(situation).State = EntityState.Modified;
        }
    }
}
