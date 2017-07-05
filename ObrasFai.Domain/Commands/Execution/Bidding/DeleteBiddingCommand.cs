namespace ObrasFai.Domain.Commands.Execution.Bidding
{
    public class DeleteBiddingCommand
    {
        public DeleteBiddingCommand(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
