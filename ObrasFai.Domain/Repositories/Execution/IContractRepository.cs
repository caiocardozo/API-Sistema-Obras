using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IContractRepository
    {
        List<Contract> Get();
        List<Contract> Get(int skip, int take);
        Contract Get(int id);
        void Create(Contract contract);
        void Update(Contract contract);
        void Delete(Contract contract);

        //return many contracts of a construction
        List<Contract> GetContractsConstruction(int idConstruction);


    }
}
