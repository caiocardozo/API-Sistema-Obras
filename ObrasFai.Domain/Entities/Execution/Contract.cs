using System;
using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Contract : EntityRegisteredUpdated
    {
        protected Contract() { }
        public Contract(
            int constructionId, 
            Int16 typeOfContractId, 
            int biddingId,
            int vendorCode,
            DateTime? signatureDate, 
            decimal contractValue, 
            Int16? deadline, 
            double? area, 
            DateTime? contractDuration, 
            string comments,
            int contractOrigin,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            TypeOfContractId = typeOfContractId;
            BiddingId = biddingId;
            VendorCode = vendorCode;
            SignatureDate = signatureDate;
            ContractValue = contractValue;
            Deadline = deadline;
            Area = area;
            ContractDuration = contractDuration;
            Comments = comments;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
            LastUpdatedDate = DateTime.Now;
            ContractOrigin = contractOrigin;
            UserIdUpdated = userIdRegistered;
        }

        public int Id { get; private set; }
        public int ConstructionId { get; private set; }
        public Int16 TypeOfContractId { get; private set; }
        public int BiddingId { get; private set; }
        public int VendorCode { get; set; }
        public DateTime? SignatureDate { get; private set; }
        public decimal ContractValue { get; private set; }
        public Int16? Deadline { get; private set; }
        public double? Area { get; private set; }
        public DateTime? ContractDuration { get; private set; }
        public string Comments { get; private set; }
        public int ContractOrigin { get; private set; }

        public TypeOfContract TypeOfContract { get; set; }
        public Construction Construction { get; set; }
        public Bidding Bidding { get; set; }
        public virtual ICollection<ContractRate> ContractApportionment { get; set; }

        public void Create()
        {
            if (!this.CreateContractScopeIsValid())
                return;
        }

        public void UpdateInfo(
            int id,
            int constructionId,
            Int16 typeOfContractId,
            int biddingId,
            int vendorCode,
            DateTime? signatureDate,
            decimal contractValue,
            Int16? deadline,
            double? area,
            DateTime? contractDuration,
            string comments,
            int contractOrigin,
            int lastUpdatedDate)
        {
            if (!this.UpdateInfoScopeIsValid(
            id,
            constructionId,
            typeOfContractId,
            biddingId,
            vendorCode,
            signatureDate,
            contractValue,
            deadline,
            area,
            contractDuration,
            comments,
            contractOrigin))
                return;

            Id = id;
            ConstructionId = constructionId;
            TypeOfContractId = typeOfContractId;
            BiddingId = biddingId;
            VendorCode = vendorCode;
            SignatureDate = signatureDate;
            ContractValue = contractValue;
            Deadline = deadline;
            Area = area;
            ContractDuration = contractDuration;
            Comments = comments;
            ContractOrigin = contractOrigin;
            LastUpdatedDate = DateTime.Now;
           }

    }
}
