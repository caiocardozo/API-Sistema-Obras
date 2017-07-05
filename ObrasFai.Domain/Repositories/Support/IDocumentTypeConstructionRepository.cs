using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface IDocumentTypeConstructionRepository
    {
        List<DocumentTypeConstruction> Get();
        List<DocumentTypeConstruction> Get(int skip, int take);
        DocumentTypeConstruction Get(int id);
        void Create(DocumentTypeConstruction documentTypeConstruction);
        void Update(DocumentTypeConstruction documentTypeConstruction);
        void Delete(DocumentTypeConstruction documentTypeConstruction);
    }
}
