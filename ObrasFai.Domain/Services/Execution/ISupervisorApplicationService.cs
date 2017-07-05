using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Supervisor;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface ISupervisorApplicationService
    {
        List<Supervisor> Get();
        List<Supervisor> Get(int skip, int take);
        Supervisor Get(int id);
        Supervisor Create(CreateSupervisorCommand command);
        Supervisor Update(EditSupervisorCommand command);
        Supervisor Delete(int id);
        Supervisor UpdateStatus(UpdateStatusSupervisorCommand command);
    }
}
