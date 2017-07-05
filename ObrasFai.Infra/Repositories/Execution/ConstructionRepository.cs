using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class ConstructionRepository : IConstructionRepository
    {
        private ObrasFaiDataContext _context;

        public ConstructionRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }
        public void Create(Construction construction)
        {
            _context.Constructions.Add(construction);
        }

        public void Delete(Construction construction)
        {
            _context.Constructions.Remove(construction);
        }

        public List<Construction> Get()
        {
            return _context.Constructions.OrderBy(c => c.Id).ToList();
        }

        public List<Construction> GetAllListHome()
        {
            ////var variavel =  _context.Constructions.Include(d => d.Situation)
            //    .Include(e => e.TypeInspection)
            //    .OrderByDescending(a => a.Situation.Description);
            //return variavel;
            return _context.Constructions.Include(x => x.Situation).Include(x => x.TypeOfConstruction).OrderByDescending(c => c.Situation.Description).ThenByDescending(a => a.Id).ToList();
        }

        public Construction Get(int id)
        {
            return _context.Constructions.Find(id);
        }

        public List<Construction> Get(int skip, int take)
        {
            return _context.Constructions.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Construction construction)
        {
            _context.Entry<Construction>(construction).State = EntityState.Modified;
        }
    }
}
