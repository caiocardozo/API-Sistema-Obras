using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class TypeInspectionScopes
    {
        public static bool CreateTypeInspectionScopeIsValid(this TypeOfInspection typeInspection)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(typeInspection.Description, "A Descrição é obrigatória")
            //AssertionConcern.AssertAreEquals(situation.Status.ToString(),status.Ativo, "Usuario nao pode ser criado com status de inativo")
            );
        }

        public static bool EditScopeIsValid(this TypeOfInspection typeInspection, 
            string description,
            string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(description, "A Descrição é obrigatório"),
                AssertionConcern.AssertNotEmpty(typeInspection.Status.ToString(), "Usuario nao pode ser criado com status de inativo")
            );
        }
    }
}
