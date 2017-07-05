using System;
using ObrasFai.Domain.Scopes.Support;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Support
{
    public class Situation : EntitySupport
    {
        protected Situation() { }

        public Situation(string description, int userIdRegistered)
        {
            Description = description;
            Status = "Ativo";
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
            
        }

        public void Create()
        {
            if (!this.CreateSituationScopeIsValid())
                return;
        }

        public void Update( string description,string status)
        {
            if (!this.EditSituationScopeIsValid(description, status))
                return;

           this.Description = description;
           this.Status = status;
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
