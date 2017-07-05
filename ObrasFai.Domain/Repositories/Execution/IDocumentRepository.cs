using ObrasFai.Domain.Entities.Execution;
using System.Collections.Generic;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IDocumentRepository
    {
        List<Document> Get();
        List<Document> Get(int skip, int take);
        Document Get(int id);
        void Create(Document document);
        void Update(Document document);
        void Delete(Document document);
    }
}
