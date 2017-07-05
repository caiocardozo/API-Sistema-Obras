using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class TypeOfContractScopes
    {
        public static bool CreateTypeOfContractScopeIsValid(this TypeOfContract typeOfContract)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(typeOfContract.Description, "A Descrição é obrigatória")
            //AssertionConcern.AssertAreEquals(situation.Status.ToString(),status.Ativo, "Usuario nao pode ser criado com status de inativo")
            );
        }

        public static bool EditScopeIsValid(this TypeOfContract typeOfContract,
            string description,
            string integratedSapiens,
            string serviceTransaction,
            string status)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(description, "A Descrição é obrigatório"),
                AssertionConcern.AssertNotEmpty(typeOfContract.Status.ToString(), "Usuario nao pode ser criado com status de inativo")
            );
        }
    }
}
