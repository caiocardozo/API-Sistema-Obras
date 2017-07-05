using System;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class BiddingRate : EntityRegisteredUpdated
    {
        protected BiddingRate() { }

        public BiddingRate(
            int biddingId,
            int constructionId,
            Int16 biddingShoppingPortalId,
            Int16 companyCode,
            Int16 affiliateCode,
            int purchaseOrderNumber,
            string serviceTransactionCode,
            DateTime dateOfIssue,
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
            int userIdRegistered)
        {
            BiddingId = biddingId;
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
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
            UserIdRegistered = userIdRegistered;
            DateOfGeneration = DateTime.Now;
            UserIdUpdated = UserIdRegistered;
            LastUpdatedDate = DateTime.Now;
        }

        public int Id { get; private set; }
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

        public virtual Bidding Bidding { get; private set; }
        public Construction Construction { get; private set; }

        public void Create()
        {
            if (!this.CreateBiddingRateScopeIsValid())
                return;
        }

        public void UpdateInfo(
            int id,
            int biddingId,
            int constructionId,
            Int16 biddingShoppingPortalId,
            Int16 companyCode,
            Int16 affiliateCode,
            int purchaseOrderNumber,
            string serviceTransactionCode,
            DateTime dateOfIssue,
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
            int lastUpdatedDate)
        {
            if (!this.UpdateInfoScopeIsValid(
                id,
                biddingId,
                constructionId,
                biddingShoppingPortalId,
                companyCode,
                affiliateCode,
                purchaseOrderNumber,
                serviceTransactionCode,
                dateOfIssue,
                userCode,
                vendorCode,
                paymentConditionCode,
                itemSequence,
                serviceCode,
                apportionmentValue,
                projectNumber,
                projectPhaseCode,
                financialAccountCode,
                costCenterCode,
                lastUpdatedDate))
                return;

            Id = id;
            BiddingId = biddingId;
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
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
            LastUpdatedDate = DateTime.Now;
        }

    }
}
