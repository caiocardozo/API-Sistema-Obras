using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Bidding;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface IBiddingApplicationService
    {
        List<Bidding> Get();
        List<Bidding> Get(int skip, int take);
        Bidding Get(int id);
        Bidding Create(CreateBiddingCommand command);
        Bidding Update(EditBiddingCommand command);
        Bidding Delete(int id);
        //return all biddings of a construction
        List<Bidding> GetBiddingsConstruction(int isCOnstruction);

       }
}
