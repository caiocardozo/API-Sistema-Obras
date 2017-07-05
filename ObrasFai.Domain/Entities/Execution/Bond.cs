using ObrasFai.Shared.Entities;
using System;
using ObrasFai.Domain.Scopes.Execution;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Bond : EntityTwo
    {
        protected Bond() { }
        public Bond(
            int constructionId, 
            int contractId, 
            Int16 typeOfBondId, 
            DateTime expirationDate, 
            decimal value,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            ContractId = contractId;
            TypeOfBondId = typeOfBondId;
            ExpirationDate = expirationDate;
            Value = value;
            Status = "Ativo";
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;

        }

        public Int16 Id { get; private set; }
        public int ConstructionId { get; private set; }
        public int ContractId { get; private set; }
        public Int16 TypeOfBondId { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public decimal Value { get; private set; }

        public void Create()
        {
            if (!this.CreateBondScopeIsValid())
                return;
        }

        public void UpdateInfo(
            Int16 id,
            int constructionId, 
            int contractId, 
            Int16 typeOfBondId, 
            DateTime expirationDate,
            decimal value,
            string status)
        {
            if (!this.UpdateInfoScopeIsValid(id, 
                constructionId, 
                contractId, 
                typeOfBondId, 
                expirationDate, 
                value,
                status))
                return;

            ConstructionId = constructionId;
            ContractId = contractId;
            TypeOfBondId = typeOfBondId;
            ExpirationDate = expirationDate;
            Value = value;
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
