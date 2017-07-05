using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class BiddingRepository : IBiddingRepository
    {
        private ObrasFaiDataContext _context;

        public BiddingRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Bidding bidding)
        {
            _context.Biddings.Add(bidding);
        }

        public void Delete(Bidding bidding)
        {
            _context.Biddings.Remove(bidding);
        }

        public List<Bidding> Get()
        {
            return _context.Biddings.ToList();
        }

        public Bidding Get(int id)
        {
            return _context.Biddings.Find(id);
        }

        public List<Bidding> Get(int skip, int take)
        {
            return _context.Biddings.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Bidding bidding)
        {
            _context.Entry<Bidding>(bidding).State = EntityState.Modified;
        }

        //return all biddings of a construction
        public List<Bidding> GetBiddingsConstruction(int idConstruction)
        {
            return _context.Biddings.Include(b => b.BiddingApportionment).Include(d => d.Contracts).Where(c => c.ConstructionId == idConstruction).ToList();
        }
    }
}
