namespace ObrasFai.Domain.Commands.Support.TypeOfContract
{
    public class UpdateISapiensTOContractCommand
    {
        public UpdateISapiensTOContractCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}

