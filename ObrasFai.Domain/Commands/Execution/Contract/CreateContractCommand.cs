using System;

namespace ObrasFai.Domain.Commands.Execution.Contract
{
    public class CreateContractCommand
    {
        public CreateContractCommand(
            int constructionId, 
            Int16 typeOfContractId,
            int biddingId,
            int vendorCode,
            DateTime signatureDate,
            decimal contractValue, 
            Int16? deadline, 
            double? area, 
            DateTime contractDuration, 
            string comments, 
            int contractOrigin,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            TypeOfContractId = typeOfContractId;
            BiddingId = biddingId;
            VendorCode = vendorCode;
            SignatureDate = Convert.ToDateTime(signatureDate) ;
            ContractValue = contractValue;
            Deadline = deadline;
            Area = area;
            ContractDuration = Convert.ToDateTime(contractDuration);
            Comments = comments;
            ContractOrigin = contractOrigin;
            UserIdRegistered = userIdRegistered;
        }

        public int ConstructionId { get; private set; }
        public Int16 TypeOfContractId { get; private set; }
        public int BiddingId { get; private set; }
        public int VendorCode { get; private set; }
        public DateTime? SignatureDate { get; private set; }
        public decimal ContractValue { get; private set; }
        public Int16? Deadline { get; private set; }
        public double? Area { get; private set; }
        public DateTime? ContractDuration { get; private set; }
        public string Comments { get; private set; }
        public int ContractOrigin { get; set; }
        public int UserIdRegistered { get; private set; }
    }
}
