using System;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Construction : EntityRegisteredUpdated
    {
        protected Construction(){}

        public Construction(
            string nickname, 
            string description,
            string name, 
            Int16 campId, 
            Int16 typeofConstructionId,
            Int16 situationId,
            Int16 typeInspectionId, 
            DateTime? startDate, 
            DateTime? endDate, 
            DateTime? contractTerminationDate,
            DateTime? signatureDate,
            double area, 
            decimal estimatedValue,
            int userIdRegistered)
        {
            Nickname = nickname;
            Description = description;
            Name = name;
            CampId = campId;
            TypeOfConstructionId = typeofConstructionId;
            SituationId = situationId;
            TypeInspectionId = typeInspectionId;
            StartDate = startDate;
            EndDate = endDate;
            ContractTerminationDate = contractTerminationDate;
            SignatureDate = signatureDate;
            Area = area;
            EstimatedValue = estimatedValue;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
            LastUpdatedDate = DateTime.Now;
            UserIdUpdated = 1;


        }


        public int Id { get; private set; }
        public string Nickname { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public Int16 CampId { get; private set; }
        public Campus Camp { get; set; }
        public Int16 TypeOfConstructionId { get; private set; }
        public TypeOfConstruction TypeOfConstruction { get; private set; }
        public Int16 SituationId { get; private set; }
        public Situation Situation { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public TypeOfInspection TypeInspection { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public DateTime? ContractTerminationDate { get; private set; }
        public DateTime? SignatureDate { get; set; }
        public double Area { get; private set; }
        public decimal EstimatedValue { get; private set; }

        public void Register()
        {
            if (!this.RegisterConstructionScopeIsValid())
                return;
        }

        public void Update(
            string nickname, 
            string description, 
            string name,
            Int16 campId,
            Int16 typeOfConstructionId, 
            Int16 situationId,
            Int16 typeInspectionId, 
            DateTime startDate, 
            DateTime endDate, 
            DateTime contractTerminationDate,
            DateTime signatureDate,
            double area,
            decimal estimatedValue, 
            int userIdUpdated)
        {
            if (!this.UpdateInfoScopeIsValid(nickname, description, name, campId, typeOfConstructionId, situationId,
                typeInspectionId, area, estimatedValue))
                return;

            Nickname = nickname;
            Description = description;
            Name = name;
            CampId = campId;
            TypeOfConstructionId = typeOfConstructionId;
            SituationId = situationId;
            TypeInspectionId = typeInspectionId;
            StartDate = startDate;
            EndDate = endDate;
            ContractTerminationDate = ContractTerminationDate;
            Area = area;
            SignatureDate = signatureDate;
            EstimatedValue = estimatedValue;
            LastUpdatedDate = DateTime.Now;
            UserIdUpdated = userIdUpdated;
        }
    }
}
