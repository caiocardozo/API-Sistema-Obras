using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface ISupervisorConstructionRepository
    {
        List<SupervisorConstruction> Get();
        List<SupervisorConstruction> Get(int skip, int take);
        SupervisorConstruction Get(int id);
        void Create(SupervisorConstruction supervisorConstruction);
        void Update(SupervisorConstruction supervisorConstruction);
        void Delete(SupervisorConstruction supervisorConstruction);
    }
}
