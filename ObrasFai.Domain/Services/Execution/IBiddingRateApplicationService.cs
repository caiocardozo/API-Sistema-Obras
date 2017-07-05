using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.BiddingRate;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface IBiddingRateApplicationService
    {
        List<BiddingRate> Get();
        List<BiddingRate> Get(int skip, int take);
        BiddingRate Get(int id);
        BiddingRate Create(CreateBiddingRateCommand command);
        BiddingRate Update(EditBiddingRateCommand command);
        BiddingRate Delete(int id);

        List<BiddingRate> GetBAConstruction(int idbidding);
    }
}
