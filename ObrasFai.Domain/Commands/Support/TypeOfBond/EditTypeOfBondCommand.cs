using System;

namespace ObrasFai.Domain.Commands.Support.TypeOfBond
{
    public class EditTypeOfBondCommand
    {
        public EditTypeOfBondCommand(
           Int16 id,
           string description,
           string status)
        {
            Id = id;
            Description = description;
            Status = status;
        }
        public Int16 Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
