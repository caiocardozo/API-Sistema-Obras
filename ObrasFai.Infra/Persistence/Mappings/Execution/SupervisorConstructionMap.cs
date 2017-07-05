using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class SupervisorConstructionMap : EntityTypeConfiguration<SupervisorConstruction>
    {
        public SupervisorConstructionMap()
        {
            ToTable("OB108FOB");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODFOB").IsRequired();
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.SupervisorId).HasColumnName("CODFIS").IsRequired();
            Property(x => x.Status).HasColumnName("SITFOB").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
