using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.ContractRate;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
   public interface IContractRateApplicationService
    {
        List<ContractRate> Get();
        List<ContractRate> Get(int skip, int take);
        ContractRate Get(int id);
        ContractRate Create(CreateContractRateCommand command);
        ContractRate Update(EditContractRateCommand command);
        ContractRate Delete(int id);
    }
}
