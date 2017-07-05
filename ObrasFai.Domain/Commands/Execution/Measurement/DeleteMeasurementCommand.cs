namespace ObrasFai.Domain.Commands.Execution.Measurement
{
    public class DeleteMeasurementCommand
    {
        public DeleteMeasurementCommand(int id)
        {
            Id = id;
        }

        public int  Id { get; set; }
    }
}
