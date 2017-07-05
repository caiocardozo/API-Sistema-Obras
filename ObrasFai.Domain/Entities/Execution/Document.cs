using System;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Document : EntityRegistered
    {
        protected Document() { }
        public Document(
            int constructionId, 
            Int16 documentTypeConstructionId,
            DateTime date, 
            string number, 
            string comments,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            DocumentTypeConstructionId = documentTypeConstructionId;
            Date = date;
            Number = number;
            Comments = comments;
            UserIdRegistered = userIdRegistered;
            DateOfGeneration = DateTime.Now;

        }

        public Int16 Id { get; private set; }
        public int ConstructionId { get; private set; }
        public Int16 DocumentTypeConstructionId { get; private set; }
        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public string Comments { get; private set; }

        public Construction Construction { get; set; }
        public DocumentTypeConstruction DocumentTypeConstruction { get; set; }

        public void Create()
        {
            if (!this.CreateDocumentScopeIsValid())
                return;
        }

        public void UpdateInfo(
            Int16 id,
            int constructionId, 
            Int16 documentTypeConstructionId, 
            DateTime date, 
            string number, 
            string comments)
        {
            if (!this.UpdateInfoScopeIsValid(
                id,
            constructionId,
            documentTypeConstructionId,
            date,
            number,
            comments))
                return;
            
            Id = id;
            ConstructionId = constructionId;
            DocumentTypeConstructionId = documentTypeConstructionId;
            Date = date;
            Number = number;
            Comments = comments;
           
        }
    }
}
