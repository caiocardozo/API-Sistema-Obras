using ObrasFai.Shared.Entities;
using System;
using System.Collections.Generic;
using ObrasFai.Domain.Scopes.Execution;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Bidding : EntityRegisteredUpdated
    {
        protected Bidding() { }
        public Bidding(
            int constructionId,
            int biddingShoppingPortalId,
            decimal amount,
            Int16 executionTime
            )
        {
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
            Amount = amount;
            ExecutionTime = executionTime;
        }

        public int Id { get; private set; }
        public int ConstructionId { get; private set; }
        public int BiddingShoppingPortalId { get; private set; }
        public decimal Amount { get; private set; }
        public Int16 ExecutionTime { get; private set; }

        public Construction Construction { get; set; }
        public virtual ICollection<BiddingRate> BiddingApportionment { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }


        public void Create()
        {
            if (!this.CreateBiddingScopeIsValid())
                return;
        }
        public void UpdateInfo(
            int id, 
            int constructionId,
            int biddingShoppingPortalId,
            decimal amount,
            Int16 executionTime)
        {
            if (!this.UpdateInfoScopeIsValid(
                id,
                constructionId,
                biddingShoppingPortalId,
                amount,
                executionTime))
                return;

            Id = id;
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
            Amount = amount;
            ExecutionTime = executionTime;
        }

    }
}
