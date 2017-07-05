using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class SituationScopes
    {
        public static bool CreateSituationScopeIsValid(this Situation situation)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(situation.Description, "A Descrição é obrigatória"),
                AssertionConcern.AssertIsGreaterThan(situation.UserIdRegistered,0,"Usuario nao pode ser 0")
            );
        }

        public static bool EditSituationScopeIsValid(this Situation situation,
            string description,
            string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(description, "A Descrição é obrigatório"),
                AssertionConcern.AssertNotEmpty(situation.Status.ToString(), "Usuario nao pode ser criado com status de inativo")
            );
        }
    }
}
