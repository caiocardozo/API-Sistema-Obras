namespace ObrasFai.Domain.Commands.Execution.Contract
{
    public class DeleteContractCommand
    {
        public DeleteContractCommand(int id)
        {
            Id = id;
           
        }
        public int Id { get; set; }
      
    }
}
