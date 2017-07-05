using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
    public class TypeOfBondRepository : ITypeOfBondRepository
    {
        private ObrasFaiDataContext _context;

        public TypeOfBondRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(TypeOfBond typeOfBond)
        {
            _context.TypeOfBonds.Add(typeOfBond);
        }

        public void Delete(TypeOfBond typeOfBond)
        {
            _context.TypeOfBonds.Remove(typeOfBond);
        }

        public List<TypeOfBond> Get()
        {
            return _context.TypeOfBonds.OrderBy(t => t.Id).ToList();
        }

        public TypeOfBond Get(int id)
        {
            return _context.TypeOfBonds.Find(id);
        }

        public List<TypeOfBond> Get(int skip, int take)
        {
            return _context.TypeOfBonds.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(TypeOfBond typeOfBond)
        {
            _context.Entry<TypeOfBond>(typeOfBond).State = EntityState.Modified;
        }
    }
}
