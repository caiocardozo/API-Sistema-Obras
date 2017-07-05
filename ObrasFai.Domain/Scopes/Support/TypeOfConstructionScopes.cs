using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class TypeOfConstructionScopes
    {
        public static bool CreateTypeOfConstructionScopeIsValid(this TypeOfConstruction typeOfConstruction)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(typeOfConstruction.Description, "A Descrição é obrigatória")
            //AssertionConcern.AssertAreEquals(situation.Status.ToString(),status.Ativo, "Usuario nao pode ser criado com status de inativo")
            );
        }

        public static bool EditScopeIsValid(this TypeOfConstruction typeOfConstruction,
            string description,
            string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(description, "A Descrição é obrigatório"),
                AssertionConcern.AssertNotEmpty(typeOfConstruction.Status.ToString(), "Usuario nao pode ser criado com status de inativo")
            );
        }
    }
}
