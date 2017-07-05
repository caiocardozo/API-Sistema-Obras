using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class ContractScopes
    {
        public static bool CreateContractScopeIsValid(this Contract contract)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertIsGreaterThan(contract.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Contract contract,
            int id,
            int constructionId,
            Int16 typeOfContractId,
            int biddingId,
            int vendorCode,
            DateTime? signatureDate,
            decimal contractValue,
            Int16? deadline,
            double? area,
            DateTime? contractDuration,
            string comments,
            int contractOrigin)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(contract.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
