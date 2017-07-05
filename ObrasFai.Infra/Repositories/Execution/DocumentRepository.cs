using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Infra.Persistence.DataContexts;
using ObrasFai.Domain.Repositories.Execution;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class DocumentRepository : IDocumentRepository
    {
        private ObrasFaiDataContext _context;

        public DocumentRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Document document)
        {
            _context.Documents.Add(document);
        }

        public void Delete(Document document)
        {
            _context.Documents.Remove(document);
        }

        public List<Document> Get()
        {
            return _context.Documents.ToList();
        }

        public Document Get(int id)
        {
            return _context.Documents.Find(id);
        }

        public List<Document> Get(int skip, int take)
        {
            return _context.Documents.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Document document)
        {
            _context.Entry<Document>(document).State = EntityState.Modified;
        }
    }
}
