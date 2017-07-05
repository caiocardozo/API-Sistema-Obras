using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class DocumentScopes
    {
        public static bool CreateDocumentScopeIsValid(this Document document)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertIsGreaterThan(document.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Document document, Int16 id,
            int constructionId,
            Int16 typeDocumentId,
            DateTime date,
            string number,
            string comments)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(document.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
