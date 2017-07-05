using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
   public class ContractRateMap :EntityTypeConfiguration<ContractRate>
    {
        public ContractRateMap()
        {
            ToTable("OB102RAT");
            HasKey(m => m.Id);

            Property(m => m.Id).HasColumnName("CODRAT");

            Property(m => m.ContractId).HasColumnName("CODCON").IsRequired();
            Property(m => m.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(m => m.TypeOfContractId).HasColumnName("CODTCO").IsRequired();
            Property(m => m.CompanyCode).HasColumnName("CODEMP").IsRequired();
            Property(m => m.AffiliateCode).HasColumnName("CODFIL").IsRequired();
            Property(m => m.PurchaseOrderNumber).HasColumnName("NUMOCP");
            Property(m => m.ServiceTransactionCode).HasColumnName("TNSSER");
            Property(m => m.DateOfIssue).HasColumnName("DATEMI");
            Property(m => m.UserCode).HasColumnName("CODUSU");
            Property(m => m.VendorCode).HasColumnName("CODFOR");
            Property(m => m.PaymentConditionCode).HasColumnName("CODCPG");
            Property(m => m.ItemSequence).HasColumnName("SEQISO").IsRequired();
            Property(m => m.ServiceCode).HasColumnName("CODSER").HasMaxLength(14).IsRequired();
            Property(m => m.ApportionmentValue).HasColumnName("VLRRAT").IsRequired();
            Property(m => m.ProjectNumber).HasColumnName("NUMPRJ");
            Property(m => m.ProjectPhaseCode).HasColumnName("CODFPJ");
            Property(m => m.FinancialAccountCode).HasColumnName("CTAFIN");
            Property(m => m.CostCenterCode).HasColumnName("CODCCU");
            Property(m => m.PurchaseOrderOrigin).HasColumnName("OCPORI");
            Property(m => m.UserIdRegistered).HasColumnName("USUGER").IsRequired();
            Property(m => m.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(m => m.LastUpdatedDate).HasColumnName("DATALT").IsRequired();
            Property(m => m.UserIdUpdated).HasColumnName("USUALT").IsRequired();

            //HasRequired(x => x.Contract);
            //HasRequired(x => x.Construction);
            //HasRequired(x => x.TypeOfContract);
            //indica a relação com a tabela projeto 1 to N e determina as chaves estrangeiras
            HasRequired(p => p.Contract)
                .WithMany(p => p.ContractApportionment)
                .HasForeignKey(p => p.ContractId);
        }
    }
}
