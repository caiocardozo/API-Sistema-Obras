using System;
using ObrasFai.Domain.Scopes.Support;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Support
{
    public class DocumentTypeConstruction : EntitySupport
    {
        protected DocumentTypeConstruction() { }
        public DocumentTypeConstruction(
           string description,
           int userIdRegistered
            )
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
            DateOfGeneration = DateTime.Now;
            Status = "Ativo";
        }

        public void Create()
        {
            if (!this.CreateDocumentTCScopeIsValid())
                return;

        }

        public void UpdateInfo(
            Int16 id,
            string description,
            string status)
        {
            if (!this.UpdateInfoScopeIsValid(
                id, 
                description,
                status))
                return;

            Id = id;
            Description = description;
            Status = status;
        }

        public void Inactive()
        {
            this.Status = "Inativo";
        }

        public void Active()
        {
            this.Status = "Ativo";
        }
    }
}
