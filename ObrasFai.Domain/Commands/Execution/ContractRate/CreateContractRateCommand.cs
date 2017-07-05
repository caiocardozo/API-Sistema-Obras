using System;

namespace ObrasFai.Domain.Commands.Execution.ContractRate
{
    public class CreateContractRateCommand
    {
        public CreateContractRateCommand(
            int contractId,
            int constructionId,
            Int16 typeOfContractId,
            Int16 companyCode,
            Int16 affiliateCode,
            Int16 itemSequence,
            string serviceCode,
            decimal apportionmentValue,
            int projectNumber,
            int projectPhaseCode,
            int financialAccountCode,
            int costCenterCode,
            int userIdRegistered
            )
        {
            ContractId = contractId;
            ConstructionId = constructionId;
            TypeOfContractId = typeOfContractId;
            CompanyCode = companyCode;
            AffiliateCode = affiliateCode;
            ItemSequence = itemSequence;
            ServiceCode = serviceCode;
            ApportionmentValue = apportionmentValue;
            ProjectNumber = projectNumber;
            ProjectPhaseCode = projectPhaseCode;
            FinancialAccountCode = financialAccountCode;
            CostCenterCode = costCenterCode;
            UserIdRegistered = userIdRegistered;
           
        }

        public int ContractId { get; set; }
        public int ConstructionId { get; set; }
        public Int16 TypeOfContractId { get; set; }
        public Int16 CompanyCode { get; set; }
        public Int16 AffiliateCode { get; set; }
        public Int16 ItemSequence { get; set; }
        public string ServiceCode { get; set; }
        public decimal ApportionmentValue { get; set; }
        public int ProjectNumber { get; set; }
        public int ProjectPhaseCode { get; set; }
        public int FinancialAccountCode { get; set; }
        public int CostCenterCode { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
