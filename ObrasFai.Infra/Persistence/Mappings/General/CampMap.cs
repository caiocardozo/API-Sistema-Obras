using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.General
{
    public class CampMap : EntityTypeConfiguration<Campus>
    {
        public CampMap()
        {
            ToTable("GER001CAM");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("CODCAM");

            Property(c => c.City)
                .HasColumnName("CIDCAM")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DateOfGeneration)
                .HasColumnName("DATGER")
                .IsRequired();

            Property(c => c.Status)
                .HasColumnName("SITCAM")
                .IsRequired()
                .HasMaxLength(7);

            Property(c => c.UserIdRegistered)
                .HasColumnName("USUGER")
                .IsRequired();
        }
    }
}
