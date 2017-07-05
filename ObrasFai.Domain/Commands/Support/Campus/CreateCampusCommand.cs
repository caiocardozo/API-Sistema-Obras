namespace ObrasFai.Domain.Commands.Support.Campus
{
    public class CreateCampusCommand
    {
        public CreateCampusCommand(string city)
        {
            City = city;
        }
        public string City { get; set; }
    }
}
