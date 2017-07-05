using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class BondMap : EntityTypeConfiguration<Bond>
    {
        public BondMap()
        {
            ToTable("OB105CAU");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODCAU").IsRequired();
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.ContractId).HasColumnName("CODCON").IsRequired();
            Property(x => x.TypeOfBondId).HasColumnName("CODTCA").IsRequired();
            Property(x => x.ExpirationDate).HasColumnName("DATVAL").IsRequired();
            Property(x => x.Value).HasColumnName("VLRCAU").IsRequired();
            Property(x => x.Status).HasColumnName("SITCAU").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
