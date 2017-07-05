using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
   public class TypeOfConstructionRepository : ITypeOfConstructionRepository
    {
        private ObrasFaiDataContext _context;

        public TypeOfConstructionRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(TypeOfConstruction typeOfConstruction)
        {
            _context.TypeOfConstructions.Add(typeOfConstruction);
        }

        public void Delete(TypeOfConstruction typeOfConstruction)
        {
            _context.TypeOfConstructions.Remove(typeOfConstruction);
        }

        public List<TypeOfConstruction> Get()
        {
            return _context.TypeOfConstructions.OrderBy(t => t.Id).ToList();
        }

        public TypeOfConstruction Get(int id)
        {
            return _context.TypeOfConstructions.Find(id);
        }

        public List<TypeOfConstruction> Get(int skip, int take)
        {
            return _context.TypeOfConstructions.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(TypeOfConstruction typeOfConstruction)
        {
            _context.Entry<TypeOfConstruction>(typeOfConstruction).State = EntityState.Modified;
        }
    }
}
