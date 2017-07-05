using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class ContractRepository : IContractRepository
    {
        private ObrasFaiDataContext _context;

        public ContractRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Contract contract)
        {
            _context.Contracts.Add(contract);
        }

        public void Delete(Contract contract)
        {
            _context.Contracts.Remove(contract);
        }

        public List<Contract> Get()
        {
            return _context.Contracts.ToList();
        }

        public Contract Get(int id)
        {
              return _context.Contracts.Find(id);
        }

        public List<Contract> Get(int skip, int take)
        {
            return _context.Contracts.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Contract contract)
        {
            _context.Entry<Contract>(contract).State = EntityState.Modified;
        }

        //return many contracts of a construction
        public List<Contract> GetContractsConstruction(int idConstruction)
        {
          return _context.Contracts
                .Include(c => c.ContractApportionment)
                .Include(t => t.TypeOfContract)
                .Where(a => a.ConstructionId == idConstruction)
                .OrderBy(a => a.TypeOfContractId)
                .ToList();
        }
    }
}
