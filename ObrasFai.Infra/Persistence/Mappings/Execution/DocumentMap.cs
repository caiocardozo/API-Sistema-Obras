using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class DocumentMap :EntityTypeConfiguration<Document>
    {
        public DocumentMap()
        {
            ToTable("OB104DOC");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODDOC").IsRequired();
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.DocumentTypeConstructionId).HasColumnName("CODTDO").IsRequired();
            Property(x => x.Date).HasColumnName("DATDOC").IsRequired();
            Property(x => x.Number).HasColumnName("NUMDOC").IsRequired().HasMaxLength(20);
            Property(x => x.Comments).HasColumnName("OBSDOC").HasMaxLength(300);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
