using System;

namespace ObrasFai.Domain.Commands.Execution.SupervisorConstruction
{
    public class EditSupervisorConstructionCommand
    {
        public EditSupervisorConstructionCommand(
           Int16 id,
           int constructionId,
           Int16 supervisorId,
           string status)
        {
            Id = id;
            ConstructionId = constructionId;
            SupervisorId = supervisorId;
            Status = status;
        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public Int16 SupervisorId { get; set; }
        public string Status { get; set; }

    
    }
}
