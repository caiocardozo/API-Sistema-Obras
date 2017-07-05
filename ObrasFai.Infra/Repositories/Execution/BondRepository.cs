using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class BondRepository : IBondRepository
    {
        private ObrasFaiDataContext _context;

        public BondRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Bond bond)
        {
            _context.Bonds.Add(bond);
        }

        public void Delete(Bond bond)
        {
            _context.Bonds.Remove(bond);
        }

        public List<Bond> Get()
        {
            return _context.Bonds.OrderBy(c => c.Id).ToList();
        }

        public Bond Get(int id)
        {
            return _context.Bonds.Find(id);
        }

        public List<Bond> Get(int skip, int take)
        {
            return _context.Bonds.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Bond bond)
        {
            _context.Entry<Bond>(bond).State = EntityState.Modified;
        }
    }
}
