namespace ObrasFai.Domain.Commands.Support.NatureOfObservation
{
   public class UpdateStatusNatureOfObservationCommand
    {
        public UpdateStatusNatureOfObservationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
