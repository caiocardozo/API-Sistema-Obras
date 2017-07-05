using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfBond;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface ITypeOfBondApplicationService
    {
        List<TypeOfBond> Get();
        List<TypeOfBond> Get(int skip, int take);
        TypeOfBond Get(int id);
        TypeOfBond Create(CreateTypeOfBondCommand command);
        TypeOfBond Update(EditTypeOfBondCommand command);
        TypeOfBond Delete(int id);
        TypeOfBond UpdateStatus(UpdateStatusTOBondCommand command);
    }
}
