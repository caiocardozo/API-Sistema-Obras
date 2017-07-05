using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class SupervisorConstructionRepository : ISupervisorConstructionRepository
    {
        private ObrasFaiDataContext _context;

        public SupervisorConstructionRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(SupervisorConstruction supervisorConstruction)
        {
            _context.SupervisorConstructions.Add(supervisorConstruction);
        }

        public void Delete(SupervisorConstruction supervisorConstruction)
        {
            _context.SupervisorConstructions.Remove(supervisorConstruction);
        }

        public List<SupervisorConstruction> Get()
        {
            return _context.SupervisorConstructions.OrderBy(c => c.Id).ToList();
        }

        public SupervisorConstruction Get(int id)
        {
            return _context.SupervisorConstructions.Find(id);
        }

        public List<SupervisorConstruction> Get(int skip, int take)
        {
            return _context.SupervisorConstructions.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(SupervisorConstruction supervisorConstruction)
        {
            _context.Entry<SupervisorConstruction>(supervisorConstruction).State = EntityState.Modified;
        }
    }
}
