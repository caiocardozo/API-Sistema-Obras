using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;
using System;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class SupervisorConstructionScopes
    {
        public static bool CreateSupervisorCScopeIsValid(this SupervisorConstruction supervisor)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(supervisor.SupervisorId,0 , "Supervisor inválido")
               
            );
        }

        public static bool EditSupervisorCScopeIsValid(this SupervisorConstruction supervisor,
             int constructionId,
             Int16 supervisorId,
             string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(supervisor.SupervisorId, 0, "Supervisor inválido")

            );
        }

    }
}
