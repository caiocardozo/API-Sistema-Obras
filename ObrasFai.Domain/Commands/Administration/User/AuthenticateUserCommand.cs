namespace ObrasFai.Domain.Commands.Administration.User
{
    public class AuthenticateUserCommand
    {
        public AuthenticateUserCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        }
}
