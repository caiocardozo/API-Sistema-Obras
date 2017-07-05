using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Bidding;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Infra.Persistence;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.ApplicationService.Execution
{
    public class BiddingApplicationService : ApplicationService, IBiddingApplicationService
    {
        private IBiddingRepository _repository;

        public BiddingApplicationService(IBiddingRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Bidding Create(CreateBiddingCommand command)
        {
            var bidding = new Bidding(
                command.ConstructionId,
                command.BiddingShoppingPortalId, 
                command.Amount, 
                command.ExecutionTime);
            bidding.Create();
            _repository.Create(bidding);

            if (Commit())
                return bidding;

            return null;
        }

        public Bidding Delete(int id)
        {
            var bidding = _repository.Get(id);
            _repository.Delete(bidding);

            if (Commit())
                return bidding;

            return null;
        }

        public List<Bidding> Get()
        {
            return _repository.Get();
        }

        public Bidding Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Bidding> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Bidding Update(EditBiddingCommand command)
        {
            var bidding = _repository.Get(command.Id);
            bidding.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.BiddingShoppingPortalId,
                command.Amount,
                command.ExecutionTime);
            _repository.Update(bidding);

            if (Commit())
                return bidding;

            return null;
        }

        //return biddings of a construction
        public List<Bidding> GetBiddingsConstruction(int idConstruction)
        {
            return _repository.GetBiddingsConstruction(idConstruction);
        }
    }
}
