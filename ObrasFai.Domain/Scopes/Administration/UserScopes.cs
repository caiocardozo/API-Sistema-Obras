using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Administration
{
    public static class UserScopes
    {
        public static bool RegisterUserScopeIsValid(this User user)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(user.Username, "O E-mail é obrigatório"),
                AssertionConcern.AssertNotEmpty(user.Password, "A senha é obrigatória")
            );
        }

        public static bool AuthenticateUserScopeIsValid(this User user, string username, string encryptedPassword)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(username, "O usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(encryptedPassword, "A senha é obrigatória"),
                AssertionConcern.AssertAreEquals(user.Username, username, "Usuário ou senha inválidos"),
                AssertionConcern.AssertAreEquals(user.Password, encryptedPassword, "Usuário ou senha inválidos")
            );
        }
    }
}
