using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class BiddingRateMap : EntityTypeConfiguration<BiddingRate>
    {
        public BiddingRateMap()
        {
            ToTable("OB101RAT");
            HasKey(m => m.Id);

            Property(m => m.Id).HasColumnName("CODRAT");

            Property(m => m.BiddingId).HasColumnName("CODLIC").IsRequired();
            Property(m => m.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(m => m.BiddingShoppingPortalId).HasColumnName("CODPCO").IsRequired();
            Property(m => m.CompanyCode).HasColumnName("CODEMP").IsRequired();
            Property(m => m.AffiliateCode).HasColumnName("CODFIL").IsRequired();
            Property(m => m.PurchaseOrderNumber).HasColumnName("NUMOCP");
            Property(m => m.ServiceTransactionCode).HasColumnName("TNSSER");
            Property(m => m.DateOfIssue).HasColumnName("DATEMI");
            Property(m => m.UserCode).HasColumnName("CODUSU");
            Property(m => m.VendorCode).HasColumnName("CODFOR");
            Property(m => m.PaymentConditionCode).HasColumnName("CODCPG");
            Property(m => m.ItemSequence).HasColumnName("SEQISO").IsRequired();
            Property(m => m.ServiceCode).HasColumnName("CODSER").IsRequired();
            Property(m => m.ApportionmentValue).HasColumnName("VLRRAT").IsRequired();
            Property(m => m.ProjectNumber).HasColumnName("NUMPRJ").IsRequired();
            Property(m => m.ProjectPhaseCode).HasColumnName("CODFPJ");
            Property(m => m.FinancialAccountCode).HasColumnName("CTAFIN");
            Property(m => m.CostCenterCode).HasColumnName("CODCCU");
            Property(m => m.UserIdRegistered).HasColumnName("USUGER").IsRequired();
            Property(m => m.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(m => m.LastUpdatedDate).HasColumnName("DATALT").IsRequired();
            Property(m => m.UserIdUpdated).HasColumnName("USUALT").IsRequired();

            HasRequired(x => x.Bidding);
            HasRequired(x => x.Construction);


            //indica a relação com a tabela projeto 1 to N e determina as chaves estrangeiras
            HasRequired(p => p.Bidding)
                .WithMany(p => p.BiddingApportionment)
                .HasForeignKey(p => p.BiddingId);
        }
    }
}
