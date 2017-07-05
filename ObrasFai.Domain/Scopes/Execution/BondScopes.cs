using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class BondScopes
    {
        public static bool CreateBondScopeIsValid(this Bond bond)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertIsGreaterThan(bond.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Bond bond, Int16 id, int constructionId, int contractId, Int16 typeOfBondId, DateTime expirationDate, decimal value, string status
            )
        {
            
                return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertIsGreaterThan(bond.ConstructionId, 0, "O código da obra não pode ser nulo;")
                );
          }


    }
}
