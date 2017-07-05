using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
   public static class BiddingRateScopes
    {
        public static bool CreateBiddingRateScopeIsValid(this BiddingRate biddingRate)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(biddingRate.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this BiddingRate biddingRate,
            int contractRateId,
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

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(biddingRate.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
