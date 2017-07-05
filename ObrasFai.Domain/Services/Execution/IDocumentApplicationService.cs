using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Documents;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface IDocumentApplicationService
    {
        List<Document> Get();
        List<Document> Get(int skip, int take);
        Document Get(int id);
        Document Create(CreateDocumentCommand command);
        Document Update(EditDocumentCommand command);
        Document Delete(int id);
    }
}
