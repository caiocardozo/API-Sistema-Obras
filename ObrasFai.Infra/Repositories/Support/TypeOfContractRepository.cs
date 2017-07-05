using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
   public class TypeOfContractRepository : ITypeOfContractRepository
    {
        private ObrasFaiDataContext _context;

        public TypeOfContractRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(TypeOfContract typeOfContract)
        {
            _context.TypeOfContracts.Add(typeOfContract);
        }

        public void Delete(TypeOfContract typeOfContract)
        {
            _context.TypeOfContracts.Remove(typeOfContract);
        }

        public List<TypeOfContract> Get()
        {
            return _context.TypeOfContracts.OrderBy(t => t.Id).ToList();
        }

        public TypeOfContract Get(int id)
        {
            return _context.TypeOfContracts.Find(id);
        }

        public List<TypeOfContract> Get(int skip, int take)
        {
            return _context.TypeOfContracts.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(TypeOfContract typeOfContract)
        {
            _context.Entry<TypeOfContract>(typeOfContract).State = EntityState.Modified;
        }
    }
}
