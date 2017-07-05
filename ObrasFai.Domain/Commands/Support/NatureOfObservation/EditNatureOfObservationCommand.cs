using System;

namespace ObrasFai.Domain.Commands.Support.NatureOfObservation
{
    public class EditNatureOfObservationCommand
    {
        public EditNatureOfObservationCommand(
          Int16 id,
          string description,
          string status,
          string internallyAvailable)
        {
            Id = id;
            Description = description;
            DateOfGeneration = DateTime.Now;
            Status = status;
            InternallyAvailable = internallyAvailable;
        }

        public Int16 Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfGeneration { get; set; }
        public string InternallyAvailable { get; set; }


    }
}
