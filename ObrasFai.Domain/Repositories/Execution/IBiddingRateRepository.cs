using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IBiddingRateRepository
    {
        List<BiddingRate> Get();
        List<BiddingRate> Get(int skip, int take);
        BiddingRate Get(int id);
        void Create(BiddingRate biddingRate);
        void Update(BiddingRate biddingRate);
        void Delete(BiddingRate biddingRate);

        List<BiddingRate> GetBAConstruction(int idbidding);
    }
}
