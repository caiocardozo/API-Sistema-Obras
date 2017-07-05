using System;

namespace ObrasFai.Shared.Entities
{
    public abstract class EntitySupport 
    {
        public Int16 Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfGeneration { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
