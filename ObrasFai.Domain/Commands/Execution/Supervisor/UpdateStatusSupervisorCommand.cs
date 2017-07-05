
namespace ObrasFai.Domain.Commands.Execution.Supervisor
{
    public class UpdateStatusSupervisorCommand
    {
        public UpdateStatusSupervisorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
