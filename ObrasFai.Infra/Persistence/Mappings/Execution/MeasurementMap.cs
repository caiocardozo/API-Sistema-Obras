using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class MeasurementMap : EntityTypeConfiguration<Measurement>
    {
        public MeasurementMap()
        {
            ToTable("OB106MED");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODMED").IsRequired();
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.ContractId).HasColumnName("CODCON").IsRequired();
            Property(x => x.SupervisorId).HasColumnName("CODFIS").IsRequired();
            Property(x => x.Date).HasColumnName("DATMED").IsRequired();
            Property(x => x.Value).HasColumnName("VLRMED").IsRequired();
            Property(x => x.Comments).HasColumnName("OBSMED").IsRequired().HasMaxLength(300);
            Property(x => x.ApportionmentCode).HasColumnName("CODRAT").IsRequired();
            Property(x => x.Chit).HasColumnName("NUMNFC").IsRequired();
            Property(x => x.ChitSeries).HasColumnName("CODSNF").HasMaxLength(3).IsRequired();
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
