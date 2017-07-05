using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IContractRateRepository
    {
        List<ContractRate> Get();
        List<ContractRate> Get(int skip, int take);
        ContractRate Get(int id);
        void Create(ContractRate contractRate);
        void Update(ContractRate contractRate);
        void Delete(ContractRate contractRate);
    }
}
