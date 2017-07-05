using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
    public class TypeOfInspectionRepository : ITypeOfInspectionRepository
    {
        private ObrasFaiDataContext _context;

        public TypeOfInspectionRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(TypeOfInspection typeOfInspection)
        {
            _context.TypeOfInspections.Add(typeOfInspection);
        }

        public void Delete(TypeOfInspection typeOfInspection)
        {
            _context.TypeOfInspections.Remove(typeOfInspection);
        }

        public List<TypeOfInspection> Get()
        {
            return _context.TypeOfInspections.OrderBy(t => t.Id).ToList();
        }

        public TypeOfInspection Get(int id)
        {
            return _context.TypeOfInspections.Find(id);
        }

        public List<TypeOfInspection> Get(int skip, int take)
        {
            return _context.TypeOfInspections.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(TypeOfInspection typeOfInspection)
        {
            _context.Entry<TypeOfInspection>(typeOfInspection).State = EntityState.Modified;
        }
    }
}
