
namespace ObrasFai.Domain.Commands.Execution.ContractRate
{
   public class DeleteContractRateCommand
    {
        public DeleteContractRateCommand(int id)
        {
            Id = id;

        }
        public int Id { get; set; }
    }
}
