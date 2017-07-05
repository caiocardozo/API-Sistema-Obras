namespace ObrasFai.Domain.Commands.Support.DocumentType
{
    public class CreateDocumentTypeConstructionCommand
    {
        public CreateDocumentTypeConstructionCommand(
           string description,
           int userIdRegistered)
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
        }

        public string Description { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
