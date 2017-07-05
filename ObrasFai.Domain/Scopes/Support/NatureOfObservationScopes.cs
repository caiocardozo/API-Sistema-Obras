using System;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class NatureOfObservationScopes
    {
        public static bool CreateNatureOfObservationScopeIsValid(this NatureOfObservation natureOfObservation)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertNotEmpty(natureOfObservation.Description, "A descrição não pode estar em branco")
            );
        }

        public static bool UpdateInfoScopeIsValid(this NatureOfObservation natureOfObservation,
            Int16 id,
            string description,
            string status,
            string internallyAvailable)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertNotEmpty(natureOfObservation.Description, "A descrição não pode estar em branco")
            );
        }
    }
}
