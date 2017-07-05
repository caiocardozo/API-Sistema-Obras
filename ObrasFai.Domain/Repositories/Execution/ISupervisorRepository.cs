using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface ISupervisorRepository
    {
        List<Supervisor> Get();
        List<Supervisor> Get(int skip, int take);
        Supervisor Get(int id);
        void Create(Supervisor supervisor);
        void Update(Supervisor supervisor);
        void Delete(Supervisor supervisor);
    }
}
