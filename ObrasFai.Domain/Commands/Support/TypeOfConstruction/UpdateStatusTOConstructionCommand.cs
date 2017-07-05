namespace ObrasFai.Domain.Commands.Support.TypeOfConstruction
{
    public class UpdateStatusTOConstructionCommand
    {
        public UpdateStatusTOConstructionCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

}
