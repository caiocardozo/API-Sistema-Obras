using System;

namespace ObrasFai.Domain.Commands.Execution.Bond
{
    public class CreateBondCommand
    {
        public CreateBondCommand(
            int constructionId, 
            int contractId,
            Int16 typeOfBondId, 
            string expirationDate, 
            decimal value,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            ContractId = contractId;
            TypeOfBondId = typeOfBondId;
            ExpirationDate = Convert.ToDateTime(expirationDate);
            Value = value;
            UserIdRegistered = userIdRegistered;
        }
        public int ConstructionId { get; set; }
        public int ContractId { get; set; }
        public Int16 TypeOfBondId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Value { get; set; }
        public int UserIdRegistered { get; set; }
    }

    
}
