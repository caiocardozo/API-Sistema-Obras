using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Bond;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
   public interface IBondApplicationService
    {
        List<Bond> Get();
        List<Bond> Get(int skip, int take);
        Bond Get(int id);
        Bond Create(CreateBondCommand command);
        Bond Update(EditBondCommand command);
        Bond Delete(int id);
        Bond UpdateStatus(UpdateStatusBondCommand command);
    }
}
