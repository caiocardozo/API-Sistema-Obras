using System;
using System.Text;
using ObrasFai.Domain.Scopes.Administration;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Administration
{
    public class User : Entity
    {
        protected User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = EncryptPassword(password);//pode usar StringHelper.Encrypt(password)
            Active = true;
            RegistrationDate = DateTime.Now;
        }

        public string Username { get;  set; }
        public string Password { get;  set; }
        public bool Active { get; private set; }
        public DateTime RegistrationDate { get; set; }
        public void Authenticate(string username, string password)
        {
            if (!this.AuthenticateUserScopeIsValid(username, password))
                return;
        }
        public void Activate() => Active = true;
        public void Deactivate() => Active = false;
        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";
            var password = (pass += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }

    }
}
