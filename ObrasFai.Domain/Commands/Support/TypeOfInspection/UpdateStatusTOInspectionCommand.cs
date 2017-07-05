namespace ObrasFai.Domain.Commands.Support.TypeOfInspection
{
    public class UpdateStatusTOInspectionCommand
    {
        public UpdateStatusTOInspectionCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

}
