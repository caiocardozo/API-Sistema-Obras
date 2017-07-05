namespace ObrasFai.Domain.Commands.Support.TypeOfBond
{
    public class CreateTypeOfBondCommand
    {
        public CreateTypeOfBondCommand(
           string description,
           int userIdRegistered
           )
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
        }
        public string Description { get; set; }
        public string Status { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
