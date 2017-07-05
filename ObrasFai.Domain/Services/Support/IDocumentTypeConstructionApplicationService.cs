using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.DocumentType;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface IDocumentTypeConstructionApplicationService
    {
        List<DocumentTypeConstruction> Get();
        List<DocumentTypeConstruction> Get(int skip, int take);
        DocumentTypeConstruction Get(int id);
        DocumentTypeConstruction Create(CreateDocumentTypeConstructionCommand command);
        DocumentTypeConstruction Update(EditDocumentTypeConstructionCommand command);
        DocumentTypeConstruction UpdateStatus(UpdateStatusDocumentTypeConstructionCommand command);
        DocumentTypeConstruction Delete(int id);
    }
}
