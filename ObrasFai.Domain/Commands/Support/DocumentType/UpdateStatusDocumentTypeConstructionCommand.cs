namespace ObrasFai.Domain.Commands.Support.DocumentType
{
    public class UpdateStatusDocumentTypeConstructionCommand
    {
        public UpdateStatusDocumentTypeConstructionCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
