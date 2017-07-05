using System;

namespace ObrasFai.Domain.Commands.Support.Campus
{
    public class DeleteCampusCommand
    {
        public DeleteCampusCommand(Int16 id)
        {
            Id = id;
        }
        public Int16 Id { get; set; }

    }
}
