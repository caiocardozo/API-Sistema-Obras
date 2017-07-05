using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class TypeOfConstructionMap : EntityTypeConfiguration<TypeOfConstruction>
    {
        public TypeOfConstructionMap()
        {
            ToTable("OB003TIP");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODTIP").IsRequired();
            Property(x => x.Description).HasColumnName("DESTIP").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITTIP").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();


        }
    }
}
