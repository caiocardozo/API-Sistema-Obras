using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Infra.Persistence.Mappings.Support
{
    public class SituationMap : EntityTypeConfiguration<Situation>
    {
        public SituationMap()
        {
            ToTable("OB002SIT");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODSIT").IsRequired();
            Property(x => x.Description).HasColumnName("DESSIT").IsRequired().HasMaxLength(30);
            Property(x => x.Status).HasColumnName("SITSIT").IsRequired().HasMaxLength(7);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();


        }
    }
}
