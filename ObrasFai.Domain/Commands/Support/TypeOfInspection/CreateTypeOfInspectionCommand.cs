namespace ObrasFai.Domain.Commands.Support.TypeOfInspection
{
    public class CreateTypeOfInspectionCommand
    {
        public CreateTypeOfInspectionCommand(
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
