using System;

namespace ObrasFai.Domain.Commands.Execution.ContractRate
{
   public class EditContractRateCommand
    {
        public EditContractRateCommand(
            int id,
            int contractId,
            int constructionId,
            Int16 typeOfContractId,
            Int16 companyCode,
            Int16 affiliateCode,
            int purchaseOrderNumber,
            string serviceTransactionCode,
            string dateOfIssue,
            int userCode,
            int vendorCode,
            string paymentConditionCode,
            Int16 itemSequence,
            string serviceCode,
            decimal apportionmentValue,
            int projectNumber,
            int projectPhaseCode,
            int financialAccountCode,
            int costCenterCode,
            int purchaseOrderOrigin,
            int userIdUpdated
        )
        {
            Id = id;
            ContractId = contractId;
            ConstructionId = constructionId;
            TypeOfContractId = typeOfContractId;
            CompanyCode = companyCode;
            AffiliateCode = affiliateCode;
            PurchaseOrderNumber = purchaseOrderNumber;
            ServiceTransactionCode = serviceTransactionCode;
            DateOfIssue = Convert.ToDateTime(dateOfIssue);
            UserCode = userCode;
            VendorCode = vendorCode;
            PaymentConditionCode = paymentConditionCode;
            ItemSequence = itemSequence;
            ServiceCode = serviceCode;
            ApportionmentValue = apportionmentValue;
            ProjectNumber = projectNumber;
            ProjectPhaseCode = projectPhaseCode;
            FinancialAccountCode = financialAccountCode;
            CostCenterCode = costCenterCode;
            PurchaseOrderOrigin = purchaseOrderOrigin;
            UserIdUpdated = userIdUpdated;

        }

        public int Id { get; set; }
        public int ContractId { get; set; }
        public int ConstructionId { get; set; }
        public Int16 TypeOfContractId { get; set; }
        public Int16 CompanyCode { get; set; }
        public Int16 AffiliateCode { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public string ServiceTransactionCode { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int UserCode { get; set; }
        public int VendorCode { get; set; }
        public string PaymentConditionCode { get; set; }
        public Int16 ItemSequence { get; set; }
        public string ServiceCode { get; set; }
        public decimal ApportionmentValue { get; set; }
        public int ProjectNumber { get; set; }
        public int ProjectPhaseCode { get; set; }
        public int FinancialAccountCode { get; set; }
        public int CostCenterCode { get; set; }
        public int PurchaseOrderOrigin { get; set; }
        public int UserIdUpdated { get; set; }
    }
}
