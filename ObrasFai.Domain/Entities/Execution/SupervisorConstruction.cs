using ObrasFai.Shared.Entities;
using System;
using ObrasFai.Domain.Scopes.Execution;

namespace ObrasFai.Domain.Entities.Execution
{
    public class SupervisorConstruction : EntityTwo
    {
        protected SupervisorConstruction() { }
        public SupervisorConstruction(
            int constructionId,
            Int16 supervisorId,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            SupervisorId = supervisorId;
            Status = "Ativo";
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
        }

        public Int16 Id { get; private set; }
        public int ConstructionId { get; private set; }
        public Int16 SupervisorId { get; private set; }

        public void Create()
        {
            if (!this.CreateSupervisorCScopeIsValid())
                return;
        }

        public void Update(
            Int16 id,
            int constructionId,
            Int16 supervisorId,
            string status)
        {
            if (!this.EditSupervisorCScopeIsValid(
            constructionId,
            supervisorId,
            status))
                return;
            Id = id;
            ConstructionId = constructionId;
            SupervisorId = supervisorId;
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
