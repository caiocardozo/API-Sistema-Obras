using System;
using ObrasFai.Domain.Scopes.Support;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Support
{
    public class NatureOfObservation : EntitySupport
    {
        protected NatureOfObservation() { }
        public NatureOfObservation(
             string description,
             string internallyAvailable,
             int userIdRegistered)
        {
            InternallyAvailable = internallyAvailable;
            Description = description;
            UserIdRegistered = userIdRegistered;
            DateOfGeneration = DateTime.Now;
            Status = "Ativo";
        }

        public string InternallyAvailable { get; private set; }

        public void Create()
        {
            if (!this.CreateNatureOfObservationScopeIsValid())
                return;
        }

        public void UpdateInfo(
           Int16 id,
           string description,
           string status,
           string internallyAvailable)
        {
            if (!this.UpdateInfoScopeIsValid(
                id, 
                description,
                status,
                internallyAvailable))
                return;

            Id = id;
            Description = description;
            Status = status;
            InternallyAvailable = internallyAvailable;
        }

        public void Inactive()
        {
            this.Status = "Inativo";
        }

        public void Active()
        {
            this.Status = "Ativo";
        }

        public void InternalYes()
        {
            this.InternallyAvailable = "SIM";
        }

        public void InternalNo()
        {
            this.InternallyAvailable = "NÃO";
        }

    }
}
