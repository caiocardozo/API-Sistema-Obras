namespace ObrasFai.Domain.Commands.Support.TypeOfContract
{
    public class UpdateStatusTOContractCommand
    {
        public UpdateStatusTOContractCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

}
