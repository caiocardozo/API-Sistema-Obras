using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.SupervisorConstruction;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface ISupervisorConstructionApplicationService
    {
        List<SupervisorConstruction> Get();
        List<SupervisorConstruction> Get(int skip, int take);
        SupervisorConstruction Get(int id);
        SupervisorConstruction Create(CreateSupervisorConstructionCommand command);
        SupervisorConstruction Update(EditSupervisorConstructionCommand command);
        SupervisorConstruction Delete(int id);
        SupervisorConstruction UpdateStatus(UpdateStatusSupervisorConstructionCommand command);
    }
}
