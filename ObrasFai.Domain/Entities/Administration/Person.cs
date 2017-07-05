using System;
using ObrasFai.Domain.Scopes.Administration;
using ObrasFai.Domain.ValueObjects;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Administration
{
    public class Person : Entity
    {
        protected Person() { }

        public Person(string name,DateTime birthDate, Email email, Cpf cpf, string username, string password)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            User.Username = username;
            User.Password = password;
        }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public Cpf Cpf { get; private set; }
        public User User { get; private set; }

        public void Create()
        {
            if (!this.CreatePersonScopeIsValid())
                return;
        }
        public void UpdateInfo(int Id, string name, DateTime birthDate, Email email, Cpf cpf, string username, string password)
        {
            if (!this.UpdateInfoScopeIsValid(name, email, birthDate, cpf, username, password))
                return;

            Name = name;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            User.Username = username;
            User.Password = password;
        }
    }
}
