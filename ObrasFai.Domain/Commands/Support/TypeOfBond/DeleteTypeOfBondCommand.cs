using System;
using ObrasFai.Shared.Enums;

namespace ObrasFai.Domain.Commands.Support.TypeOfBond
{
    public class DeleteTypeOfBondCommand
    {
        public DeleteTypeOfBondCommand(Int16 id, string description, EStatus status)
        {
            Id = id;
            Description = description;
            Status = status;
        }

        public Int16 Id { get; set; }
        public string Description { get; set; }
        public EStatus Status { get; set; }
    }
}
