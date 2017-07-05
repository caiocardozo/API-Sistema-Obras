using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
   public class BiddingRateRepository : IBiddingRateRepository
    {
        private ObrasFaiDataContext _context;

        public BiddingRateRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(BiddingRate biddingRate)
        {
            _context.BiddingsRate.Add(biddingRate);
        }

        public void Delete(BiddingRate biddingRate)
        {
            _context.BiddingsRate.Remove(biddingRate);
        }

        public List<BiddingRate> Get()
        {
            return _context.BiddingsRate.ToList();
        }

        public BiddingRate Get(int id)
        {
            return _context.BiddingsRate.Find(id);
        }

        public List<BiddingRate> Get(int skip, int take)
        {
            return _context.BiddingsRate.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(BiddingRate biddingRate)
        {
            _context.Entry<BiddingRate>(biddingRate).State = EntityState.Modified;
        }

        //return bidding apportionment of a bidding and construction
        public List<BiddingRate> GetBAConstruction(int idbidding)
        {
            return _context.BiddingsRate.Where(x => x.BiddingId == idbidding).ToList();
        }

    }
}