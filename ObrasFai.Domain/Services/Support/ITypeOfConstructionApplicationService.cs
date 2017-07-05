using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfConstruction;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface ITypeOfConstructionApplicationService
    {
        List<TypeOfConstruction> Get();
        List<TypeOfConstruction> Get(int skip, int take);
        TypeOfConstruction Get(int id);
        TypeOfConstruction Create(CreateTypeOfConstructionCommand command);
        TypeOfConstruction Update(EditTypeOfConstructionCommand command);
        TypeOfConstruction Delete(int id);
        TypeOfConstruction UpdateStatus(UpdateStatusTOConstructionCommand command);
    }
}
