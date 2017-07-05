using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class SupervisorScopes
    {
        public static bool CreateSupervisorScopeIsValid(this Supervisor supervisor)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(supervisor.Name, "O nome é obrigatório"),
              //   AssertionConcern.AssertNotEmpty(supervisor.Cpf, "O cpf é obrigatório"),
                  AssertionConcern.AssertNotEmpty(supervisor.Name, "O nome é obrigatório"),
                   AssertionConcern.AssertNotEmpty(supervisor.Name, "O nome é obrigatório"),
                    AssertionConcern.AssertNotEmpty(supervisor.Name, "O nome é obrigatório")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Supervisor supervisor, Int16 id,
            string name,
            Int64 cpf,
            string email,
            string phone,
            string phoneTwo,
            Int16 typeInspectionId,
            string status,
            string creaNumber)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(supervisor.TypeInspectionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
