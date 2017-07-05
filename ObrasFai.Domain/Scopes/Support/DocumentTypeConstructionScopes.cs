using System;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class DocumentTypeConstructionScopes
    {
        public static bool CreateDocumentTCScopeIsValid(this DocumentTypeConstruction document)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertNotEmpty(document.Description, "A descrição não pode estar em branco")
            );
        }

        public static bool UpdateInfoScopeIsValid(this DocumentTypeConstruction document,
            Int16 id,
            string description,
            string status)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertNotEmpty(document.Description, "A descrição não pode estar em branco")
            );
        }
    }
}
