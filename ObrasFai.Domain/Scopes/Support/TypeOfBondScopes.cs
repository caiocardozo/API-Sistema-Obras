using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class TypeOfBondScopes
    {
        public static bool CreateTypeOfBondScopeIsValid(this TypeOfBond typeOfBond)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(typeOfBond.Description, "A Descrição é obrigatória")
            //AssertionConcern.AssertAreEquals(situation.Status.ToString(),status.Ativo, "Usuario nao pode ser criado com status de inativo")
            );
        }

        public static bool EditScopeIsValid(this TypeOfBond typeOfBond,
            string description,
            string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(description, "A Descrição é obrigatório"),
                AssertionConcern.AssertNotEmpty(typeOfBond.Status.ToString(), "Usuario nao pode ser criado com status de inativo")
            );
        }
    }
}
