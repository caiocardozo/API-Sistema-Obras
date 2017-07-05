using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Documents;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class DocumentApplicationService : ApplicationService, IDocumentApplicationService
    {
        private IDocumentRepository _repository;

        public DocumentApplicationService(IDocumentRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Document Create(CreateDocumentCommand command)
        {
            var document = new Document(
                command.ConstructionId,
                command.DocumentTypeConstructionId,
                command.Date,
                command.Number,
                command.Comments,
                command.UserIdRegistered);
            document.Create();
            _repository.Create(document);

            if (Commit())
                return document;

            return null;
        }

        public Document Delete(int id)
        {
            var document = _repository.Get(id);
            _repository.Delete(document);

            if (Commit())
                return document;

            return null;
        }

        public List<Document> Get()
        {
            return _repository.Get();
        }

        public Document Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Document> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Document Update(EditDocumentCommand command)
        {
            var document = _repository.Get(command.Id);
            document.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.DocumentTypeConstructionId,
                command.Date,
                command.Number,
                command.Comments
               );
            _repository.Update(document);

            if (Commit())
                return document;

            return null;
        }
    }
}
