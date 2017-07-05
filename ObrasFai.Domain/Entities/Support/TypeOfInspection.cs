using System;
using ObrasFai.Domain.Scopes.Support;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Support
{
    public class TypeOfInspection : EntitySupport
    {
        protected TypeOfInspection() { }

        public TypeOfInspection(string description, int userIdRegistered)
        {
            Description = description;
            Status = "Ativo";
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;

        }

        public void Create()
        {
            if (!this.CreateTypeInspectionScopeIsValid())
                return;
        }

        public void UpdateInfo(
            string description,
            string status)
        {
            if (!this.EditScopeIsValid(description, status))
                return;

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
