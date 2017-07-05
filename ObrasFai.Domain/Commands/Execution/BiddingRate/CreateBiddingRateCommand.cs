using System;

namespace ObrasFai.Domain.Commands.Execution.BiddingRate
{
    public class CreateBiddingRateCommand
    {
        public CreateBiddingRateCommand(
            int biddingId,
            int constructionId,
            Int16 biddingShoppingPortalId,
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
            BiddingId = biddingId;
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
            ItemSequence = itemSequence;
            ServiceCode = serviceCode;
            ApportionmentValue = apportionmentValue;
            ProjectNumber = projectNumber;
            ProjectPhaseCode = projectPhaseCode;
            FinancialAccountCode = financialAccountCode;
            CostCenterCode = costCenterCode;
            UserIdRegistered = userIdRegistered;
            
        }

        public int ContractRateId { get; private set; }
        public int BiddingId { get; private set; }
        public int ConstructionId { get; private set; }
        public Int16 BiddingShoppingPortalId { get; private set; }
        public Int16 CompanyCode { get; private set; }
        public Int16 AffiliateCode { get; private set; }
        public int PurchaseOrderNumber { get; private set; }
        public string ServiceTransactionCode { get; private set; }
        public DateTime DateOfIssue { get; private set; }
        public int UserCode { get; private set; }
        public int VendorCode { get; private set; }
        public string PaymentConditionCode { get; private set; }
        public Int16 ItemSequence { get; private set; }
        public string ServiceCode { get; private set; }
        public decimal ApportionmentValue { get; private set; }
        public int ProjectNumber { get; private set; }
        public int ProjectPhaseCode { get; private set; }
        public int FinancialAccountCode { get; private set; }
        public int CostCenterCode { get; private set; }
        public int UserIdRegistered { get; set; }
    }
}
