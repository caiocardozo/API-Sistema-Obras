using System;

namespace ObrasFai.Domain.Commands.Administration.Person
{
    public class DeletePersonCommand
    {
        public DeletePersonCommand(int id, int constructionId, int? biddingShoppingPortalId, int? purchaseOrderId, string serviceTransaction, DateTime? dateOfIssue, int? userSapiensId, int? providerId, string paymentTermsId, short? sequenceItem, string serviceId, decimal? purchaseOrderValue, int? projectId, short? phaseId, int? financialAccountId, int? costCenter)
        {
            Id = id;
            ConstructionId = constructionId;
            BiddingShoppingPortalId = biddingShoppingPortalId;
            PurchaseOrderId = purchaseOrderId;
            ServiceTransaction = serviceTransaction;
            DateOfIssue = dateOfIssue;
            UserSapiensId = userSapiensId;
            ProviderId = providerId;
            PaymentTermsId = paymentTermsId;
            SequenceItem = sequenceItem;
            ServiceId = serviceId;
            PurchaseOrderValue = purchaseOrderValue;
            ProjectId = projectId;
            PhaseId = phaseId;
            FinancialAccountId = financialAccountId;
            CostCenter = costCenter;
        }
        public int Id { get; set; }
        public int ConstructionId { get; set; }
        public int? BiddingShoppingPortalId { get; set; }
        public Int16? CompanyId { get; set; }
        public Int16? BranchId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public string ServiceTransaction { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public int? UserSapiensId { get; set; }
        public int? ProviderId { get; set; }
        public string PaymentTermsId { get; set; }
        public Int16? SequenceItem { get; set; }
        public string ServiceId { get; set; }
        public decimal? PurchaseOrderValue { get; set; }
        public int? ProjectId { get; set; }
        public Int16? PhaseId { get; set; }
        public int? FinancialAccountId { get; set; }
        public int? CostCenter { get; set; }


    }
}
