using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class DocumentTypeConstructionMap : EntityTypeConfiguration<DocumentTypeConstruction>
    {
        public DocumentTypeConstructionMap()
        {
            ToTable("OB004TDO");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODTDO").IsRequired();
            Property(x => x.Description).HasColumnName("DESTDO").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITTDO").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
