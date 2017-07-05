using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class ContractMap : EntityTypeConfiguration<Contract>
    {
        public ContractMap()
        {
            ToTable("OB102CON");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODCON");
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.TypeOfContractId).HasColumnName("CODTCO").IsRequired();
            Property(x => x.BiddingId).HasColumnName("CODLIC").IsRequired();
            Property(x => x.VendorCode).HasColumnName("CODFOR").IsRequired();
            Property(x => x.SignatureDate).HasColumnName("DATASS").IsRequired();
            Property(x => x.ContractValue).HasColumnName("VLRCON").IsRequired();
            Property(x => x.Deadline).HasColumnName("PRACON").IsRequired();
            Property(x => x.Area).HasColumnName("ARECON").IsRequired();
            Property(x => x.ContractDuration).HasColumnName("VIGCON").IsRequired();
            Property(x => x.Comments).HasColumnName("OBSCON").HasMaxLength(1000).IsRequired();
            Property(x => x.ContractOrigin).HasColumnName("CONORI").IsRequired();
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
            Property(x => x.LastUpdatedDate).HasColumnName("DATALT").IsRequired();
            Property(x => x.UserIdUpdated).HasColumnName("USUALT").IsRequired();

            HasRequired(x => x.Construction);
            //HasRequired(x => x.TypeOfContract);

        }
    }
}
