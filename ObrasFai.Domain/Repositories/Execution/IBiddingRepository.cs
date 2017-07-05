using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IBiddingRepository 
    {
        List<Bidding> Get();
        List<Bidding> Get(int skip, int take);
        Bidding Get(int id);
        void Create(Bidding bidding);
        void Update(Bidding bidding);
        void Delete(Bidding bidding);

        //return biddings of a construction
        List<Bidding> GetBiddingsConstruction(int idConstruction);

    }
}
