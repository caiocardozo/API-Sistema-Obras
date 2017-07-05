using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Support
{
    public class DocumentTypeConstructionRepository : IDocumentTypeConstructionRepository
    {
        private ObrasFaiDataContext _context;

        public DocumentTypeConstructionRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(DocumentTypeConstruction bond)
        {
            _context.DocumentTypeConstructions.Add(bond);
        }

        public void Delete(DocumentTypeConstruction bond)
        {
            _context.DocumentTypeConstructions.Remove(bond);
        }

        public List<DocumentTypeConstruction> Get()
        {
            return _context.DocumentTypeConstructions.OrderBy(d => d.Id).ToList();
        }

        public DocumentTypeConstruction Get(int id)
        {
            return _context.DocumentTypeConstructions.Find(id);
        }

        public List<DocumentTypeConstruction> Get(int skip, int take)
        {
            return _context.DocumentTypeConstructions.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(DocumentTypeConstruction bond)
        {
            _context.Entry<DocumentTypeConstruction>(bond).State = EntityState.Modified;
        }
    }
}
