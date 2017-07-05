using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class ContractRateRepository : IContractRateRepository
    {
        private ObrasFaiDataContext _context;

        public ContractRateRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(ContractRate contractRate)
        {
            _context.ContractsRate.Add(contractRate);
        }

        public void Delete(ContractRate contractRate)
        {
            _context.ContractsRate.Remove(contractRate);
        }

        public List<ContractRate> Get()
        {
            return _context.ContractsRate.ToList();
        }

        public ContractRate Get(int id)
        {
            return _context.ContractsRate.Find(id);
        }

        public List<ContractRate> Get(int skip, int take)
        {
            return _context.ContractsRate.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(ContractRate contractRate)
        {
            _context.Entry<ContractRate>(contractRate).State = EntityState.Modified;
        }
    }
}
