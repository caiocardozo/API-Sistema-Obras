namespace ObrasFai.Domain.Commands.Execution.Bond
{
    public class UpdateStatusBondCommand
    {
        public UpdateStatusBondCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
