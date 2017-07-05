using System;

namespace ObrasFai.Domain.Commands.Support.NatureOfObservation
{
    public class CreateNatureOfObservationCommand
    {
        public CreateNatureOfObservationCommand(
            string description,
            string internallyAvailable,
            int userIdRegistered
            )
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
            DateOfGeneration = DateTime.Now;
            Status = "Ativo";
            InternallyAvailable = internallyAvailable;
        }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfGeneration { get; set; }
        public int UserIdRegistered { get; set; }
        public string InternallyAvailable { get; set; }
    }
}
