using System;

namespace ObrasFai.Domain.Commands.Execution.Construction
{
    public class DeleteConstructionCommand
    {
        public DeleteConstructionCommand(int id, string nickname, string description, string name, Int16 campId, Int16 typeofConstructionId, Int16 situationId,
            Int16 typeInspection, DateTime? startDate, DateTime? endDate, DateTime? contractTerminationDate, double area, decimal estimatedValue)
        {
            Id = id;
            Nickname = nickname;
            Description = description;
            Name = name;
            CapmId = campId;
            TypeOfConstructionId = typeofConstructionId;
            SituationId = situationId;
            TypeInspectionId = typeInspection;
            StartDate = startDate;
            EndDate = endDate;
            ContractTerminationDate = ContractTerminationDate;
            Area = area;
            EstimatedValue = estimatedValue;
        }

        public int Id { get; set; }
        public string Nickname { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public Int16 CapmId { get; private set; }
        public Int16 TypeOfConstructionId { get; private set; }
        public Int16 SituationId { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public DateTime? ContractTerminationDate { get; private set; }
        public double Area { get; private set; }
        public decimal EstimatedValue { get; private set; }

    }
}
