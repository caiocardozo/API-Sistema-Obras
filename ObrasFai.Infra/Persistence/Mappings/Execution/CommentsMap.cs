using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class CommentsMap : EntityTypeConfiguration<Comment>
    {
        public CommentsMap()
        {
            ToTable("OB103OBS");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODOBS").IsRequired();
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.NatureId).HasColumnName("CODNAT").IsRequired();
            Property(x => x.Date).HasColumnName("DATOBS").IsRequired();
            Property(x => x.Text).HasColumnName("TXTOBS").IsRequired().HasMaxLength(3000);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
