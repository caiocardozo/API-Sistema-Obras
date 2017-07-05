namespace ObrasFai.Domain.Commands.Support.TypeOfConstruction
{
    public class CreateTypeOfConstructionCommand
    {
        public CreateTypeOfConstructionCommand(
           string description,
          int userIdRegistered
           )
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
        }
        public string Description { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
