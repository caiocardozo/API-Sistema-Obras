using System;

namespace ObrasFai.Domain.Commands.Support.Campus
{
    public class EditCampusCommand
    {
        public EditCampusCommand(Int16 id, string city)
        {
            Id = id;
            City = city;
        }
        public Int16 Id { get; set; }

        public string City { get; set; }
    }
}
