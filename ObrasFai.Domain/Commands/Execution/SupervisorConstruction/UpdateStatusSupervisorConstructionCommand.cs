namespace ObrasFai.Domain.Commands.Execution.SupervisorConstruction
{
    public class UpdateStatusSupervisorConstructionCommand
    {
        public UpdateStatusSupervisorConstructionCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
