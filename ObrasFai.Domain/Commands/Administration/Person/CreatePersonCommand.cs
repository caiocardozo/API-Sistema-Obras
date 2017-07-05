using System;
using ObrasFai.Domain.ValueObjects;

namespace ObrasFai.Domain.Commands.Administration.Person
{
    public class CreatePersonCommand
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public Cpf Cpf { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public CreatePersonCommand(string name,DateTime birthDate, Email email, Cpf cpf, string username, string password)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Username = username;
            Password = password;
        }
    }
}
