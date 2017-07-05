using System;

namespace ObrasFai.Shared.Entities
{
    public class EntityRegisteredUpdated
    {
        public DateTime DateOfGeneration { get; set; }
        public int UserIdRegistered { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int UserIdUpdated { get; set; }
    }
}
