using System;
using ObrasFai.Domain.ValueObjects;

namespace ObrasFai.Domain.Commands.Administration.Person
{
    public class EditPersonCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public EditPersonCommand(int id,string name, DateTime birthDate, Email email, Cpf cpf, string username, string password)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Cpf = cpf;
            Username = username;
            Password = password;
        }
    }
}
