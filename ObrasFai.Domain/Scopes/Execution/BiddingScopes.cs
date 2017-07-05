using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class BiddingScopes
    {
        public static bool CreateBiddingScopeIsValid(this Bidding bidding)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(bidding.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Bidding bidding,
            int id,
            int constructionId,
            int biddingShoppingPortalId,
            decimal amount,
            Int16 executionTime)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(bidding.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
