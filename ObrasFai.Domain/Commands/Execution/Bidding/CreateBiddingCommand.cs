using System;

namespace ObrasFai.Domain.Commands.Execution.Bidding
{
    public class CreateBiddingCommand
    {
        public CreateBiddingCommand(
            int constructionId,
            int biddingShoppingPortalId,
            decimal amount,
            Int16 executionTime)
        {
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
            Amount = amount;
            ExecutionTime = executionTime;
        }

        public int ConstructionId { get; set; }
        public int BiddingShoppingPortalId { get; set; }
        public decimal Amount { get; set; }
        public Int16 ExecutionTime { get; set; }
    }
}
