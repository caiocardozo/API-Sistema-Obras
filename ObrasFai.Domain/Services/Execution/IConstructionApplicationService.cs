using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Construction;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface IConstructionApplicationService
    {
        List<Construction> Get();
        List<Construction> Get(int skip, int take);
        Construction Get(int id);
        Construction Create(CreateConstructionCommand command);
        Construction Update(EditConstructionCommand command);
        Construction Delete(int id);
        List<Construction> GetAllListHome();
    }
}
