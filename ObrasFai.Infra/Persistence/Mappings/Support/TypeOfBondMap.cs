using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class TypeOfBondMap : EntityTypeConfiguration<TypeOfBond>
    {
        public TypeOfBondMap()
        {
            ToTable("OB007TCA");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODTCA").IsRequired();
            Property(x => x.Description).HasColumnName("DESTCA").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITTCA").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
