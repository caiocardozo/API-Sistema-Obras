using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.BiddingRate;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
   public class BiddingRateApplicationService : ApplicationService, IBiddingRateApplicationService
    {
        private IBiddingRateRepository _repository;

        public BiddingRateApplicationService(IBiddingRateRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public BiddingRate Create(CreateBiddingRateCommand command)
        {
            var biddingRate = new BiddingRate(
                command.BiddingId,
                command.ConstructionId,
                command.BiddingShoppingPortalId,
                command.CompanyCode,
                command.AffiliateCode,
                command.PurchaseOrderNumber,
                command.ServiceTransactionCode,
                command.DateOfIssue,
                command.UserCode,
                command.VendorCode,
                command.PaymentConditionCode,
                command.ItemSequence,
                command.ServiceCode,
                command.ApportionmentValue,
                command.ProjectNumber,
                command.ProjectPhaseCode,
                command.FinancialAccountCode,
                command.CostCenterCode,
                command.UserIdRegistered
               );
            biddingRate.Create();
            _repository.Create(biddingRate);

            if (Commit())
                return biddingRate;

            return null;
        }

        public BiddingRate Delete(int id)
        {
            var biddingRate = _repository.Get(id);
            _repository.Delete(biddingRate);

            if (Commit())
                return biddingRate;

            return null;
        }

        public List<BiddingRate> Get()
        {
            return _repository.Get();
        }

        public BiddingRate Get(int id)
        {
            return _repository.Get(id);
        }

        public List<BiddingRate> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public BiddingRate Update(EditBiddingRateCommand command)
        {
            var biddingRate = _repository.Get(command.Id);
            biddingRate.UpdateInfo(
                command.Id,
                command.BiddingId,
                command.ConstructionId,
                command.BiddingShoppingPortalId,
                command.CompanyCode,
                command.AffiliateCode,
                command.PurchaseOrderNumber,
                command.ServiceTransactionCode,
                command.DateOfIssue,
                command.UserCode,
                command.VendorCode,
                command.PaymentConditionCode,
                command.ItemSequence,
                command.ServiceCode,
                command.ApportionmentValue,
                command.ProjectNumber,
                command.ProjectPhaseCode,
                command.FinancialAccountCode,
                command.CostCenterCode,
                command.UserIdUpdated
            );
            _repository.Update(biddingRate);

            if (Commit())
                return biddingRate;

            return null;
        }

        public List<BiddingRate> GetBAConstruction(int idbidding)
        {
            return _repository.GetBAConstruction(idbidding);
        }

    }
}
