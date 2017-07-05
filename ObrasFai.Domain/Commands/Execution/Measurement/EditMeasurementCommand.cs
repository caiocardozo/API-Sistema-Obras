using System;

namespace ObrasFai.Domain.Commands.Execution.Measurement
{
    public class EditMeasurementCommand
    {
        public EditMeasurementCommand(
            int id,
            int constructionId,
            int contractId,
            Int16 supervisorId,
            string date,
            decimal value,
            string comments,
            int apportionmentCode,
            int chit,
            string chitSeries)
        {
            Id = id;
            ConstructionId = constructionId;
            ContractId = contractId;
            SupervisorId = supervisorId;
            Date = Convert.ToDateTime(date);
            Value = value;
            Comments = comments;
            ApportionmentCode = apportionmentCode;
            Chit = chit;
            ChitSeries = chitSeries;
            
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
    }
}
