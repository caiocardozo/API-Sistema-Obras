using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class ContractRateScopes
    {
        public static bool CreateContractRateScopeIsValid(this ContractRate contractRate)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(contractRate.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this ContractRate contractRate,
            int id,
            int contractId,
            int constructionId,
            Int16 typeOfContractId,
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
            int purchaseOrderOrigin,
            int lastUpdatedDate)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(contractRate.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
