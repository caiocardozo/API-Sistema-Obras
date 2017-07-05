using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.ContractRate;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class ContractRateApplicationService : ApplicationService, IContractRateApplicationService
    {
        private IContractRateRepository _repository;

        public ContractRateApplicationService(IContractRateRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public ContractRate Create(CreateContractRateCommand command)
        {
            var contractRate = new ContractRate(
                command.ContractId,
                command.ConstructionId,
                command.TypeOfContractId,
                command.CompanyCode,
                command.AffiliateCode,
                command.ItemSequence,
                command.ServiceCode,
                command.ApportionmentValue,
                command.ProjectNumber,
                command.ProjectPhaseCode,
                command.FinancialAccountCode,
                command.CostCenterCode,
                command.UserIdRegistered
            );
            contractRate.Create();
            _repository.Create(contractRate);

            if (Commit())
                return contractRate;

            return null;
        }

        public ContractRate Delete(int id)
        {
            var contractRate = _repository.Get(id);
            _repository.Delete(contractRate);

            if (Commit())
                return contractRate;

            return null;
        }

        public List<ContractRate> Get()
        {
            return _repository.Get();
        }

        public ContractRate Get(int id)
        {
            return _repository.Get(id);
        }

        public List<ContractRate> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public ContractRate Update(EditContractRateCommand command)
        {
            var contractRate = _repository.Get(command.Id);
            contractRate.UpdateInfo(
                command.Id,
                command.ContractId,
                command.ConstructionId,
                command.TypeOfContractId,
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
                command.PurchaseOrderOrigin,
                command.UserIdUpdated);
            _repository.Update(contractRate);

            if (Commit())
                return contractRate;

            return null;
        }
    }
}
