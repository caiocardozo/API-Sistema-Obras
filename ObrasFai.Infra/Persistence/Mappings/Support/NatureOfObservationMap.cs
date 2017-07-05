using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class NatureOfObservationMap : EntityTypeConfiguration<NatureOfObservation>
    {
        public NatureOfObservationMap()
        {
            ToTable("OB001NAT");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODNAT").IsRequired();
            Property(x => x.Description).HasColumnName("DESNAT").IsRequired().HasMaxLength(30);
            Property(x => x.InternallyAvailable).HasColumnName("SOMINT").IsRequired().HasMaxLength(3);
            Property(x => x.Status).HasColumnName("SITNAT").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
