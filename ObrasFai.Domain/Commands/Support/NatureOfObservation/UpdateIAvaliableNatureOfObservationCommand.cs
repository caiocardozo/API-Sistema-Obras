namespace ObrasFai.Domain.Commands.Support.NatureOfObservation
{
    public class UpdateIAvaliableNatureOfObservationCommand
    {
        public UpdateIAvaliableNatureOfObservationCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
