using ObrasFai.Domain.Entities.Support;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Support
{
    public static class CampusScopes
    {
        public static bool CreateCampusScopeIsValid(this Campus campus)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(campus.City, "A Descrição é obrigatória")
            );
        }

        public static bool EditCampusScopeIsValid(this Campus campus,
            string city)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertNotEmpty(campus.City, "A Descrição é obrigatória")
            );
        }
    }
}
