using System;
using ObrasFai.Domain.Scopes.Support;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Support
{
    public class TypeOfContract : EntitySupport
    {
       protected TypeOfContract() { }

        public TypeOfContract(
            string description, 
            string integratedSapiens,
            string serviceTransaction,
            int userIdRegistered)
        {
            Description = description;
            Status = "Ativo";
            IntegratedSapiens = integratedSapiens;
            ServiceTransaction = serviceTransaction;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;

        }

        public string IntegratedSapiens { get; private set; }
        public string ServiceTransaction { get; set; }

        public void Create()
        {
            if (!this.CreateTypeOfContractScopeIsValid())
                return;
        }

        public void UpdateInfo(
            string description,
            string integratedSapiens,
            string serviceTransaction,
            string status)
        {
            if (!this.EditScopeIsValid(description, integratedSapiens, serviceTransaction, status))
                return;

           Description = description;
            IntegratedSapiens = integratedSapiens;
            ServiceTransaction = serviceTransaction;
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

        public void YesIntegrate()
        {
            this.IntegratedSapiens = "SIM";
        }

        public void DotNotIntegrate()
        {
            this.IntegratedSapiens = "NÃO";
        }
    }
}
