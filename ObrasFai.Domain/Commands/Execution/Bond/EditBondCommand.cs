using System;

namespace ObrasFai.Domain.Commands.Execution.Bond
{
    public class EditBondCommand
    {

        public EditBondCommand(
            Int16 id, 
            int constructionId, 
            int contractId, 
            Int16 typeOfBondId,
            string expirationDate, 
            decimal value, 
            string status)
        {
            Id = id;
            ConstructionId = constructionId;
            ContractId = contractId;
            TypeOfBondId = typeOfBondId;
            ExpirationDate = Convert.ToDateTime(expirationDate);
            Value = value;
            Status = status;
        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public int ContractId { get; set; }
        public Int16 TypeOfBondId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }

    }
}
