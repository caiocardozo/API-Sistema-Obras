using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class TypeOfContractMap : EntityTypeConfiguration<TypeOfContract>
    {
        public TypeOfContractMap()
        {
            ToTable("OB006TCO");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODTCO").IsRequired();
            Property(x => x.IntegratedSapiens).HasColumnName("INTSAP").IsRequired().HasMaxLength(3);
            Property(x => x.Description).HasColumnName("DESTCO").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITTCO").IsRequired().HasMaxLength(7);
            Property(x => x.ServiceTransaction).HasColumnName("TNSSER").HasMaxLength(6);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
