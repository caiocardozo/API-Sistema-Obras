using System;

namespace ObrasFai.Domain.Commands.Support.Campus
{
   public class UpdateStatusCampusCommand
    {
        public UpdateStatusCampusCommand(Int16 id)
        {
            Id = id;
        }

        public Int16 Id { get; set; }
    }
}
