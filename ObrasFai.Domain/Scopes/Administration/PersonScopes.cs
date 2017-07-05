using System;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.ValueObjects;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Administration
{
    public static class PersonScopes
    {
        public static bool CreatePersonScopeIsValid(this Person person)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(person.Name, "O nome é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.Email.ToString(), "O nome é obrigatório"),
                AssertionConcern.AssertNotNull(person.BirthDate, "O data é obrigatória"),
                AssertionConcern.AssertNotEmpty(person.Cpf.Number, "O CPF é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.User.Username, "O Username é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.User.Password, "A Senha é obrigatória")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Person person, string name, Email email, DateTime birthDate, Cpf cpf, string username, string password)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(person.Name, "O nome é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.Email.ToString(), "O nome é obrigatório"),
                AssertionConcern.AssertNotNull(person.BirthDate, "O nome é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.Cpf.Number, "O CPF é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.User.Username, "O Username é obrigatório"),
                AssertionConcern.AssertNotEmpty(person.User.Password, "A Senha é obrigatória")
            );
        }


    }
}
