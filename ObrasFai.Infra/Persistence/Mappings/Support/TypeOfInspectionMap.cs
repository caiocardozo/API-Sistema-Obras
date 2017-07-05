using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class TypeOfInspectionMap : EntityTypeConfiguration<TypeOfInspection>
    {
        public TypeOfInspectionMap()
        {
            ToTable("OB005TFI");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODTFI").IsRequired();
            Property(x => x.Description).HasColumnName("DESTFI").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITTFI").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
