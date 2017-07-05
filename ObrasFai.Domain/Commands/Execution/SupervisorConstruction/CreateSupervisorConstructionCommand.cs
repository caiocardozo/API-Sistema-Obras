using System;

namespace ObrasFai.Domain.Commands.Execution.SupervisorConstruction
{
    public class CreateSupervisorConstructionCommand
    {
        public CreateSupervisorConstructionCommand(
           int constructionId,
           Int16 supervisorId,
           int userIdRegistered)
        {
           ConstructionId = constructionId;
           SupervisorId = supervisorId;
           UserIdRegistered = userIdRegistered;
   }

        public int ConstructionId { get; set; }
        public Int16 SupervisorId { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
