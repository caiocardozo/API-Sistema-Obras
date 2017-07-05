using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.DocumentType;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Support
{
    public class DocumentTypeConstructionApplicationService : ApplicationService, IDocumentTypeConstructionApplicationService
    {
        private IDocumentTypeConstructionRepository _repository;

        public DocumentTypeConstructionApplicationService(
            IDocumentTypeConstructionRepository repository,
            IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public DocumentTypeConstruction Create(CreateDocumentTypeConstructionCommand command)
        {
            var documentTypeConstruction = new DocumentTypeConstruction(
                command.Description,
                command.UserIdRegistered);
            documentTypeConstruction.Create();
            _repository.Create(documentTypeConstruction);

            if (Commit())
                return documentTypeConstruction;

            return null;
        }

        public DocumentTypeConstruction Delete(int id)
        {
            var documentTypeConstruction = _repository.Get(id);
            _repository.Delete(documentTypeConstruction);

            if (Commit())
                return documentTypeConstruction;

            return null;
        }

        public List<DocumentTypeConstruction> Get()
        {
            return _repository.Get();
        }

        public DocumentTypeConstruction Get(int id)
        {
            return _repository.Get(id);
        }

        public List<DocumentTypeConstruction> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public DocumentTypeConstruction Update(EditDocumentTypeConstructionCommand command)
        {
            var documentTypeConstruction = _repository.Get(command.Id);
            documentTypeConstruction.UpdateInfo(
                command.Id,
                command.Description,
                command.Status
               );
            _repository.Update(documentTypeConstruction);

            if (Commit())
                return documentTypeConstruction;

            return null;
        }

        public DocumentTypeConstruction UpdateStatus(UpdateStatusDocumentTypeConstructionCommand command)
        {
            var documentTypeConstruction = _repository.Get(command.Id);
            if (documentTypeConstruction.Status.Equals("Ativo"))
            {
                documentTypeConstruction.Inactive();
            }
            else
            {
                documentTypeConstruction.Active();
            }
            _repository.Update(documentTypeConstruction);

            if (Commit())
                return documentTypeConstruction;

            return null;
        }
    }
}
