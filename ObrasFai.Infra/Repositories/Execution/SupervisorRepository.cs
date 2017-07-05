using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class SupervisorRepository : ISupervisorRepository
    {
        private ObrasFaiDataContext _context;

        public SupervisorRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Supervisor supervisor)
        {
            _context.Supervisors.Add(supervisor);
        }

        public void Delete(Supervisor supervisor)
        {
            _context.Supervisors.Remove(supervisor);
        }

        public List<Supervisor> Get()
        {

            return _context.Supervisors.OrderBy(c => c.Id).ToList();
        }

        public Supervisor Get(int id)
        {
            return _context.Supervisors.Find(id);
        }

        public List<Supervisor> Get(int skip, int take)
        {
            return _context.Supervisors.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Supervisor supervisor)
        {
            _context.Entry<Supervisor>(supervisor).State = EntityState.Modified;
        }
    }
}
