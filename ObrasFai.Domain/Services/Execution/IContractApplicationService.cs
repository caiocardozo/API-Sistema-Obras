using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Contract;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
   public interface IContractApplicationService
    {
        List<Contract> Get();
        List<Contract> Get(int skip, int take);
        Contract Get(int id);
        Contract Create(CreateContractCommand command);
        Contract Update(EditContractCommand command);
        Contract Delete(int id);

        //return many contracts of a construction
        List<Contract> GetContractsConstruction(int idConstruction);
    }
}
