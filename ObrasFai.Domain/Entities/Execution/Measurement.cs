using System;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Measurement : EntityRegistered
    {
        protected Measurement() { }

        public Measurement(
            int constructionId, 
            int contractId,
            Int16 supervisorId, 
            DateTime date, 
            decimal value, 
            string comments, 
            int apportionmentCode, 
            int chit, 
            string chitSeries, 
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            ContractId = contractId;
            SupervisorId = supervisorId;
            Date = date;
            Value = value;
            Comments = comments;
            ApportionmentCode = apportionmentCode;
            Chit = chit;
            ChitSeries = chitSeries;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
        }

        public int Id { get; set; }
        public int ConstructionId { get; set; }
        public int ContractId { get; set; }
        public Int16 SupervisorId { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string Comments { get; set; }
        public int ApportionmentCode { get; set; }
        public int Chit { get; set; }
        public string ChitSeries { get; set; }

        public Supervisor Supervisor { get; set; }
        public Contract Contract { get; set; }
        public Construction Construction { get; set; }

        public void Create()
        {
            if (!this.CreateMeasurementScopeIsValid())
                return;
        }

        public void UpdateInfo(
            int id,
            int constructionId,
            int contractId,
            Int16 supervisorId,
            DateTime date,
            decimal value,
            string comments,
            int apportionmentCode,
            int chit,
            string chitSeries
            )
        {
            if (!this.UpdateInfoScopeIsValid(
                 id,
            constructionId,
            contractId,
            supervisorId,
            date,
            value,
            comments,
            apportionmentCode,
            chit,
            chitSeries
            ))
                return;

            Id = id;
            ConstructionId = constructionId;
            ContractId = contractId;
            SupervisorId = supervisorId;
            Date = date;
            Value = value;
            Comments = comments;
            ApportionmentCode = apportionmentCode;
            Chit = chit;
            ChitSeries = chitSeries;
        }

       }
}
