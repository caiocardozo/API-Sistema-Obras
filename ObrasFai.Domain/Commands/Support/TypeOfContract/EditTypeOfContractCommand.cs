using System;

namespace ObrasFai.Domain.Commands.Support.TypeOfContract
{
    public class EditTypeOfContractCommand
    {
        public EditTypeOfContractCommand(
           Int16 id,
           string description,
           string integratedSapiens,
           string serviceTransaction,
           string status)
        {
            Id = id;
            Description = description;
            Status = status;
            IntegratedSapiens = integratedSapiens;
            ServiceTransaction = serviceTransaction;
        }
        public Int16 Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string IntegratedSapiens { get; set; }
        public string ServiceTransaction { get; set; }
    }
}
