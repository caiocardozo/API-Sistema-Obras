namespace ObrasFai.Domain.Commands.Support.TypeOfContract
{
    public class CreateTypeOfContractCommand
    {
        public CreateTypeOfContractCommand(
           string description,
           string integratedSapiens,
           string serviceTransaction,
           int userIdRegistered
           )
        {
            Description = description;
            UserIdRegistered = userIdRegistered;
            IntegratedSapiens = integratedSapiens;
            ServiceTransaction = serviceTransaction;
        }
        public string Description { get; set; }
        public int UserIdRegistered { get; set; }
        public string IntegratedSapiens { get; set; }
        public string ServiceTransaction { get; set; }
    }
}
