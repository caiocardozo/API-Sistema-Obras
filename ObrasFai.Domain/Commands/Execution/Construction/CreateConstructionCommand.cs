using System;

namespace ObrasFai.Domain.Commands.Execution.Construction
{
    public class CreateConstructionCommand
    {
        public CreateConstructionCommand(
            string nickname,
            string description,
            string name,
            Int16 campId,
            Int16 typeofConstructionId,
            Int16 situationId,
            Int16 typeInspectionId,
            string startDate,
            string endDate,
            string contractTerminationDate,
            string signatureDate,
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
            StartDate = Convert.ToDateTime(startDate);
            EndDate = Convert.ToDateTime(endDate);
            ContractTerminationDate = Convert.ToDateTime(contractTerminationDate);
            SignatureDate = Convert.ToDateTime(signatureDate);
            Area = area;
            EstimatedValue = estimatedValue;
            UserIdRegistered = userIdRegistered;
        }

        public string Nickname { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public Int16 CampId { get; private set; }
        public Int16 TypeOfConstructionId { get; private set; }
        public Int16 SituationId { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public DateTime? ContractTerminationDate { get; private set; }
        public DateTime? SignatureDate { get; set; }
        public double Area { get; private set; }
        public decimal EstimatedValue { get; private set; }
       public int UserIdRegistered { get; set; }
    }
}
