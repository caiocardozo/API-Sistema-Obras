namespace ObrasFai.Domain.Commands.Execution.BiddingRate
{
    public class DeleteBiddingRateCommand
    {
        public DeleteBiddingRateCommand(int id)
        {
            Id = id;

        }
        public int Id { get; set; }
    }
}
